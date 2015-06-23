using System;

namespace Abc.NCrafts.Quizz.Questions._026
{
    public class Answer3
    {
        private static Key _key = new Key();

        public static void Run()
        {
            const int days = 3;

            // begin
            var now = DateTime.Now;
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