using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q010
{
    [MemoryDiagnoser]
    public class Allocation_Bench010
    {
        [Benchmark]
        public void RunAnswer1() => Answer1.Run();
        
        [Benchmark]
        public void RunAnswer2() => Answer2.Run();

        [Benchmark]
        public void RunAnswer3() => Answer3.Run();
    }
}
