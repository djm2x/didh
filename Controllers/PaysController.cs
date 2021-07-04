using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;

using Microsoft.AspNetCore.Authorization;
using System.Linq;
using Admin5.Providers;

namespace Admin5.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaysController : SuperController<Pays>
    {
        public PaysController(AdminContext context) : base(context)
        { }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{nom}")]
        public async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir, string nom)
        {
           nom = nom.ToLower();
            var q = _context.Pays.Where(e => nom == "*" ? true : (e.Nom.ToLower().Contains(nom) || e.NomAr.ToLower().Contains(nom)))
                .OrderByName<Pays>(sortBy, sortDir == "desc")
                ;

            int count = await q.CountAsync();

            var list =await q.Skip(startIndex)
                .Take(pageSize)
                .ToListAsync()
                ;

            return Ok(new { list = list, count = count });
        }
        
    }
}
