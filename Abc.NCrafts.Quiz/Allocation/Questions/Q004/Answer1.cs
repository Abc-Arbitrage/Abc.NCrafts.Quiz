﻿using System.Collections.Generic;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q004
{
    public class Answer1
    {
        public static void Run()
        {
            var values = new List<int>();

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