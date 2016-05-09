using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._005
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
            for (var rowIndex = 0; rowIndex < _matrix.Length; rowIndex++)
            {
                for (var columnIndex = 0; columnIndex < _matrix[rowIndex].Length; columnIndex++)
                {
                    sum += _matrix[rowIndex][columnIndex];
                }
            }
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}