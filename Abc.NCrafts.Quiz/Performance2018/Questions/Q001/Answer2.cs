using System;

namespace Abc.NCrafts.Quiz.Performance2018.Questions.Q001
{
    public class Answer2
    {
        private int _counter;

        public int Run()
        {
            _counter = 0;

            // begin
            var pair = Tuple.Create(GetCounter(), GetCounter());
            var reversed = Tuple.Create(pair.Item2, pair.Item1);
            return reversed.Item1 - reversed.Item2;
            // end
        }

        private int GetCounter()
            => ++_counter;
    }
}
