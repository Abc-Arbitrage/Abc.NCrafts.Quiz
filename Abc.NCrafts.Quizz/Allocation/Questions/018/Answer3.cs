﻿using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Questions._018
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer3
    {
        public static void Run()
        {
            GetEmptySequence<int>();

            // begin
            GetEmptySequence<int>();
            // end
        }

        private static IEnumerable<T> GetEmptySequence<T>()
        {
            return Enumerable.Empty<T>();
        }
    }
}
