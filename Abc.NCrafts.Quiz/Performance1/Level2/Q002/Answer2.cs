using System.Linq;
using System.Runtime.CompilerServices;

namespace Abc.NCrafts.Quiz.Performance1.Level2.Q002
{
    [CorrectAnswer]
    public class Answer2
    {
        private static int[] _items;

        static Answer2()
        {
            _items = Enumerable.Range(0, 5)
                               .ToArray();
        }
        
        public static int IterationCount = 12;

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
