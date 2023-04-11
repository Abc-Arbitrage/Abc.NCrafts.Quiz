using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quizz.Questions._013
{
    [MemoryDiagnoser]
    public class Allocation_Bench013
    {
        [Benchmark]
        public void Answer1() => _013.Answer1.Run();
        
        [Benchmark]
        public void Answer2() => _013.Answer2.Run();

        [Benchmark]
        public void Answer3() => _013.Answer3.Run();
    }
}
