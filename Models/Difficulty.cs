using System.Text.Json.Serialization;

namespace TriviaAPI.Models;

public class Difficulty
{
    public int Id { get; set; }
    public required string Level { get; set; }
    [JsonIgnore]
    public ICollection<Question> Questions { get; } = new List<Question>();

}