﻿using System;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance2.Level3.Q003
{
    public class Answer2
    {
        private readonly string[] _strings = Enumerable.Range(0, 16 * 1024)
                                                       .Select(i => new string(' ', i))
                                                       .ToArray();

        public int Run()
        {
            var sum = 0;

            // begin
            unchecked
            {
                foreach (var item in _strings.AsSpan())
                    sum += item.Length;
            }
            // end

            return sum;
        }
    }
}
