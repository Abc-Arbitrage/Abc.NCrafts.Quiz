using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._010
{
    public class Answer2
    {
        private static readonly Dictionary<string, int> _values;

        static Answer2()
        {
            var random = new Random();
            _values = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
            foreach (var value in Enumerable.Range(0, 500).Select(_ => random.Next(5000)))
            {
                _values[value.ToString()] = value;
            }
        }

        public static void Run()
        {
            // begin
            var hasValue = _values.ContainsKey("555");
            // end

            Logger.Log(hasValue ? "Hooray!" : "Alas!");
        }
    }
}