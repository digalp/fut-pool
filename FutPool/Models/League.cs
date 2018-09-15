using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FutPool.Models
{
    public class League
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Tournament> Tournaments { get; set; }
    }
}