using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level2.Q002
{
    [CorrectAnswer]
    public class Answer1
    {
        private static int[] _items;

        static Answer1()
        {
            _items = Enumerable.Range(0, 5)
                               .ToArray();
        }

        public static int IterationCount = 10;

        public static int Run()
        {
            // begin
            var result = 0;
            for (var iteration = 0; iteration < IterationCount; iteration++)
            {
                result += Compute(_items);
            }
            // end

            return result;
        }
        
        private static int Compute(int[] items)
        {
            var sum = 0;

            for (var index = 0; index < items.Length; index++)
            {
                sum += items[index];
            }

            return sum;
        }
    }
}
