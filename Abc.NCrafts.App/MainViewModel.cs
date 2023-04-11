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
        private readonly PerformanceGamePage _performanceGamePage;
        private readonly Performance2018GamePage _performance2018GamePage;
        private readonly EndPage _endPage;

        public MainViewModel()
        {
            EnsureQuizCanBeLoaded();

            _welcomePage = new WelcomePage(this);
            _allocationGamePage = new AllocationGamePage(this);
            _performanceGamePage = new PerformanceGamePage(this);
            _performance2018GamePage = new Performance2018GamePage(this);
            _endPage = new EndPage(this);

            _allocationGamePage.NextPage = _endPage;
            _performanceGamePage.NextPage = _endPage;
            _performance2018GamePage.NextPage = _endPage;

            _endPage.NextPage = _welcomePage;

            CurrentPage = _welcomePage;
        }

        public Quiz Quiz { get; private set; }
        public ViewModel CurrentPage { get; set; }

        public void StartGame(QuizzType quizzType)
        {
            Quiz = LoadQuiz(quizzType);

            switch (quizzType)
            {
                case QuizzType.Performance:
                    _welcomePage.NextPage = _performanceGamePage;
                    _endPage.PreviousPage = _performanceGamePage;
                    break;
                case QuizzType.Allocation:
                    _welcomePage.NextPage = _allocationGamePage;
                    _endPage.PreviousPage = _allocationGamePage;
                    break;
                case QuizzType.Performance2018:
                    _welcomePage.NextPage = _performance2018GamePage;
                    _endPage.PreviousPage = _performance2018GamePage;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(quizzType), quizzType, null);
            }
        }

        private static void EnsureQuizCanBeLoaded()
        {
            LoadQuiz(QuizzType.Allocation);
            LoadQuiz(QuizzType.Performance);
            LoadQuiz(QuizzType.Performance2018);
        }

        private static Quiz LoadQuiz(QuizzType quizzType) => QuizLoader.LoadFrom(GetQuizPath(quizzType));

        private static string GetQuizPath(QuizzType quizzType)
        {
            var quizPathRoot = GetQuizPathRoot();
            if (string.IsNullOrEmpty(quizPathRoot))
                throw new InvalidOperationException("Unable to locate quiz path, you should set \"Quiz.Path\" setting key.");

            return Path.Combine(quizPathRoot, quizzType.ToString(), "Questions");
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
