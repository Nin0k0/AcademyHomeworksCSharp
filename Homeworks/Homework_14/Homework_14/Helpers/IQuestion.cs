

namespace Homework_14.Helpers
{
    public interface IQuestion
    {
        List<Question> GetQuestions();
        void AddQuestion(Question question);
    }
}
