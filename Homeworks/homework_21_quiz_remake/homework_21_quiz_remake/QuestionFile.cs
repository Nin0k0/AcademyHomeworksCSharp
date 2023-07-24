using homework_21_quiz_remake.Helpers;
namespace homework_21_quiz_remake
{



    public class QuestionsFile : IQuestion
        {
            private const char Separator = ';';
            public string FileName;

            public QuestionsFile(string fileName)
            {
                this.FileName = fileName;
            }

            public async Task<List<Question>> GetQuestionsAsync()
            {
                if (!File.Exists(FileName))
                {
                    return new List<Question>();
                }

                var lines = await File.ReadAllLinesAsync(FileName);
                var questions = new List<Question>();

                foreach (var line in lines)
                {
                    var parts = line.Split(Separator);
                    if (parts.Length < 2) continue;
                    var question = new Question(parts[1], parts[2], parts.Skip(3), double.Parse(parts[0]));
                    questions.Add(question);
                }

                return questions;
            }

            public async Task AddQuestionAsync(Question question)
            {
                var line = $"{question.Score}{Separator}{question.QuestionText}{Separator}{question.CorrectAnswer}{Separator}{string.Join(Separator, question.IncorrectAnswers)}";
                await File.AppendAllLinesAsync(FileName, new[] { line });
            }
        }
    

}
