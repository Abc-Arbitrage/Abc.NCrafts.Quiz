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
            var rules = new RulesPage(this);
            var game = new GamePage(this);
            var end = new EndPage(this);

            welcome.NextPage = rules;
            rules.PreviousPage = welcome;
            rules.NextPage = game;
            game.NextPage = end;
            end.NextPage = welcome;

            CurrentPage = welcome;
        }

        public int HighScore { get; set; }
        public Quiz Quiz { get; set; }
        public ViewModel CurrentPage { get; set; }

        public void StartGame()
        {
            HighScore = LoadHighScore();
            Quiz = LoadQuiz();
        }

        public void UpdateHighScore()
        {
            if (Quiz.CurrentScore <= HighScore)
                return;

            HighScore = Quiz.CurrentScore;
            SaveHighScore(HighScore);
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

        private static int LoadHighScore()
        {
            var filePath = GetHighScoreFilePath();
            if (!File.Exists(filePath))
                return 0;
            return int.Parse(File.ReadAllText(filePath));
        }

        private static void SaveHighScore(int value)
        {
            var filePath = GetHighScoreFilePath();
            File.WriteAllText(filePath, value.ToString());
        }

        private static string GetHighScoreFilePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HighScore.txt");
        }
    }
}