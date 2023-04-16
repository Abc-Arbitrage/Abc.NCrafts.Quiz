namespace Abc.NCrafts.Quiz.Allocation.Questions.Q001
{
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var i = 42;
            object obj = i;
            // end
            
            Logger.Log($"Value: {obj}");
        }
    }
}
