using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._023
{
    public class Answer2
    {
        private static readonly int[] _values;

        static Answer2()
        {
            _values = Enumerable.Range(0, 1000 * 1000).ToArray();
        }

        public static void Run()
        {
            var sum = 0L;

            // begin
            for (var i = 0; i < _values.Length; i++)
            {
                sum += _values[i];
            }
            // end

            Logger.Log($"Sum: {sum}");
        }
    }
}
