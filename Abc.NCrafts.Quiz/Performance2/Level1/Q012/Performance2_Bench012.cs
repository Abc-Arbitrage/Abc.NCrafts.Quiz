﻿using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance2.Level1.Q012
{
    public class Performance2_Bench012
    {
        private readonly Answer1 _answer1 = new Answer1();
        private readonly Answer2 _answer2 = new Answer2();

        [Benchmark(Baseline = true)]
        public void Answer1() => _answer1.Run();

        [Benchmark]
        public void Answer2() => _answer2.Run();
    }
}
