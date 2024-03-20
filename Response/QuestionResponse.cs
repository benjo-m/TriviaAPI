using TriviaAPI.Models;

namespace TriviaAPI.Response;

public class QuestionResponse
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string Category { get; set; }
    public string Difficulty { get; set; }
    public string CorrectAnswer { get; set; }
    public List<string> IncorrectAnswers { get; set; } = new List<string>();

    public QuestionResponse(Question question)
    {
        Id = question.Id;
        Text = question.Text;
        Category = question.Category.Name;
        Difficulty = question.Difficulty.Level;
        CorrectAnswer = question.CorrectAnswer;
        foreach (var item in question.Answers)
        {
            IncorrectAnswers.Add(item.Text);
        }
    }
}


