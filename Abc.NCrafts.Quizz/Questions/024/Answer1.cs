using System;

namespace Abc.NCrafts.Quizz.Questions._024
{
    public class Answer1
    {
        public static void Run()
        {
            var factory = new DelegateFactory();
            var action = new CustomAction<int>(delegate { });

            // begin
            var d = factory.Create(action);
            // end

            d.DynamicInvoke(42);
        }

        public delegate void CustomAction<T>(T arg);

        private class DelegateFactory
        {
            public Delegate Create(CustomAction<int> action)
            {
                Delegate d = (Action<int>)action.Invoke;
                return d;
            }
        }
    }
}
