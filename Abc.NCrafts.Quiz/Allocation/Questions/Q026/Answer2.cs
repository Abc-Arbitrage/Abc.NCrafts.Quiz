using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q026
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer2
    {
        private static Key _key = new Key();

        public static void Run()
        {
            const int days = 1;

            // begin
            var now = DateTime.UtcNow;
            if (now.TimeOfDay.Days >= days)
                _key = new Key { Value = 42 };
            // end

            Logger.Log("Value: {0}", _key.Value);
        }

        private class Key
        {
            public int Value;
        }
    }
}