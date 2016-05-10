using System.Collections;

namespace Abc.NCrafts.Quizz.Performance.Questions._018
{
    public class Answer1
    {
        private static readonly ArrayList _values;
        private const int _itemCount = 100 * 1000;

        static Answer1()
        {
            _values = new ArrayList(_itemCount);
        }

        public static void Run()
        {
            _values.Clear();

            // begin
            for (var i = 0; i < _itemCount; i++)
            {
                _values.Add(i);
            }
            // end
        }
    }
}
