using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Parameters;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;

// TODO replace this with the built-in feature of BenchmarkDotNet v0.11, this is a stripped-down version

// ReSharper disable CheckNamespace

namespace BenchmarkDotNet.Attributes.Validators
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Assembly)]
    public class ReturnValueValidatorAttribute : Attribute, IConfigSource
    {
        public ReturnValueValidatorAttribute()
            => Config = ManualConfig.CreateEmpty().With(ReturnValueValidator.FailOnError);

        public IConfig Config { get; }
    }
}

namespace BenchmarkDotNet.Validators
{
    public class ReturnValueValidator : IValidator
    {
        public static ReturnValueValidator FailOnError { get; } = new ReturnValueValidator();

        public bool TreatsWarningsAsErrors => true;

        private ReturnValueValidator()
        {
        }

        public IEnumerable<ValidationError> Validate(ValidationParameters validationParameters)
        {
            var errors = new List<ValidationError>();

            foreach (var typeGroup in validationParameters.Benchmarks.GroupBy(benchmark => benchmark.Target.Type))
            {
                if (!TryCreateBenchmarkTypeInstance(typeGroup.Key, errors, out var benchmarkTypeInstance))
                    continue;

                ExecuteBenchmarks(benchmarkTypeInstance, typeGroup, errors);
            }

            return errors;
        }

        private bool TryCreateBenchmarkTypeInstance(Type type, List<ValidationError> errors, out object instance)
        {
            try
            {
                instance = Activator.CreateInstance(type);

                return true;
            }
            catch (Exception ex)
            {
                errors.Add(new ValidationError(
                               TreatsWarningsAsErrors,
                               $"Unable to create instance of {type.Name}, exception was: {GetDisplayExceptionMessage(ex)}"));

                instance = null;
                return false;
            }
        }

        private void ExecuteBenchmarks(object benchmarkTypeInstance, IEnumerable<Benchmark> benchmarks, List<ValidationError> errors)
        {
            foreach (var parameterGroup in benchmarks.GroupBy(i => i.Parameters, ParameterInstancesEqualityComparer.Instance))
            {
                var results = new List<(Benchmark benchmark, object returnValue)>();
                bool hasErrorsInGroup = false;

                foreach (var benchmark in parameterGroup)
                {
                    try
                    {
                        var result = benchmark.Target.Method.Invoke(benchmarkTypeInstance, null);

                        if (benchmark.Target.Method.ReturnType != typeof(void))
                            results.Add((benchmark, result));
                    }
                    catch (Exception ex)
                    {
                        hasErrorsInGroup = true;

                        errors.Add(new ValidationError(
                                       TreatsWarningsAsErrors,
                                       $"Failed to execute benchmark '{benchmark.DisplayInfo}', exception was: '{GetDisplayExceptionMessage(ex)}'",
                                       benchmark));
                    }
                }

                if (hasErrorsInGroup || results.Count == 0)
                    continue;

                if (results.Any(result => !InDepthEqualityComparer.Instance.Equals(result.returnValue, results[0].returnValue)))
                {
                    errors.Add(new ValidationError(
                                   TreatsWarningsAsErrors,
                                   $"Inconsistent benchmark return values in {results[0].benchmark.Target.DisplayInfo}: {string.Join(", ", results.Select(r => $"{r.benchmark.Target.MethodDisplayInfo}: {r.returnValue}"))} {parameterGroup.Key.DisplayInfo}"));
                }
            }
        }

        private static string GetDisplayExceptionMessage(Exception ex)
        {
            if (ex is TargetInvocationException targetInvocationException)
                ex = targetInvocationException.InnerException;

            return ex?.Message ?? "Unknown error";
        }

        private class ParameterInstancesEqualityComparer : IEqualityComparer<ParameterInstances>
        {
            public static ParameterInstancesEqualityComparer Instance { get; } = new ParameterInstancesEqualityComparer();

            public bool Equals(ParameterInstances x, ParameterInstances y)
            {
                if (ReferenceEquals(x, y))
                    return true;

                if (x == null || y == null)
                    return false;

                if (x.Count != y.Count)
                    return false;

                return x.Items.OrderBy(i => i.Name).Zip(y.Items.OrderBy(i => i.Name), (a, b) => a.Name == b.Name && Equals(a.Value, b.Value)).All(i => i);
            }

            public int GetHashCode(ParameterInstances obj)
            {
                if (obj.Count == 0)
                    return 0;

                unchecked
                {
                    int result = 0;

                    foreach (var paramInstance in obj.Items.OrderBy(i => i.Name))
                    {
                        result = (result * 397) ^ paramInstance.Name.GetHashCode();
                        result = (result * 397) ^ (paramInstance.Value?.GetHashCode() ?? 0);
                    }

                    return result;
                }
            }
        }

        private class InDepthEqualityComparer : IEqualityComparer
        {
            public static InDepthEqualityComparer Instance { get; } = new InDepthEqualityComparer();

            [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
            public new bool Equals(object x, object y)
            {
                if (ReferenceEquals(x, y) || object.Equals(x, y))
                    return true;

                if (x == null || y == null)
                    return false;

                return CompareEquatable(x, y) || CompareEquatable(y, x) || CompareStructural(x, y) || CompareStructural(y, x);
            }

            private static bool CompareEquatable(object x, object y)
            {
                var yType = y.GetType();

                var equatableInterface = x.GetType().GetInterfaces().FirstOrDefault(i => i.IsGenericType
                                                                                         && i.GetGenericTypeDefinition() == typeof(IEquatable<>)
                                                                                         && i.GetGenericArguments().Single().IsAssignableFrom(yType));

                if (equatableInterface == null)
                    return false;

                var method = equatableInterface.GetMethod(nameof(IEquatable<object>.Equals), BindingFlags.Public | BindingFlags.Instance);
                return (bool?)method?.Invoke(x, new[] { y }) ?? false;
            }

            private bool CompareStructural(object x, object y)
            {
                if (x is IStructuralEquatable xStructuralEquatable)
                    return xStructuralEquatable.Equals(y, this);

                var xArray = ToStructuralEquatable(x);
                var yArray = ToStructuralEquatable(y);

                if (xArray != null && yArray != null)
                    return Equals(xArray, yArray);

                return false;

                Array ToStructuralEquatable(object obj)
                {
                    switch (obj)
                    {
                        case Array array:
                            return array;

                        case IDictionary dict:
                            return dict.Keys.Cast<object>().OrderBy(k => k).Select(k => (k, dict[k])).ToArray();

                        case IEnumerable enumerable:
                            return enumerable.Cast<object>().ToArray();

                        default:
                            return null;
                    }
                }
            }

            public int GetHashCode(object obj) => StructuralComparisons.StructuralEqualityComparer.GetHashCode(obj);
        }
    }
}
