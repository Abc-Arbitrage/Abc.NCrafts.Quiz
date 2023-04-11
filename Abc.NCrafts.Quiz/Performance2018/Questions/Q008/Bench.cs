using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance2018.Questions.Q008
{
    [ReturnValueValidator, DisassemblyDiagnoser]
    public class Bench008
    {
        private readonly Answer1 _answer1 = new Answer1();
        private readonly Answer2 _answer2 = new Answer2();

        [Benchmark(Baseline = true)]
        public int Answer1() => _answer1.Run();

        [Benchmark]
        public int Answer2() => _answer2.Run();
    }
}
