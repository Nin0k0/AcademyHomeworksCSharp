using System.Reflection.PortableExecutable;

namespace Homework_14
{
    public class QuizManage
    {
        private readonly QuestionsFile _questionsFile;
        private readonly ResultsFile _resultsFile;

        public QuizManage(QuestionsFile questionsFile, ResultsFile resultsFile)
        {
            this._questionsFile = questionsFile;
            this._resultsFile = resultsFile;
        }

        public static void DisplayMainMenu()
        {
            
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Run Quiz");
            Console.WriteLine("2. Add a Question");
            Console.WriteLine("3. Exit");
        }

        public  static MainMenuChoice GetMainMenuChoice()
        {
            while (true)
            {
                Console.Write("Enter your choice: ");
                var input = Console.ReadLine();
                if (Enum.TryParse(input, true, out MainMenuChoice choice))
                {
                    return choice;
                }

                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        public void RunQuiz()
        {
            var quiz = new Quiz(_questionsFile, _resultsFile);
            quiz.Start();
        }

       

        private static Question? GetQuestionFromUser()
        {
            Console.WriteLine("Enter the question:");
            var questionText = Console.ReadLine();
            Console.WriteLine("Enter score of question: ");
            double score;
            while (true)
            {
                Console.Write("Enter the score for this question: ");
                if (double.TryParse(Console.ReadLine(), out double outScore))
                {
                    score = outScore;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid score. Please enter a valid numeric value.");
                }
            }
            
            Console.WriteLine("Enter the correct answer:");
            var correctAnswer = Console.ReadLine();

            var incorrectAnswers = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter an incorrect answer (leave blank to finish):");
                var answer = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(answer))
                {
                    break;
                }

                incorrectAnswers.Add(answer);
            }

            try
            {
                return new Question(questionText!, correctAnswer!, incorrectAnswers, score);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Question  was invalid to add!");
                return null;
            }

            
        }
        public void AddQuestions()
        {
            Console.WriteLine("Do you want to clear previous questions? Y/N");

            var yesNo = Console.ReadKey().KeyChar;
            if (yesNo =='Y' || yesNo == 'y')
            {
                Console.WriteLine();
                File.Delete(_questionsFile.FileName);
                

                AskQuestionsToWrite();
            }
            else
            {
                AskQuestionsToWrite();
            }

            
        }

        private void AskQuestionsToWrite()
        {
            while (true)
            {
                var question = GetQuestionFromUser() ?? GetQuestionFromUser();

                if (question != null) _questionsFile.AddQuestion(question);

                Console.WriteLine("Question added successfully!");

                Console.WriteLine("Do you want to add more questions? (Y/N)");
                var input = Console.ReadLine();

                if (!string.Equals(input, "Y", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }

       
        }
    
public enum MainMenuChoice
    {
        None,
        WriteQuiz,
        AddQuestions,
        Exit
    }
}
