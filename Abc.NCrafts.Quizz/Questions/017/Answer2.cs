using System;

namespace Abc.NCrafts.Quizz.Questions._017
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var item = CreateAndSet(() =>
            {
                return Activator.CreateInstance<Item>();
            }, 42);
            // end

            Logger.Log("Value: {0}", item.Value);
        }

        private static T CreateAndSet<T>(Func<T> builder, int i)
            where T : ISettable
        {
            var item = builder.Invoke();
            item.Value = i;
            return item;
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