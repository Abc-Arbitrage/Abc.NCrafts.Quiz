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

            foreach (var level in Enum.GetValues<QuestionLevel>())
            {
                var levelDirectoryPath = Path.Combine(quizDirectoryPath, level.ToString());
                foreach (var questionDirectoryPath in Directory.GetDirectories(levelDirectoryPath))
                {
                    var question = LoadQuestion(level, questionDirectoryPath);
                    quiz.Questions.Add(question);
                }
            }
            
            return quiz;
        }

        private static Question LoadQuestion(QuestionLevel level, string questionDirectoryPath)
        {
            var question = new Question { Level = level };
            
            foreach (var answerFilePath in Directory.GetFiles(questionDirectoryPath, "Answer*.cs"))
            {
                var answerLines = File.ReadLines(answerFilePath).ToList();
                var answer = new Answer();

                var nonCodeAnswer = answerLines.FirstOrDefault(x => x.Contains("[NonCodeAnswer"));
                answer.HasCode = nonCodeAnswer == null;

                var correctAnswerLine = answerLines.FirstOrDefault(x => x.Contains("[CorrectAnswer"));
                if (correctAnswerLine != null)
                    answer.IsCorrect = true;

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
    }
}