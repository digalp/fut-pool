using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FutPool.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<TeamTournament> TeamTournaments { get; set; }
    }
}