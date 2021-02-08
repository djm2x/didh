using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Linq;
using System;
using Admin5.Providers;

using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FicheSynthesesController : SuperController<FicheSynthese>
    {
        public FicheSynthesesController(AdminContext context) : base(context)
        { }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{idSynthese}")]
        public async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir, int idSynthese)
        {
            var query = _context.FicheSyntheses
               .Where(e => e.IdSynthese == idSynthese)
               .Include(e => e.Organisme)
               .Include(e => e.Synthese)
            //    .Select(e => e)
               ;

            int count = await query.CountAsync();

            var list = await query.OrderByName<FicheSynthese>(sortBy, sortDir == "desc")
                .Skip(startIndex)
                .Take(pageSize)
                .ToListAsync()
            ;



            return Ok(new { list = list, count = count });
        }

        private object OrderByName<T>(IQueryable<T> query, string sortBy, bool v)
        {
            throw new NotImplementedException();
        }
    }
}
