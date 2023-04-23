using System;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level3.Q015
{
    public class Answer1
    {
        private static readonly int _threshold;
        private static readonly int[] _values;

        static Answer1()
        {
            _values = Enumerable.Range(0, 1_000_000)
                                .OrderBy(_ => Guid.NewGuid())
                                .ToArray();
            _threshold = _values.Length / 2;
        }

        public static void Run()
        {
            var count = 0;

            // begin
            foreach (var value in _values)
            {
                if (value > _threshold)
                    count++;
            }
            // end

            Logger.Log($"{count} values greater than {_threshold}");
        }
    }
}
