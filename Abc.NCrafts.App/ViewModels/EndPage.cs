using System;
using System.Configuration;
using System.IO;

namespace Abc.NCrafts.App.ViewModels
{
    public class EndPage : ViewModel
    {
        private static readonly string DefaultMailText = "you@email.com";

        public EndPage(MainViewModel mainViewModel) : base(mainViewModel)
        {
        }

        public int AnsweredQuestionCount => MainViewModel.Quiz.CurrentQuestionIndex;

        public int Score => MainViewModel.Quiz.CurrentScore;

        public bool CanContinue => MainViewModel.Quiz.CurrentQuestion != null;

        public string Emails { get; set; } = DefaultMailText;

        public override void GoToNext()
        {
            if(!string.IsNullOrWhiteSpace(Emails))
                File.AppendAllText(Path.Combine(ConfigurationManager.AppSettings["PlayerNamePath"], "players.txt"), Emails + Environment.NewLine);

             Emails = DefaultMailText;

            base.GoToNext();
        }
    }
}