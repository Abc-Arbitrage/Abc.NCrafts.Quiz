namespace Abc.NCrafts.Quizz.Performance2018.Questions._007
{
    public class Answer2
    {
        private readonly ulong _value = 0xDEAD_BEEF;

        public int Run()
        {
            var value = _value;

            // begin
            value -= (value >> 1) & 0x5555555555555555;
            value = (value & 0x3333333333333333) + ((value >> 2) & 0x3333333333333333);
            value = (value + (value >> 4)) & 0x0f0f0f0f0f0f0f0f;
            return (int)((value * 0x0101010101010101) >> 56);
            // end
        }
    }
}
