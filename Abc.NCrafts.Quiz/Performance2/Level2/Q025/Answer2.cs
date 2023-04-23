using System.Linq;

namespace Abc.NCrafts.Quiz.Performance2.Level2.Q025
{
    [CorrectAnswer]
    public class Answer2
    {
        private static int[] _values;

        static Answer2()
        {
            _values = Enumerable.Range(0, 1_000_000)
                                .ToArray();
        }

        public static void Run()
        {
            var sum = 0L;
            // begin
            var values = _values;
            for (var i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            // end
            Logger.Log($"Sum: {sum}");
        }
    }
}
