using Homework_14.Helpers;

namespace Homework_14;

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
        var questions = _questionFile.GetQuestions();
        double score = 0;

        foreach (var question in questions)
        {
            question.Ask();
            if (question.IsCorrect)
            {
                score+= question.Score;
            }
        }

        Console.WriteLine($"Your Final score: {score}");
        _scoreFile.AddScore(score);
    }
}