using System;
using System.Collections.Generic;
using MarkdownSharp;

namespace Abc.NCrafts.App.ViewModels.Questions
{
    public class Question
    {
        private static readonly Random _random = new Random();
        private static readonly Dictionary<int, int> _scoresByDifficulty = new Dictionary<int, int> { { 1, 50 }, { 2, 100 }, { 3, 200 } };
        private readonly Markdown _markdown = new Markdown();
        private string _htmlHelpContent;

        public List<Answer> Answers { get; }= new List<Answer>();
        public int Difficulty { get; set; }
        public Answer SelectedAnswer { get; set; }

        public Answer Answer1 => Answers[0];
        public Answer Answer2 => Answers[1];
        public Answer Answer3 => Answers.Count >= 3 ? Answers[2] : new Answer();

        public int Score => _scoresByDifficulty[Difficulty];

        public string MarkdownHelpContent { get; set; }

        public string HtmlHelpContent => _htmlHelpContent ?? (_htmlHelpContent = CreateHtmlHelpContent());

        private string CreateHtmlHelpContent()
        {
            var content = _markdown.Transform(MarkdownHelpContent);
            var css = "code { color: #222; background-color: #EEE; font-family: Consolas; padding: 1 5 1 5; } body { font-family: Helvetica; font-size: 15; line-height: 19.5px; }";
            return $@"<html><style type='text/css'>{css}</style><body>{content}</body></html>";
        }

        public void ShuffleAnswers()
        {
            for (var index = 0; index < Answers.Count - 1; index++)
            {
                var randomIndex = _random.Next(index, Answers.Count);
                var tmp = Answers[index];
                Answers[index] = Answers[randomIndex];
                Answers[randomIndex] = tmp;
            }
        }
    }
}