﻿using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance2.Level1.Q002
{
    public class Answer2
    {
        private static List<decimal> _items;

        static Answer2()
        {
            _items = Enumerable.Repeat(42m, 50)
                               .ToList();
        }

        public static void Run()
        {
            // begin
            var sum = _items.Sum();
            // end
            
            Logger.Log($"Sum: {sum}");
        }
    }
}
