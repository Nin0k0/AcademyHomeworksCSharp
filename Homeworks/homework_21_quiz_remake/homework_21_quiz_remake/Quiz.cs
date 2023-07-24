using homework_21_quiz_remake.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_21_quiz_remake
{
    public class Quiz
    {
        private readonly IQuestion _questionFile;
        private readonly IScore _scoreFile;

        public Quiz(IQuestion questionFile, IScore scoreFile)
        {
            this._questionFile = questionFile;
            this._scoreFile = scoreFile;
        }

        public void Start()
        {
            var questions = _questionFile.GetQuestionsAsync();
            double score = 0;

            foreach (var question in questions.Result)
            {
                question.Ask();
                if (question.IsCorrect)
                {
                    score += question.Score;
                }
            }

            Console.WriteLine($"Your Final score: {score}");
            _scoreFile.AddScoreAsync(score);
        }
    }
}
