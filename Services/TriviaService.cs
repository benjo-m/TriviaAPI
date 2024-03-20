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

    public List<QuestionResponse> GetQuestions()
    {
        var questionModelList = _context.Questions.Include(x => x.Category).Include(x => x.Difficulty).Include(x => x.Answers).ToList();
        var questions = new List<QuestionResponse>();

        foreach (var item in questionModelList)
        {
            questions.Add(new QuestionResponse(item));
        }

        return questions;
    }
}
