using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._011
{
    public class Answer2
    {
        private static readonly Container[] _containers;

        static Answer2()
        {
            _containers = Enumerable.Range(0, 500)
                                    .Select(x => new Container(x))
                                    .ToArray();
        }

        public static void Run()
        {
            var sum = 0;
            // begin
            foreach (var container in _containers)
            {
                sum += container.Entry.Entry.Entry.Value;
            }
            // end
            Logger.Log("Sum: {0}", sum);
        }

        private struct Container
        {
            public Entry1 Entry;

            public Container(int value)
            {
                Entry.Entry.Entry.Value = value;
            }
        }

        private struct Entry1
        {
            public Entry2 Entry;
        }

        private struct Entry2
        {
            public Entry3 Entry;
        }

        private struct Entry3
        {
            public int Value;
        }
    }
}
