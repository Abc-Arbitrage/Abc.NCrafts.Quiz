using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance2.Level1.Q010
{
    [CorrectAnswer]
    public class Answer1
    {
        private static Dictionary<string, int> _values;

        static Answer1()
        {
            _values = new(StringComparer.OrdinalIgnoreCase);

            foreach (var _ in Enumerable.Range(0, 500))
            {
                var value = Random.Shared.Next(5000);
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
