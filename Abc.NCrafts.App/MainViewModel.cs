using System;
using System.Configuration;
using System.IO;
using Abc.NCrafts.App.ViewModels;
using Abc.NCrafts.App.ViewModels.Questions;
using PropertyChanged;

namespace Abc.NCrafts.App
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel
    {
        private readonly WelcomePage _welcomePage;
        private readonly AllocationGamePage _allocationGamePage;
        private readonly Performance1GamePage _performance1GamePage;
        private readonly Performance2GamePage _performance2GamePage;
        private readonly EndPage _endPage;

        public MainViewModel()
        {
            EnsureQuizCanBeLoaded();

            _welcomePage = new WelcomePage(this);
            _allocationGamePage = new AllocationGamePage(this);
            _performance1GamePage = new Performance1GamePage(this);
            _performance2GamePage = new Performance2GamePage(this);
            _endPage = new EndPage(this);

            _allocationGamePage.NextPage = _endPage;
            _performance1GamePage.NextPage = _endPage;
            _performance2GamePage.NextPage = _endPage;

            _endPage.NextPage = _welcomePage;

            CurrentPage = _welcomePage;
        }

        public Quiz Quiz { get; private set; }
        public ViewModel CurrentPage { get; set; }

        public void StartGame(QuizType quizType)
        {
            Quiz = LoadQuiz(quizType);

            switch (quizType)
            {
                case QuizType.Performance1:
                    _welcomePage.NextPage = _performance1GamePage;
                    _endPage.PreviousPage = _performance1GamePage;
                    break;
                case QuizType.Allocation:
                    _welcomePage.NextPage = _allocationGamePage;
                    _endPage.PreviousPage = _allocationGamePage;
                    break;
                case QuizType.Performance2:
                    _welcomePage.NextPage = _performance2GamePage;
                    _endPage.PreviousPage = _performance2GamePage;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(quizType), quizType, null);
            }
        }

        private static void EnsureQuizCanBeLoaded()
        {
            LoadQuiz(QuizType.Allocation);
            LoadQuiz(QuizType.Performance1);
            LoadQuiz(QuizType.Performance2);
        }

        private static Quiz LoadQuiz(QuizType quizType) => QuizLoader.LoadFrom(GetQuizPath(quizType));

        private static string GetQuizPath(QuizType quizType)
        {
            var quizPathRoot = GetQuizPathRoot();
            if (string.IsNullOrEmpty(quizPathRoot))
                throw new InvalidOperationException("Unable to locate quiz path, you should set \"Quiz.Path\" setting key.");

            return Path.Combine(quizPathRoot, quizType.ToString());
        }

        private static string GetQuizPathRoot()
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
                    return Path.Combine(parentDirectory, "Abc.NCrafts.Quiz");

                baseDirectory = parentDirectory;
            }

            return AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
