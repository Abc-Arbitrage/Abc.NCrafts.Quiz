using System;
using System.Configuration;
using System.IO;
using Abc.NCrafts.App.ViewModels;
using Abc.NCrafts.App.ViewModels.Questions;
using PropertyChanged;

namespace Abc.NCrafts.App
{
    [ImplementPropertyChanged]
    public class MainViewModel
    {
        public MainViewModel()
        {
            // useless LoadQuiz to make sure we fail fast if the question files are invalid
            LoadQuiz();

            var welcome = new WelcomePage(this);
            var game = new GamePage(this);
            var end = new EndPage(this);

            welcome.NextPage = game;
            game.NextPage = end;
            end.NextPage = welcome;

            CurrentPage = welcome;
        }

        public Quiz Quiz { get; private set; }
        public ViewModel CurrentPage { get; set; }

        public void StartGame()
        {
            Quiz = LoadQuiz();
        }
        
        private static Quiz LoadQuiz()
        {
            return QuizLoader.LoadFrom(GetQuizPath());
        }

        private static string GetQuizPath()
        {
            var quizPath = ConfigurationManager.AppSettings["Quiz.Path"];
            return string.IsNullOrEmpty(quizPath) ? FindQuizPath() : quizPath;
        }

        private static string FindQuizPath()
        {
            var baseDirectory = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            while (baseDirectory != null)
            {
                var parentDirectory = Path.GetDirectoryName(baseDirectory);
                if (Path.GetFileName(baseDirectory) == "Abc.NCrafts.App" && parentDirectory != null)
                    return Path.Combine(parentDirectory, "Abc.NCrafts.Quizz", "Performance", "Questions");

                baseDirectory = parentDirectory;
            }
            return AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}