using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using Admin5.Providers;
using System.Linq;
using System.Collections.Generic;

using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TraitesController : SuperController<Traite>
    {
        public TraitesController(AdminContext context) : base(context)
        { }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{idOrganisme}")]
        public async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir, int idOrganisme)
        {
            var q = _context.Traites
                .OrderByName<Traite>(sortBy, sortDir == "desc")
                ;

            int count = await q.CountAsync();

            var list =await q.Skip(startIndex)
                .Take(pageSize)
                .Include(e => e.Rapports)
                .ToListAsync()
                ;

            return Ok(new { list = list, count = count });
        }

        [HttpGet("{id}")]
        public override async Task<ActionResult<Traite>> Get(int id)
        {
            var model = await _context.Traites.Include(e => e.Rapports)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        [HttpGet("{idOrganisme}")]
        public async Task<ActionResult<int>> GetCount(int idOrganisme)
        {
            return await _context.Traites
                // .Where(e => e.User.IdOrganisme == idOrganisme)
                
                .CountAsync()
                ;
        }


        [HttpPost]
        public async Task<IActionResult> Put([FromBody] TraiteCustom model)
        {
            Traite t = model;
            _context.Entry(t).State = EntityState.Modified;
            // _context.Entry(model.Rapports).State = EntityState.Modified;
            // _context.Rapports.UpdateRange(model.Rapports);
            // _context.Rapports.RemoveRange(model.RapportToDelete);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return BadRequest(new { message = ex.Message });
            }

            return NoContent();
        }

        

    }

    public class TraiteCustom: Traite {
        public List<Rapport> RapportToDelete { get; set; }
    }
}
