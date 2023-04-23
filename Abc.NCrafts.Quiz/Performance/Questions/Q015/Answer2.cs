using System.Linq;

namespace Abc.NCrafts.Quiz.Performance.Questions.Q015
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer2
    {
        private static readonly int _threshold;
        private static readonly int[] _values;

        static Answer2()
        {
            _values = Enumerable.Range(0, 1_000_000)
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
