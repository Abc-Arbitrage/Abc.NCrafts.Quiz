using System;

namespace Abc.NCrafts.Quizz.Allocation.Questions.Q17
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        public static void Run()
        {
            Create(0);

            // begin
            var item = Create(1);
            // end

            Logger.Log("Value: {0}", item.Value);
        }

        private static Item Create(int value)
        {
            return Create(x => new Item { Value = x }, value);
        }

        private static T Create<T>(Func<int, T> builder, int i)
        {
            return builder.Invoke(i);
        }

        private struct Item
        {
            public int Value;
        }
    }
}