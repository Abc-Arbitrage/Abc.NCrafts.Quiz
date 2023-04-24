using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance1.Level3.Q007
{
    [ShortRunJob]
    public class Performance1_Bench007
    {
        [Benchmark]
        public void RunAnswer1() => Answer1.Run();
        
        [Benchmark]
        public void RunAnswer2() => Answer2.Run();
    }
}
