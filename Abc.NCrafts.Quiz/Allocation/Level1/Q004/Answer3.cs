using System.Collections.Generic;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q004
{
    public class Answer3
    {
        public static void Run()
        {
            var values = new List<int>(10);

            // begin
            for (var i = 0; i < 20; i++)
            {
                values.Add(42);
            }
            // end

            Logger.Log($"Count: {values.Count}");
        }
    }
}