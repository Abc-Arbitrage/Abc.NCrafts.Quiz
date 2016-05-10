using System.Collections;

namespace Abc.NCrafts.Quizz.Performance.Questions._018
{
    public class Answer1
    {
        private static readonly ArrayList _values;

        static Answer1()
        {
            _values = new ArrayList(100 * 1000);
        }

        public static void Run()
        {
            _values.Clear();

            // begin
            for (var i = 0; i < _values.Capacity; i++)
            {
                _values.Add(i);
            }
            // end
        }
    }
}