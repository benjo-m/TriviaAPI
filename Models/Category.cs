namespace TriviaAPI.Models;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ICollection<Question> Questions { get; } = new List<Question>();
}