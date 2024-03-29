﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level1.Q000
{
    public class Answer1
    {
        private static List<int> _items;

        static Answer1()
        {
            _items = Enumerable.Range(0, 200)
                               .ToList();
        }

        public static void Run()
        {
            var value = Random.Shared.Next(0, 500);
            
            // begin
            var hasValue = _items.Contains(value);
            // end
            
            Logger.Log($"Found: {hasValue}");
        }
    }
}