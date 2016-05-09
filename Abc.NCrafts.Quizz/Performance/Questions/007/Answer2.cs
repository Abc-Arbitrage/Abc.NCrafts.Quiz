using System;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._007
{
    public class Answer2
    {
        private const int _count = 200;
        private static readonly int[] _x = Enumerable.Range(0, _count).ToArray();
        private static readonly int[] _result = Enumerable.Range(0, _count).ToArray();

        public static void Run()
        {
            Array.Clear(_result, 0, _count);
            // begin
            for (var index = 1; index < _count; index++)
            {
                _result[index] = _x[index] + _result[index - 1];
            }
            // end
            Logger.Log("Sum: {0}", _result.Sum());
        }
    }
}