namespace Abc.NCrafts.Quizz.Performance.Questions._005
{
    public class Answer2
    {
        private static readonly int[,] _matrix;

        static Answer2()
        {
            _matrix = new int[10, 50];
            for (var row = 0; row < _matrix.GetLength(0); row++)
            {
                for (var column = 0; column < _matrix.GetLength(1); column++)
                {
                    _matrix[row, column] = column;
                }
            }
        }

        public static void Run()
        {
            var sum = 0;
            // begin
            for (var row = 0; row < _matrix.GetLength(0); row++)
            {
                for (var column = 0; column < _matrix.GetLength(1); column++)
                {
                    sum += _matrix[row, column];
                }
            }
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}