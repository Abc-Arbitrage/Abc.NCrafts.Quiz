﻿using System;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q001
{
    public class Answer3
    {
        public static void Run()
        {
            // begin
            var i = 42;
            IEquatable<int> equatable = i;
            // end
            
            Logger.Log($"Value: {equatable}");
        }
    }
}
