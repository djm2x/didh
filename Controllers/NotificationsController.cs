using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using Admin5.Providers;
using System.Linq;

using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NotificationsController : SuperController<Notification>
    {
        public NotificationsController(AdminContext context) : base(context)
        { }


        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{idOrganisme}")]
        public async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir, int idOrganisme)
        {
            int idUser = HttpContext.GetIdUser();
            int role = HttpContext.GetRoleUser();
            bool hasAcess = (role == 1 /*|| role == 2*/) ? true : false;
            // var b = (e.User.Id == idUser || e.User.IdOrganisme == idOrganisme);
            var q = _context.Notifications
                .Where(e => hasAcess ? true : (e.IdOrganisme == idOrganisme/* || e.User.Id == idUser*/))
                .OrderByName<Notification>(sortBy, sortDir == "desc")
                ;

            int count = await q.CountAsync();

            var list =await q.Skip(startIndex)
                .Take(pageSize)
                .ToListAsync()
                ;

            return Ok(new { list = list, count = count });
        }

        [HttpPost]
        public override async Task<ActionResult<Notification>> Post(Notification model)
        {
            _context.Notifications.Add(model);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return BadRequest(new { message = ex.Message });
            }

            return Ok();
        }
        
    }
}
