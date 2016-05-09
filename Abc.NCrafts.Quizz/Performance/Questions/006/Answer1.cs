﻿using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._006
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        private const int _rowCount = 200;
        private const int _columnCount = 50000;
        private static readonly int[][] _matrix;

        static Answer1()
        {
            _matrix = Enumerable.Range(0, _rowCount)
                                .Select(_ => Enumerable.Range(0, _columnCount).ToArray())
                                .ToArray();
        }

        public static void Run()
        {
            var sum = 0;
            // begin
            for (var rowIndex = 0; rowIndex < _rowCount; rowIndex++)
            {
                for (var columnIndex = 0; columnIndex < _columnCount; columnIndex++)
                {
                    sum += _matrix[rowIndex][columnIndex];
                }
            }
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}