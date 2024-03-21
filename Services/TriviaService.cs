using Microsoft.EntityFrameworkCore;
using TriviaAPI.Data;
using TriviaAPI.Response;

namespace TriviaAPI.Services;

public class TriviaService : ITriviaService
{
    private TriviaContext _context;

    public TriviaService(TriviaContext context)
    {
        _context = context;
    }

    public List<CategoryResponse> GetCategories()
    {
        var categoryModelList = _context.Categories.ToList();
        var categories = new List<CategoryResponse>();

        foreach (var item in categoryModelList)
        {
            categories.Add(new CategoryResponse(item));
        }

        return categories;
    }

    public List<DifficultyResponse> GetDifficulties()
    {
        var difficultyModelList = _context.Difficulties.ToList();
        var difficulties = new List<DifficultyResponse>();

        foreach (var item in difficultyModelList)
        {
            difficulties.Add(new DifficultyResponse(item));
        }

        return difficulties;
    }

    public List<QuestionResponse> GetQuestions(string? category, string? difficulty)
    {
        var query = _context.Questions
            .Include(x => x.Category)
            .Include(x => x.Difficulty)
            .Include(x => x.Answers)
            .AsQueryable();

        var questions = new List<QuestionResponse>();

        if (category != null)
        {
            query = query.Where(x => x.Category.Name == category);
        }

        if (difficulty != null)
        {
            query = query.Where(x => x.Difficulty.Level == difficulty);
        }

        foreach (var item in query.ToList())
        {
            questions.Add(new QuestionResponse(item));
        }

        return questions;
    }
}
