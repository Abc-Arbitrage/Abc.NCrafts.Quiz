﻿using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q001
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var i = 42;
            Nullable<double> nullable = i;
            // end
            
            Logger.Log($"Value: {nullable}");
        }
    }
}
