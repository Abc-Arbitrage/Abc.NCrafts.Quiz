using System.Collections.Generic;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q022
{
    public class Answer3
    {
        public static unsafe void Run()
        {
            var array = new NCrafts[10];

            // begin
            for (var i = 0; i < array.Length; i++)
            {
                var value = new NCrafts(3);
                value.Array[0] = 1;

                array[i] = value;
            }
            // end

            Logger.Log("Value: ", array.Length);
        }

        private struct NCrafts
        {
            public readonly List<int> Array;

            public NCrafts(int capacity)
            {
                Array = new List<int>(capacity);
            }
        }
    }
}
