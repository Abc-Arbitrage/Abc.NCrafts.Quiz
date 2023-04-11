using System.Linq;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q003
{
    public class Answer3
    {
        private static int[] _values 
            = Enumerable.Range(1, 100).ToArray();

        public static void Run()
        {
            // begin
            var sum = Sum(_values);
            // end

            Logger.Log("Sum: {0}", sum);
        }

        private static int Sum(int[] items)
        {
            var sum = 0;
            foreach (var item in items.Cast<int>())
            {
                sum += item;
            }
            return sum;
        }
    }
}