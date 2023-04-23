using System;

namespace Abc.NCrafts.Quiz.Performance2.Level1.Q000
{
    [CorrectAnswer]
    public class Answer2
    {
        public readonly SomeGuids Guids = new SomeGuids(Guid.NewGuid(), 
                                                        Guid.NewGuid(), 
                                                        Guid.NewGuid(), 
                                                        Guid.NewGuid());

        public Guid Run()
        {
            // begin
            return Guids.GetC();
            // end
        }

        public readonly struct SomeGuids
        {
            public readonly Guid A;
            public readonly Guid B;
            public readonly Guid C;
            public readonly Guid D;

            public SomeGuids(Guid a, Guid b, Guid c, Guid d)
                => (A, B, C, D) = (a, b, c, d);

            public Guid GetC() => C;
        }
    }
}
