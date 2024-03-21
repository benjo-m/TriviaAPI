using TriviaAPI.Response;

namespace TriviaAPI.Services;

public interface ITriviaService
{
    public List<CategoryResponse> GetCategories();
    public List<DifficultyResponse> GetDifficulties();
    public List<QuestionResponse> GetQuestions(string? category, string? difficulty);
}
