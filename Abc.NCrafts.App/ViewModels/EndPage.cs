using System;
using System.IO;

namespace Abc.NCrafts.App.ViewModels
{
    public class EndPage : ViewModel
    {
        public EndPage(MainViewModel mainViewModel) : base(mainViewModel)
        {
        }

        public int AnsweredQuestionCount => MainViewModel.Quiz.CurrentQuestionIndex;

        public int Score => MainViewModel.Quiz.CurrentScore;

        public bool CanContinue => MainViewModel.Quiz.CurrentQuestion != null;

        public string Emails { get; set; } = "you@email.com";

        public override void GoToNext()
        {
            if(!string.IsNullOrWhiteSpace(Emails))
                File.AppendAllText("players.txt", Emails + Environment.NewLine);

            base.GoToNext();
        }
    }
}