using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level2.Q006
{
    public class Answer2
    {
        private const int _rowCount = 200;
        private const int _columnCount = 50000;
        private static readonly int[][] _matrix;

        static Answer2()
        {
            _matrix = Enumerable.Range(0, _rowCount)
                                .Select(_ => Enumerable.Range(0, _columnCount).ToArray())
                                .ToArray();
        }

        public static void Run()
        {
            var sum = 0;
            // begin
            for (var column = 0; column < _columnCount; column++)
            {
                for (var row = 0; row < _rowCount; row++)
                {
                    sum += _matrix[row][column];
                }
            }
            // end
            Logger.Log($"Sum: {sum}");
        }
    }
}