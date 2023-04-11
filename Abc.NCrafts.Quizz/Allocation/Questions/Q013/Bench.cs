using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quizz.Allocation.Questions.Q013
{
    [MemoryDiagnoser]
    public class Allocation_Bench013
    {
        [Benchmark]
        public void Answer1() => Q013.Answer1.Run();
        
        [Benchmark]
        public void Answer2() => Q013.Answer2.Run();

        [Benchmark]
        public void Answer3() => Q013.Answer3.Run();
    }
}
