using System.Linq;

namespace Abc.NCrafts.Quiz.Performance.Questions.Q005
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        private static readonly int[][] _matrix;

        static Answer1()
        {
            _matrix = Enumerable.Range(0, 10)
                                .Select(_ => Enumerable.Range(0, 50).ToArray())
                                .ToArray();
        }

        public static void Run()
        {
            var sum = 0;
            // begin
            for (var row = 0; row < _matrix.Length; row++)
            {
                for (var column = 0; column < _matrix[row].Length; column++)
                {
                    sum += _matrix[row][column];
                }
            }
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}