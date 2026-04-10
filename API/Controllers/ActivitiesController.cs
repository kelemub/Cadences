
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController(AppDbContext _context) : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            var activities = await _context.Activities.ToListAsync();
            return Ok(activities);      
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(string id)
        {
            var activity = await _context.Activities.FindAsync(id);

            if (activity == null)
            {
                return NotFound();
            }
            
            return Ok(activity);
        }
    }
}