﻿using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Allocation.Level3.Q011
{
    public class Answer3
    {
        private static Queue<int> _values = new(new[] { 1, 2, 3 });

        public static void Run()
        {
            // begin
            var first = _values.First();
            // end

            Logger.Log($"First: {first}");
        }
    }
}