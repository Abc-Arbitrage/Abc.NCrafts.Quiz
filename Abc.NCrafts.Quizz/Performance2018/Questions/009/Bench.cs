using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Validators;

namespace Abc.NCrafts.Quizz.Performance2018.Questions._009
{
    [ReturnValueValidator, DisassemblyDiagnoser]
    public class Bench009
    {
        private readonly Answer1 _answer1 = new Answer1();
        private readonly Answer2 _answer2 = new Answer2();

        [Benchmark(Baseline = true)]
        public void Answer1() => _answer1.Run();

        [Benchmark]
        public void Answer2() => _answer2.Run();
    }
}
