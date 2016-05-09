namespace Abc.NCrafts.Quizz.Performance.Questions._005
{
    public class Answer2
    {
        private static readonly int[,] _matrix;

        static Answer2()
        {
            _matrix = new int[10, 50];
            for (var rowIndex = 0; rowIndex < _matrix.GetLength(0); rowIndex++)
            {
                for (var columnIndex = 0; columnIndex < _matrix.GetLength(1); columnIndex++)
                {
                    _matrix[rowIndex, columnIndex] = columnIndex;
                }
            }
        }

        public static void Run()
        {
            var sum = 0;
            // begin
            for (var rowIndex = 0; rowIndex < _matrix.GetLength(0); rowIndex++)
            {
                for (var columnIndex = 0; columnIndex < _matrix.GetLength(1); columnIndex++)
                {
                    sum += _matrix[rowIndex, columnIndex];
                }
            }
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}