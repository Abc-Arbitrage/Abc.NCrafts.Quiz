using System.Linq;

namespace Abc.NCrafts.Quizz.Performance2018.Questions.Q003
{
    public class Answer1
    {
        private readonly string[] _strings = Enumerable.Range(0, 16 * 1024)
                                                       .Select(i => new string(' ', i))
                                                       .ToArray();

        public int Run()
        {
            var sum = 0;

            // begin
            unchecked
            {
                foreach (var item in _strings)
                    sum += item.Length;
            }
            // end

            return sum;
        }
    }
}
