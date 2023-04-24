using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance1.Level2.Q002
{
    [ShortRunJob, DisassemblyDiagnoser]
    public class Performance1_Bench002
    {
        [Benchmark]
        public int RunAnswer1() => Answer1.Run();
        
        [Benchmark]
        public int RunAnswer2() => Answer2.Run();
    }
}
