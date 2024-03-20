using System.Text.Json.Serialization;

namespace TriviaAPI.Models;

public class Answer
{
    public int Id { get; set; }
    public required int QuestionId { get; set; }
    [JsonIgnore]
    public Question Question { get; set; } = null!;
    public required string Text { get; set; }
}
