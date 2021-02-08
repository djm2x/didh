using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Linq;
using Admin5.Providers;

using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ParticipationSessionsController : SuperController<ParticipationSession>
    {
        public ParticipationSessionsController(AdminContext context) : base(context)
        { }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{session}")]
        public async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir, string session)
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();
            
            var query = _context.ParticipationSessions
               .Where(e => session == "*" ? true : (lng == "fr" ? e.Session.Contains(session) : e.SessionAr.Contains(session)))
               ;

            int count = await query.CountAsync();

            var list = await query.OrderByName<ParticipationSession>(sortBy, sortDir == "desc")
                .Skip(startIndex)
                .Take(pageSize)
                .ToListAsync()
            ;



            return Ok(new { list = list, count = count });
        }
        
    }
}
