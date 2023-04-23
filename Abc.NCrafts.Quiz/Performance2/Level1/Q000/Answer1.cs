using System;

namespace Abc.NCrafts.Quiz.Performance2.Level1.Q000
{
    public class Answer1
    {
        public readonly Data Value = new();

        public Guid Run()
        {
            // begin
            return Value.GetC();
            // end
        }

        public struct Data
        {
            public readonly Guid A, B, C, D;

            public Guid GetC() => C;
        }
    }
}
