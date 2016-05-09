using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._014
{
    public class Answer2
    {
        private static readonly Random _random = new Random();

        private static readonly List<int> _values = Enumerable.Range(0, 200)
                                                              .Select(_ => _random.Next(5000))
                                                              .ToList();

        public static void Run()
        {
            var previous = 0;
            var sum = 0;
            // begin
            foreach (var value in _values)
            {
                if (value < 10)
                    sum += previous;
                else if (value % 2 == 0)
                    sum += 1;
                else if (value >= 100)
                    sum += 42;

                previous = value;
            }
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}