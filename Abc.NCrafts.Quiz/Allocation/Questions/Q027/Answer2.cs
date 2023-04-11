namespace Abc.NCrafts.Quiz.Allocation.Questions.Q027
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var key = new Key { Value = 42 };
            var result = typeof(string).IsByRef
                ? key.Value.GetHashCode()
                : key.GetHashCode();
            // end

            Logger.Log("Result: {0}", result);
        }

        private struct Key
        {
            public int Value;
        }
    }
}