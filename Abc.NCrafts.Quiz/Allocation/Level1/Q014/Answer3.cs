﻿using System;
using System.Text;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q014
{
    public class Answer3
    {
        private static StringBuilder _builder = new(10);
        
        public static void Run()
        {
            var s = "NewCrafts";

            // begin
            _builder.Clear();
            for (var i = 0; i < s.Length; i++)
            {
                _builder.Append(char.ToUpper(s[i]));
            }

            var upper = _builder.ToString();
            // end

            Logger.Log(upper);
        }
    }
}
