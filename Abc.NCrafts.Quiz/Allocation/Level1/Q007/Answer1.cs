namespace Abc.NCrafts.Quiz.Allocation.Level1.Q007
{
    public class Answer1
    {
        private static string _text = "ABC123XYZ";

        public static void Run()
        {
            // begin
            var value = int.Parse(_text.Substring(3, 3));
            // end
            
            Logger.Log($"Value: {value}");
        }
    }
}