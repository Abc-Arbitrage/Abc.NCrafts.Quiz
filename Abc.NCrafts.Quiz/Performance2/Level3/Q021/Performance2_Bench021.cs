using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance2.Level3.Q021
{
    [ShortRunJob]
    public class Performance2_Bench021
    {
        [Benchmark(Baseline = true)]
        public void RunAnswer1() => Answer1.Run();

        [Benchmark]
        public void RunAnswer2() => Answer2.Run();
    }
}
