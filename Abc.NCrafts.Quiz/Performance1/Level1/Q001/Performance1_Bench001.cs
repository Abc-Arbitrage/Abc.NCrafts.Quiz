using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance1.Level1.Q001
{
    [MemoryDiagnoser]
    public class Performance1_Bench001
    {
        [Benchmark]
        public void RunAnswer1() => Answer1.Run();
        
        [Benchmark]
        public void RunAnswer2() => Answer2.Run();
    }
}
