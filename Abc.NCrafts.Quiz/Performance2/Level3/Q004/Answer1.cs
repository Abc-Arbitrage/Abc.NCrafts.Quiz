﻿using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Abc.NCrafts.Quiz.Performance2.Level3.Q004
{
    public class Answer1
    {
        private readonly int[] _buffer = Enumerable.Range(0, 16 * 1024)
                                                   .ToArray();

        public int Run()
        {
            var sum = 0;

            // begin
            var byteSpan = MemoryMarshal.AsBytes(_buffer.AsSpan());

            foreach (var value in byteSpan)
                sum += value;
            // end

            return sum;
        }
    }
}
