using System;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level3.Q007
{
    public class Answer2
    {
        private const int _count = 200;
        private static readonly int[] _x;
        private static readonly int[] _result;

        static Answer2()
        {
            _x = Enumerable.Range(0, _count).ToArray();
            _result = Enumerable.Range(0, _count).ToArray();
        }

        public static void Run()
        {
            Array.Clear(_result, 0, _count);
            // begin
            for (var index = 1; index < _count; index++)
            {
                _result[index] = _x[index] + _result[index - 1];
            }
            // end
            Logger.Log($"Sum: {_result.Sum()}");
        }
    }
}
