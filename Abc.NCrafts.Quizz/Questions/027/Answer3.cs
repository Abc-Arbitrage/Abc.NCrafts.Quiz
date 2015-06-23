using System;

namespace Abc.NCrafts.Quizz.Questions._027
{
    public class Answer3
    {
        public static void Run()
        {
            var type = Type.GetType("System.Int32");

            // begin
            var key = new Key { Value = 42 };
            var result = type == typeof(int)
                ? key.GetHashCode()
                : key.Value.GetHashCode();
            // end

            Logger.Log("Result: {0}", result);
        }

        private struct Key
        {
            public int Value;
        }
    }
}