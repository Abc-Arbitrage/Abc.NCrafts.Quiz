using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quizz.Performance.Questions.Q022
{
    [MemoryDiagnoser]
    public class PerformanceBench022
    {
        [Benchmark]
        public void RunAnswer1() => Answer1.Run();
        
        [Benchmark]
        public void RunAnswer2() => Answer2.Run();
    }
}
