using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Abc.NCrafts.App.ViewModels.Questions
{
    public static class QuizLoader
    {
        public static Quiz LoadFrom(string quizDirectoryPath)
        {
            var quiz = new Quiz();
            var questionsByDifficulty = new SortedDictionary<int, List<Question>>();
            foreach (var questionDirectoryPath in Directory.GetDirectories(quizDirectoryPath))
            {
                var question = LoadQuestion(questionDirectoryPath);
                if (!questionsByDifficulty.TryGetValue((int)question.Difficulty, out var questions))
                {
                    questions = new List<Question>();

                    questionsByDifficulty.Add((int)question.Difficulty, questions);
                }
                questions.Add(question);
            }
            foreach (var questions in questionsByDifficulty.Values)
            {
                quiz.Questions.AddRange(questions);
            }
            return quiz;
        }

        private static Question LoadQuestion(string questionDirectoryPath)
        {
            var question = new Question();
            foreach (var answerFilePath in Directory.GetFiles(questionDirectoryPath, "Answer*.cs"))
            {
                var answerLines = File.ReadLines(answerFilePath).ToList();
                var answer = new Answer();

                var nonCodeAnswer = answerLines.FirstOrDefault(x => x.Contains("[NonCodeAnswer"));
                answer.HasCode = nonCodeAnswer == null;

                var correctAnswerLine = answerLines.FirstOrDefault(x => x.Contains("[CorrectAnswer"));
                if (correctAnswerLine != null)
                {
                    answer.IsCorrect = true;
                    question.Difficulty = ParseDifficulty(correctAnswerLine);
                }

                TrimToClass(answerLines);
                LoadHighlightedSectionIndexes(answerLines, answer);

                answer.Text = string.Join(Environment.NewLine, answerLines);

                question.Answers.Add(answer);
            }
            question.ShuffleAnswers();

            question.MarkdownHelpContent = LoadHelpContent(questionDirectoryPath);
            return question;
        }

        private static string LoadHelpContent(string questionDirectoryPath)
        {
            var helpContentFilePath = Path.Combine(questionDirectoryPath, "Answer.md");
            if (!File.Exists(helpContentFilePath))
                return "No help available yet.";

            return File.ReadAllText(helpContentFilePath);
        }

        private static void TrimToClass(List<string> answerLines)
        {
            var classDeclarationIndex = answerLines.FindIndex(x => x.Contains("public class Answer"));
            answerLines.RemoveRange(0, classDeclarationIndex + 2);

            var namespaceEndBracketIndex = answerLines.FindLastIndex(x => x.Contains("}"));
            var classEndBracketIndex = answerLines.FindLastIndex(namespaceEndBracketIndex - 1, x => x.Contains("}"));
            answerLines.RemoveRange(classEndBracketIndex, answerLines.Count - classEndBracketIndex);

            for (var lineIndex = 0; lineIndex < answerLines.Count; lineIndex++)
            {
                if (answerLines[lineIndex].Length >= 8)
                    answerLines[lineIndex] = answerLines[lineIndex].Substring(8);

                answerLines[lineIndex] = answerLines[lineIndex].Replace("Answer1", "Answer").Replace("Answer2", "Answer").Replace("Answer3", "Answer");
            }
        }

        private static void LoadHighlightedSectionIndexes(List<string> answerLines, Answer answer)
        {
            answer.HighlightedSectionBeginIndex = answerLines.FindIndex(x => x.Contains("// begin"));
            answerLines.RemoveAt(answer.HighlightedSectionBeginIndex);

            answer.HighlightedSectionEndIndex = answerLines.FindIndex(x => x.Contains("// end")) - 1;
            answerLines.RemoveAt(answer.HighlightedSectionEndIndex + 1);
        }

        private static QuestionDifficulty ParseDifficulty(string s)
        {
            // lol
            if(s.Contains(QuestionDifficulty.Easy.ToString()))
                return QuestionDifficulty.Easy;

            if(s.Contains(QuestionDifficulty.Medium.ToString()))
                return QuestionDifficulty.Medium;

            if(s.Contains(QuestionDifficulty.Hard.ToString()))
                return QuestionDifficulty.Hard;

            return QuestionDifficulty.Undefined;
        }
    }
}