﻿using System;

namespace Abc.NCrafts.Quiz.Allocation.Level2.Q006
{
    public class Answer2
    {
        public static void Run()
        {
            var obj = new object();

            // begin
            Execute(() => GC.KeepAlive(obj));
            // end
        }

        private static void Execute(Action action)
        {
            action();
        }
    }
}