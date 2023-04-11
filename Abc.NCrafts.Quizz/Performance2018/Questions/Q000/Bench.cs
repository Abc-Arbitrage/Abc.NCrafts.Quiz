﻿using System;
using BenchmarkDotNet.Attributes;

namespace Abc.NCrafts.Quizz.Performance2018.Questions.Q000
{
    public class Bench000
    {
        private readonly Answer1 _answer1 = new Answer1();
        private readonly Answer2 _answer2 = new Answer2();

        [Benchmark(Baseline = true)]
        public Guid Answer1() => _answer1.Run();

        [Benchmark]
        public Guid Answer2() => _answer2.Run();
    }
}
