using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Abc.NCrafts.Quizz.Performance.Questions._017
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        private static readonly List<Item> _items;

        static Answer1()
        {
            _items = Enumerable.Range(0, 200)
                               .Select(x => new Item { Value2 = x })
                               .ToList();
        }

        public static void Run()
        {
            var sum = 0L;
            // begin
            foreach (var item in _items)
            {
                sum += GetValue2(item);
            }
            // end
            Logger.Log("Sum: {0}", sum);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static long GetValue2(Item item)
        {
            return item.Value2;
        }

        private class Item
        {
            public long Value1 { get; set; }
            public long Value2 { get; set; }
            public DateTime Value3 { get; set; }
            public decimal Value4 { get; set; }
        }
    }
}
