﻿using System;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q000
{
    public class Answer3
    {
        public static void Run()
        {
            // begin
            var action = new Action(Run);
            // end
            
            Logger.Log($"Action: {action}");
        }
    }
}