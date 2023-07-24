



namespace  homework_21_quiz_remake.Helpers
{
    public interface IQuestion
    {
        Task<List<Question>> GetQuestionsAsync();
        Task AddQuestionAsync(Question question);
    }
}
