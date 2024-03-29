﻿namespace Abc.NCrafts.Quiz.Allocation.Level2.Q010
{
    public class Answer3
    {
        public static void Run()
        {
            // begin
            var values = GetValues();
            var sum = values.X + values.Y;
            // end

            Logger.Log($"Sum: {sum}");
        }

        private static Point GetValues()
            => new Point(10, 42);

        public record Point(int X, int Y);
    }
}