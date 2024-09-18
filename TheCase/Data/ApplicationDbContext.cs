using Microsoft.EntityFrameworkCore;
using TheCase.Data.Entities;

namespace TheCase.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Level> Levels { get; set; }
    }
}