﻿using System;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance.Questions.Q007
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer1
    {
        private const int _count = 200;
        private static readonly int[] _x;
        private static readonly int[] _result;

        static Answer1()
        {
            _x = Enumerable.Range(0, _count).ToArray();
            _result = Enumerable.Range(0, _count).ToArray();
        }

        public static void Run()
        {
            Array.Clear(_result, 0, _count);
            // begin
            for (var index = 1; index < _count; index++)
            {
                _result[index] = _x[index] + _x[index - 1];
            }
            // end
            Logger.Log($"Sum: {_result.Sum()}");
        }
    }
}
