using homework_21_quiz_remake;

const string QuestionsFileName = "questions.txt";
const string ScoresFileName = "scores.txt";
QuizManage quizManage;
var questionRepository = new QuestionsFile(QuestionsFileName);
var scoreRepository = new ResultsFile(ScoresFileName);

quizManage = new QuizManage(questionRepository, scoreRepository);

while (true)
{
    QuizManage.DisplayMainMenu();
    var choice = QuizManage.GetMainMenuChoice();

    switch (choice)
    {
        case MainMenuChoice.WriteQuiz:
            quizManage.RunQuiz();
            break;
        case MainMenuChoice.AddQuestions:
            quizManage.AddQuestions();
            break;
        case MainMenuChoice.Exit:
            return;
    }
}