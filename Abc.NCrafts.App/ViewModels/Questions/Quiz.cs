using System;
using System.Collections.Generic;

namespace Abc.NCrafts.App.ViewModels.Questions
{
    public class Quiz
    {
        public int CurrentQuestionIndex { get; private set; }
        public List<Question> Questions { get; } = new();
        public bool IsSuccess { get; private set; }

        public Question CurrentQuestion => CurrentQuestionIndex < Questions.Count ? Questions[CurrentQuestionIndex] : null;

        public void NavigateForward()
        {
            CurrentQuestionIndex = Math.Min(Questions.Count - 1, ++CurrentQuestionIndex);
        }

        public void NavigateBackward()
        {
            CurrentQuestionIndex = Math.Max(0, --CurrentQuestionIndex);
        }

        public bool MoveToNextQuestion()
        {
            var currentQuestion = Questions[CurrentQuestionIndex];
            if (!currentQuestion.IsSelectedAnswerValid())
                return false;

            CurrentQuestionIndex++;
            if (CurrentQuestionIndex < Questions.Count)
                return true;

            IsSuccess = true;
            return false;
        }
    }
}