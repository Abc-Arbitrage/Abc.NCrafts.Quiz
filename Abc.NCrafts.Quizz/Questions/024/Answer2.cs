using System;

namespace Abc.NCrafts.Quizz.Questions._024
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer2
    {
        public static void Run()
        {
            var action = new Action<int>(i => { });
            var factory = new DelegateFactory();

            // begin
            var d = factory.Create(action);
            // end

            d.DynamicInvoke(42);
        }

        private class DelegateFactory
        {
            public Delegate Create<T>(Action<T> a)
            {
                var d = (Delegate)a;
                return d;
            }
        }
    }
}
