using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance2.Level2.Q025
{
    [DisassemblyDiagnoser]
    public class Performance2_Bench025
    {
        [Benchmark(Baseline = true)]
        public void RunAnswer1() => Answer1.Run();

        [Benchmark]
        public void RunAnswer2() => Answer2.Run();
    }
}
