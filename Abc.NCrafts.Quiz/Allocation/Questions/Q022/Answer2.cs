namespace Abc.NCrafts.Quiz.Allocation.Questions.Q022
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        public static unsafe void Run()
        {
            var array = new NCrafts[10];

            // begin
            for (var i = 0; i < array.Length; i++)
            {
                var value = new NCrafts();
                value.Array[0] = 1;

                array[i] = value;
            }
            // end

            Logger.Log("Value: ", array.Length);
        }

        private unsafe struct NCrafts
        {
            public fixed int Array[3];
        }
    }
}
