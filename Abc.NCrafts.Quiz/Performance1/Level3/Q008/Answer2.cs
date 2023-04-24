using System;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level3.Q008
{
    [CorrectAnswer]
    public class Answer2
    {
        private static readonly int[] _values;

        static Answer2()
        {
            var random = new Random();
            _values = Enumerable.Range(0, 1_000)
                                .Select(x => random.Next(5000))
                                .ToArray();
        }

        public static void Run()
        {
            // begin
            var values = _values;
            var max1 = 0;
            var max2 = 0;
            var max3 = 0;
            var max4 = 0;
            for (var index = 0; index < values.Length; index += 4)
            {
                max1 = Math.Max(max1, values[index]);
                max2 = Math.Max(max2, values[index + 1]);
                max3 = Math.Max(max3, values[index + 2]);
                max4 = Math.Max(max4, values[index + 3]);
            }

            var max = Math.Max(Math.Max(max1, max2), Math.Max(max3, max4));
            // end
            
            Logger.Log($"Max: {max}");
        }
    }
}
