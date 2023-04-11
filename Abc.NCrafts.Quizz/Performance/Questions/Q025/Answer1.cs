using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions.Q025
{
    public class Answer1
    {
        private static int[] _values;

        static Answer1()
        {
            _values = Enumerable.Range(0, 1_000_000)
                                .ToArray();
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