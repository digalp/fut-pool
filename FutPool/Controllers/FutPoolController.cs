using System.Collections.Generic;
using System.Linq;
using FutPool.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutPool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FutPoolController : ControllerBase
    {
        private readonly FutPoolContext _context;

        public FutPoolController(FutPoolContext context)
        {
            _context = context;

            if (_context.Teams.Count() == 0)
            {
                _context.Teams.Add(new Team { Name = "Team1" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Team>> GetAllTeams()
        {
            return _context.Teams.ToList();
        }

        [HttpGet("{id}", Name = "GetTeam")]
        public ActionResult<Team> GetTeamById(int id)
        {
            var team = _context.Teams.Find(id);

            if (team == null)
            {
                return NotFound();
            }

            return team;
        }

        [HttpPost]
        public ActionResult CreateTeam([FromForm] Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();

            return CreatedAtRoute("GetTeam", new { id = team.Id }, team);
        }
    }
}