using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance1.Level1.Q005
{
    [MemoryDiagnoser]
    public class Performance_Bench005
    {
        [Benchmark]
        public void RunAnswer1() => Answer1.Run();
        
        [Benchmark]
        public void RunAnswer2() => Answer2.Run();
    }
}
