using System;

namespace Abc.NCrafts.Quizz.Questions._024
{
    public class Answer3
    {
        public static void Run()
        {
            var factory = new DelegateFactory();

            // begin
            var d = factory.Create();
            // end

            d.DynamicInvoke(42);
        }

        private class DelegateFactory
        {
            public Delegate Create()
            {
                Delegate d = (Action<int>)delegate { };
                return d;
            }
        }
    }
}
