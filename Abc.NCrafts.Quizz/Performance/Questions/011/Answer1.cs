using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._011
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        private static readonly Container[] _containers;

        static Answer1()
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
                sum += container.Entry.Value;
            }
            // end
            Logger.Log("Sum: {0}", sum);
        }

        private struct Container
        {
            public readonly Entry Entry;

            public Container(int value)
            {
                Entry = new Entry { Value = value };
            }
        }

        private class Entry
        {
            public int Value;
        }
    }
}
