﻿using System;

namespace Abc.NCrafts.Quiz.Allocation.Level3.Q013
{
    [CorrectAnswer]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var areEqual = AreEqual("NewCrafts", "newcrafts");
            // end

            Logger.Log($"AreEqual: {areEqual}");
        }

        private static bool AreEqual(string value1, string value2)
        {
            var comparison = StringComparison.OrdinalIgnoreCase;
            return value1.Equals(value2, comparison);
        }
    }
}