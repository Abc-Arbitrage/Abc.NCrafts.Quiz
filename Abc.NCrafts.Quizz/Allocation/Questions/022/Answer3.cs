namespace Abc.NCrafts.Quizz.Questions._022
{
    public class Answer3
    {
        public static unsafe void Run()
        {
            // begin
            var nCrafts = new NCrafts(3);
            fixed (int* p = nCrafts.Array)
            {
                *p = 42;
            }
            // end

            Logger.Log("Value: ", nCrafts.Array[0]);
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
