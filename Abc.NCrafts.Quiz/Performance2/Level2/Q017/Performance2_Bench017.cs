﻿using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance2.Level2.Q017
{
    public class Performance2_Bench017
    {
        [Benchmark]
        public void RunAnswer1() => Answer1.Run();

        [Benchmark]
        public void RunAnswer2() => Answer2.Run();
    }
}
