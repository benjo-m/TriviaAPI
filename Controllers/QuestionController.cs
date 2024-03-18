using Microsoft.AspNetCore.Mvc;
using TriviaAPI.Data;
using TriviaAPI.Models;

namespace TriviaAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuestionController : ControllerBase
{
    private TriviaContext _context;

    public QuestionController(TriviaContext context)
    {
        _context = context;
    }

    [HttpGet]
    public List<Question> GetQuestions()
    {
        return _context.Questions.ToList();
    }
}
