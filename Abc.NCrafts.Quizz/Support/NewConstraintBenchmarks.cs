using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quizz.Support
{
    [MemoryDiagnoser]
    public class NewConstraintBenchmarks
    {
        [Benchmark]
        public int Value()
        {
            return Factory.Create<Item>().Value;
        }

        public static class Factory
        {
            public static T Create<T>() where T : new()
            {
                return new T();
            }
        }

        public struct Item
        {
            public int Value;
        }
    }
}
