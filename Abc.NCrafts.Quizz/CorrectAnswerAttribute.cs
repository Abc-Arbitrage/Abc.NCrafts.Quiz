using System;

namespace Abc.NCrafts.Quizz
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CorrectAnswerAttribute : Attribute
    {
        public Difficulty Difficulty { get; set; }
    }
}