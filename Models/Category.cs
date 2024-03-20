using System.Text.Json.Serialization;

namespace TriviaAPI.Models;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    [JsonIgnore]
    public ICollection<Question> Questions { get; } = new List<Question>();
}