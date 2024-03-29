﻿using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quiz.Performance2.Level2.Q010
{
    public class Performance2_Bench010
    {
        private readonly Answer1 _answer1 = new Answer1();
        private readonly Answer2 _answer2 = new Answer2();

        [Benchmark(Baseline = true)]
        public Task Answer1() => _answer1.Run();

        [Benchmark]
        public Task Answer2() => _answer2.Run();
    }
}
