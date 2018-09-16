using System.Collections.Generic;

namespace FutPool.Models
{
    public class Matchday
    {
        public int Id { get; set; }

        public ICollection<Match> Matches { get; set; }
    }
}