namespace Abc.NCrafts.Quizz.Performance2018.Questions.Q007
{
    public class Answer2
    {
        private readonly ulong _value = 0xDEAD_BEEF;

        public int Run()
        {
            var value = _value;

            // begin
            value -= (value >> 1) & 0x5555555555555555UL;
            value = (value & 0x3333333333333333UL) + ((value >> 2) & 0x3333333333333333UL);
            value = (value + (value >> 4)) & 0x0F0F0F0F0F0F0F0FUL;
            return (int)((value * 0x0101010101010101UL) >> 56);
            // end
        }
    }
}
