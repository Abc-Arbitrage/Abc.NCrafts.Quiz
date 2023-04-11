using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quizz.Performance.Questions._022
{
    [MemoryDiagnoser]
    public class Performance_Bench022
    {
        [Benchmark]
        public void RunAnswer1() => Answer1.Run();
        
        [Benchmark]
        public void RunAnswer2() => Answer2.Run();
    }
}
