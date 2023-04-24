using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance2.Level3.Q026
{
    public class Performance2_Bench026
    {
        [Benchmark(Baseline = true)]
        public void RunAnswer1() => Answer1.Run();

        [Benchmark]
        public void RunAnswer2() => Answer2.Run();
    }
}
