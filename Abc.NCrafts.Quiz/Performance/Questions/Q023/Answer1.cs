﻿using System.Linq;

namespace Abc.NCrafts.Quiz.Performance.Questions.Q023
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        private static readonly int[] _values;

        static Answer1()
        {
            _values = Enumerable.Range(0, 1_000_000)
                                .ToArray();
        }

        public static unsafe void Run()
        {
            var sum = 0L;

            // begin
            fixed (int* values = _values)
            {
                for (var i = 0; i < _values.Length; i++)
                {
                    sum += values[i];
                }
            }
            // end
            Logger.Log($"Sum: {sum}");
        }
    }
}
