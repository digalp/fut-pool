using System.ComponentModel.DataAnnotations;

namespace FutPool.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}