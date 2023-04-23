using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level1.Q000
{
    [CorrectAnswer]
    public class Answer2
    {
        private static HashSet<int> _items;

        static Answer2()
        {
            _items = Enumerable.Range(0, 200)
                               .ToHashSet();
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