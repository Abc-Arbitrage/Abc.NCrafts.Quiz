using System.Runtime.Intrinsics.X86;

namespace Abc.NCrafts.Quizz.Performance2018.Questions._007
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        private readonly ulong _value = 0xDEAD_BEEF;

        public int Run()
        {
            var value = _value;

            // begin
            if (Popcnt.IsSupported) // assume is true
                return (int)Popcnt.PopCount(value);

            int count;
            for (count = 0; value != 0; count++)
                value &= value - 1;

            return count;
            // end
        }
    }
}
