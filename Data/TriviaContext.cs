using Microsoft.EntityFrameworkCore;
using TriviaAPI.Models;

namespace TriviaAPI.Data;

public class TriviaContext : DbContext
{
    public DbSet<Question> Questions { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Difficulty> Difficulties { get; set; }
    public DbSet<Answer> Answers { get; set; }

    public TriviaContext(DbContextOptions<TriviaContext> options)
    : base(options)
    {
    }
}
