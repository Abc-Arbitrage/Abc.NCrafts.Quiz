using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Abc.NCrafts.Quizz.Allocation.Questions.Q027
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer1
    {
        private static List<Key> _keys 
            = new List<Key> { new Key() };

        public static void Run()
        {
            // begin
            for (var index = 0; index < _keys.Count; index++)
            {
                var key = _keys[index];
                key.Value++;
            }
            var result = _keys[0].Value == 0
                ? _keys[0].Value.GetHashCode()
                : _keys[0].GetHashCode();
            // end

            Logger.Log("Result: {0}", result);
        }

        private struct Key
        {
            public int Value;

            public override int GetHashCode()
            {
                return RuntimeHelpers.GetHashCode(this);
            }
        }
    }
}