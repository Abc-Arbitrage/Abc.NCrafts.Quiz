using System;

namespace Abc.NCrafts.Quizz.Questions._017
{
    public class Answer3
    {
        public static void Run()
        {
            // begin
            var item = CreateAndSet<Item>(() => new Item(), 42);
            // end

            Logger.Log("Value: {0}", item.Value);
        }

        private static T CreateAndSet<T>(Func<ISettable> builder,
                                         int i)
            where T : ISettable
        {
            var item = builder.Invoke();
            item.Value = i;
            return (T)item;
        }

        private interface ISettable
        {
            int Value { set; }
        }

        private struct Item : ISettable
        {
            public int Value { get; set; }
        }
    }
}