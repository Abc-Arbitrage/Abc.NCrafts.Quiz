using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Abc.NCrafts.Quiz.Performance.Questions.Q001
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
            var span = CollectionsMarshal.AsSpan(_items);
            
            // begin
            var hasValue = span.IndexOf(value) != -1;
            // end
            
            Logger.Log($"Found: {hasValue}");
        }
    }
}
