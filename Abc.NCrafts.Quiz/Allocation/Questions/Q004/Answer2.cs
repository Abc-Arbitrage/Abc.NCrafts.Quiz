﻿using System.Collections.Generic;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q004
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        public static void Run()
        {
            var values = new List<int>(10);

            // begin
            for (var i = 0; i < 10; i++)
            {
                values.Add(42);
            }
            // end

            Logger.Log($"Count: {values.Count}");
        }
    }
}