using Microsoft.AspNetCore.Mvc;
using TriviaAPI.Response;
using TriviaAPI.Services;

namespace TriviaAPI.Controllers;

[Route("api/trivia")]
[ApiController]
public class TriviaController : ControllerBase
{
    private ITriviaService _triviaService;

    public TriviaController(ITriviaService service)
    {
        _triviaService = service;
    }

    [HttpGet]
    [Route("category")]
    public List<CategoryResponse> GetCategories()
    {
        return _triviaService.GetCategories();
    }

    [HttpGet]
    [Route("difficulty")]
    public List<DifficultyResponse> GetDifficulties() 
    {
        return _triviaService.GetDifficulties();
    }

    [HttpGet]
    [Route("question")]
    public List<QuestionResponse> GetQuestions(string? category, string? difficulty)
    {
        return _triviaService.GetQuestions(category, difficulty);
    }
}
