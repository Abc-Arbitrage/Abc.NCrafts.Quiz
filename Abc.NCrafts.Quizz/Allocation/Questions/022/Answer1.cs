namespace Abc.NCrafts.Quizz.Questions._022
{
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var nCrafts = new NCrafts(3);
            nCrafts.Array[0] = 42;
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
