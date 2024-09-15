using Microsoft.EntityFrameworkCore;
using TheCase.Data.Entities;

namespace TheCase.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Player> Players { get; set; }

    public DbSet<Suspicious> Suspiciouses { get; set; }

    public DbSet<Advisor> Advisors { get; set; }

    public DbSet<Level> Levels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource = TheCaseDatabase.db");
    }
}