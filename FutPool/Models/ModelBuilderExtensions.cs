using Microsoft.EntityFrameworkCore;

namespace FutPool.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // TODO: initialize test data here
            modelBuilder.Entity<League>().HasData(
                new League
                {
                    Id = 1,
                    Name = "Liga MX"
                }
            );

            modelBuilder.Entity<Tournament>().HasData(
                new Tournament
                {
                    Id = 1,
                    Name = "Apertura 2018",
                    LeagueId = 1
                }
            );

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "America" },
                new Team { Id = 2, Name = "Atlas" },
                new Team { Id = 3, Name = "Lobos BUAP" },
                new Team { Id = 4, Name = "Cruz Azul" },
                new Team { Id = 5, Name = "Guadalajara" },
                new Team { Id = 6, Name = "Leon" },
                new Team { Id = 7, Name = "Monterrey" },
                new Team { Id = 8, Name = "Morelia" },
                new Team { Id = 9, Name = "Necaxa" },
                new Team { Id = 10, Name = "Pachuca" },
                new Team { Id = 11, Name = "Puebla" },
                new Team { Id = 12, Name = "Queretaro" },
                new Team { Id = 13, Name = "Santos Laguna" },
                new Team { Id = 14, Name = "Tijuana" },
                new Team { Id = 15, Name = "Toluca" },
                new Team { Id = 16, Name = "Tigres UANL" },
                new Team { Id = 17, Name = "Pumas UNAM" },
                new Team { Id = 18, Name = "Veracruz" }
            );

            modelBuilder.Entity<TeamTournament>().HasData(
                new TeamTournament { TeamId = 1, TournamentId = 1 },
                new TeamTournament { TeamId = 2, TournamentId = 1 },
                new TeamTournament { TeamId = 3, TournamentId = 1 },
                new TeamTournament { TeamId = 4, TournamentId = 1 },
                new TeamTournament { TeamId = 5, TournamentId = 1 },
                new TeamTournament { TeamId = 6, TournamentId = 1 },
                new TeamTournament { TeamId = 7, TournamentId = 1 },
                new TeamTournament { TeamId = 8, TournamentId = 1 },
                new TeamTournament { TeamId = 9, TournamentId = 1 },
                new TeamTournament { TeamId = 10, TournamentId = 1 },
                new TeamTournament { TeamId = 11, TournamentId = 1 },
                new TeamTournament { TeamId = 12, TournamentId = 1 },
                new TeamTournament { TeamId = 13, TournamentId = 1 },
                new TeamTournament { TeamId = 14, TournamentId = 1 },
                new TeamTournament { TeamId = 15, TournamentId = 1 },
                new TeamTournament { TeamId = 16, TournamentId = 1 },
                new TeamTournament { TeamId = 17, TournamentId = 1 },
                new TeamTournament { TeamId = 18, TournamentId = 1 }
            );
        }
    }
}