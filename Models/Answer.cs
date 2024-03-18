namespace TriviaAPI.Models;

public class Answer
{
    public int Id { get; set; }
    public required int QuestionId { get; set; }
    public required string Text { get; set; }
}
