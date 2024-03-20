using TriviaAPI.Models;

namespace TriviaAPI.Response;

public class DifficultyResponse
{
    public int Id { get; set; }
    public string Level { get; set; }

    public DifficultyResponse(Difficulty difficulty)
    {
        Id = difficulty.Id;
        Level = difficulty.Level;
    }
}
