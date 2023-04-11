using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance.Questions.Q001
{
    [MemoryDiagnoser]
    public class PerformanceBench001
    {
        [Benchmark]
        public void RunAnswer1() => Answer1.Run();
        
        [Benchmark]
        public void RunAnswer2() => Answer2.Run();
    }
}
