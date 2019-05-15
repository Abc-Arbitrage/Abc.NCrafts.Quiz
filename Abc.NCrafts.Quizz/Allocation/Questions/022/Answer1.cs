namespace Abc.NCrafts.Quizz.Questions._022
{
    public class Answer1
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
            public readonly int[] Array;

            public NCrafts(int capacity)
            {
                Array = new int[capacity];
            }
        }
    }
}
