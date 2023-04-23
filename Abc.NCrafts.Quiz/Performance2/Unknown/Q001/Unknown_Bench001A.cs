using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance2.Unknown.Q001
{
    [MemoryDiagnoser]
    [ReturnValueValidator]
    public class Unknown_Bench001A
    {
        private readonly Answer1 _answer1 = new Answer1();
        private readonly Answer2 _answer2 = new Answer2();

        [Benchmark(Baseline = true)]
        public string Answer1() => _answer1.Run();

        [Benchmark]
        public string Answer2() => _answer2.Run();
    }
}
