using System;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._015
{
    public class Answer1
    {
        private static readonly int[] _values;
        private static readonly int _threshold;

        static Answer1()
        {
            _values = Enumerable.Range(0, 1000 * 1000).OrderBy(_ => Guid.NewGuid()).ToArray();
            _threshold = _values.Length / 2;
        }

        public static void Run()
        {
            var count = 0;

            // begin
            for (var i = 0; i < _values.Length; i++)
            {
                if (_values[i] > _threshold)
                    count++;
            }
            // end

            Logger.Log($"{count} values greater than {_threshold}");
        }
    }
}
