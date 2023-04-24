using System.Linq;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q007
{
    public class Answer3
    {
        private static string _text = "ABC123XYZ";

        public static void Run()
        {
            // begin
            var numericPart = _text.Skip(3).Take(3).ToArray();
            var value = int.Parse(numericPart);
            // end
            
            Logger.Log($"Value: {value}");
        }
    }
}