using Microsoft.EntityFrameworkCore;

namespace FutPool.Models
{
    public class FutPoolContext : DbContext
    {
        public FutPoolContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<League> Leagues { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }
    }
}
