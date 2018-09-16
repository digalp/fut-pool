using Microsoft.EntityFrameworkCore;

namespace FutPool.Models
{
    public class FutPoolContext : DbContext
    {
        public FutPoolContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamTournament>().HasKey(t => new { t.TeamId, t.TournamentId });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<League> Leagues { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }
    }
}
