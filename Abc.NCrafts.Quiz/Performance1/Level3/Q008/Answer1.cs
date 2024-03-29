﻿using System;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level3.Q008
{
    public class Answer1
    {
        private static readonly int[] _values;

        static Answer1()
        {
            var random = new Random();
            _values = Enumerable.Range(0, 1_000)
                                .Select(x => random.Next(5000))
                                .ToArray();
        }

        public static void Run()
        {
            // begin
            var values = _values;
            var max = 0;
            for (var index = 0; index < values.Length; index++)
            {
                max = Math.Max(max, values[index]);
            }
            // end
            
            Logger.Log($"Max: {max}");
        }
    }
}