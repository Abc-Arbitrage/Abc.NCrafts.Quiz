using System.Linq;

namespace Abc.NCrafts.Quiz.Allocation.Level2.Q003
{
    public class Answer3
    {
        private static int[] _values 
            = Enumerable.Range(1, 100).ToArray();

        public static void Run()
        {
            // begin
            var sum = 0;
            foreach (var item in _values.Cast<int>())
            {
                sum += item;
            }
            // end

            Logger.Log($"Sum: {sum}");
        }
    }
}