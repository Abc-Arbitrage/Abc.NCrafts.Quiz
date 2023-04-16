﻿using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q024
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer3
    {
        public static void Run()
        {
            // begin
            var tickCount = Environment.TickCount64;
            
            Span<char> buffer = stackalloc char[100];
            buffer.TryWrite($"TickCount: {tickCount}", out _);
            
            ConsumeString(buffer);
            // end
        }

        private static void ConsumeString(Span<char> s)
        {
            Logger.Log(s);
        }
    }
}