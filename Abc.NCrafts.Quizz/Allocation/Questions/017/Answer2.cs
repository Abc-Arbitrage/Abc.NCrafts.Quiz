using System;

namespace Abc.NCrafts.Quizz.Questions._017
{
    public class Answer2
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
            return Create(() => new Item(), value);
        }

        private static Item Create(Func<ValueType> builder, int i)
        {
            var item = (Item)builder.Invoke();
            item.Value = i;

            return item;
        }

        public struct Item
        {
            public int Value;
        }
    }
}