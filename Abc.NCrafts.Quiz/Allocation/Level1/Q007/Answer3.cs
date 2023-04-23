using System.Linq;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q007
{
    public class Answer3
    {
        private static string _text = "ABC123XYZ";

        public static void Run()
        {
            // begin
            var value = int.Parse(_text.Skip(3).Take(3).ToArray());
            // end
            
            Logger.Log($"Value: {value}");
        }
    }
}