﻿using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q022
{
    [MemoryDiagnoser, ShortRunJob]
    public class Allocation_Bench022
    {
        [Benchmark]
        public void RunAnswer1() => Answer1.Run();
        
        [Benchmark]
        public void RunAnswer2() => Answer2.Run();

        [Benchmark]
        public void RunAnswer3() => Answer3.Run();
    }
}
