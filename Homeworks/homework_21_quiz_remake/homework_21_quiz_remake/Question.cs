


    using homework_21_quiz_remake.Helpers;

    namespace homework_21_quiz_remake; 

    public class Question
    {
        public string QuestionText { get; }
        public string CorrectAnswer { get; }
        public List<string> IncorrectAnswers { get; }

        public bool IsCorrect { get; private set; }
        public double Score { get; }

        public Question(string questionText, string correctAnswer, IEnumerable<string> incorrectAnswers, double score = 1)
        {

            if (string.IsNullOrEmpty(questionText))
                throw new ArgumentException("Question text cannot be empty or null.", nameof(questionText));

            if (string.IsNullOrEmpty(correctAnswer))
                throw new ArgumentException("Correct answer cannot be empty or null.", nameof(correctAnswer));

            if (incorrectAnswers == null || !incorrectAnswers.Any())
                throw new ArgumentException("Incorrect answers cannot be empty or null.", nameof(incorrectAnswers));

            QuestionText = questionText;
            CorrectAnswer = correctAnswer.Trim();
            IncorrectAnswers = new List<string>(incorrectAnswers);
            IncorrectAnswers.Shuffle();
            IsCorrect = false;
            Score = score;
        }

        public void Ask()
        {
            Console.WriteLine(QuestionText);

            var firstAccessor = 'A';
            var allAnswers = new List<string>(IncorrectAnswers) { CorrectAnswer };
            allAnswers.Shuffle();

            foreach (var item in allAnswers)
            {
                Console.WriteLine($"{firstAccessor++}. {item}");
            }

            var answer = GetAnswerFromUser(allAnswers);

            var selectedAnswer = allAnswers[answer - 'A'];
            Console.WriteLine();
            if (string.Equals(selectedAnswer, CorrectAnswer, StringComparison.OrdinalIgnoreCase))
            {
                IsCorrect = true;
                Console.WriteLine("Your answer is correct!");
            }
            else
            {
                IsCorrect = false;

                Console.WriteLine($"Your answer is incorrect. The correct answer is: {CorrectAnswer}");
            }


        }

        private static char GetAnswerFromUser(List<string> answers)
        {
            while (true)
            {
                Console.Write("Your answer: ");
                var input = Console.ReadKey().KeyChar.ToString().ToUpper();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a valid answer.");
                    continue;
                }

                var answer = input[0];
                if (answer >= 'A' && answer < 'A' + answers.Count)
                {
                    return answer;
                }
                Console.WriteLine();
                Console.WriteLine("Invalid answer. Please try again.");

            }
        }
    }