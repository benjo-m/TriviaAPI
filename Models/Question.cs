using Microsoft.Extensions.Hosting;

namespace TriviaAPI.Models;

public class Question
{
    public int Id { get; set; }
    public required Category Category { get; set; }
    public required int CategoryId { get; set; }
    public required Difficulty Difficulty { get; set; }
    public required int DifficultyId { get; set; }
    public required string Text { get; set; }
    public required string CorrectAnswer { get; set; }
    public ICollection<Answer> Answers { get; } = new List<Answer>();
}
