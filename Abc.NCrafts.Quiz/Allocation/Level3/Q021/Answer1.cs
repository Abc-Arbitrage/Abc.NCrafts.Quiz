﻿using System.Threading.Tasks;

namespace Abc.NCrafts.Quiz.Allocation.Level3.Q021
{
    [CorrectAnswer]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var task = LoadValue();
            if (task.IsCompleted)
            {
                var result = task.GetAwaiter().GetResult();
                Logger.Log($"Task completed, Result: {result}");
            }
            // end
        }

        private static Task<int> LoadValue()
        {
            return Task.FromResult(1);
        }
    }
}
