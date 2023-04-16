﻿using System;
using System.Runtime.CompilerServices;

namespace Abc.NCrafts.Quiz.Performance.Questions.Q017
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var sum = 0L;
            for (var index = 0; index < 100; index++)
            {
                var item = new Item { Value2 = index };
                sum += GetValue2(item);
            }
            // end
            Logger.Log($"Sum: {sum}");
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static long GetValue2(Item item)
        {
            return item.Value2;
        }

        private class Item
        {
            public long Value1 { get; set; }
            public long Value2 { get; set; }
            public DateTime Value3 { get; set; }
            public decimal Value4 { get; set; }
            public TimeSpan Value5 { get; set; }
        }
    }
}