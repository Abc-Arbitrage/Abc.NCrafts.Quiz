using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q017
{
    [MemoryDiagnoser, ShortRunJob]
    public class Allocation_Bench017
    {
        [Benchmark]
        public void RunAnswer1() => Answer1.Run();
        
        [Benchmark]
        public void RunAnswer2() => Answer2.Run();

        [Benchmark]
        public void RunAnswer3() => Answer3.Run();
    }
}
