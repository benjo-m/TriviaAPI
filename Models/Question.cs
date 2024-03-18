namespace TriviaAPI.Models;

public class Question
{
    public int Id { get; set; }
    public required Category Category { get; set; }
    public required Difficulty Difficulty { get; set; }
    public required string Text { get; set; }
    public required string CorrectAnswer { get; set; }
}
