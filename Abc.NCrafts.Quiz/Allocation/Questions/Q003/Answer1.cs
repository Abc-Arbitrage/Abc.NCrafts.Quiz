﻿using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q003
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        private static List<int> _values 
            = Enumerable.Range(1, 100).ToList();

        public static void Run()
        {
            // begin
            var sum = 0;
            foreach (var item in _values)
            {
                sum += item;
            }
            // end

            Logger.Log($"Sum: {sum}");
        }
    }
}
