using Homework_14.Helpers;

namespace Homework_14
{
    public class QuestionsFile : IQuestion
    {
        private const char Separator = ';';
        public string FileName;


        public QuestionsFile(string fileName)
        {
            this.FileName = fileName;
        }

        public List<Question> GetQuestions()
        {
            if (!File.Exists(FileName))
            {
                return new List<Question>();
            }

            var lines = File.ReadAllLines(FileName);
            var questions = new List<Question>();

            foreach (var line in lines)
            {
                var parts = line.Split(Separator);
                if (parts.Length < 2) continue;
                var question = new Question( parts[1],parts[2], parts.Skip(3),double.Parse(parts[0]));
                questions.Add(question);
            }

            return questions;
        }

        public void AddQuestion(Question question)
        {
            var line = $"{question.Score}{Separator}{question.QuestionText}{Separator}{question.CorrectAnswer}{Separator}{string.Join(Separator, question.IncorrectAnswers)}";
            File.AppendAllLines(FileName, new[] { line });
        }
    }
}
