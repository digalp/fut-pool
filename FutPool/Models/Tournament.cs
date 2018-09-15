using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FutPool.Models
{
    public class Tournament
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public League League { get; set; }

        public ICollection<Team> Teams { get; set; }
    }
}