using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Linq;

namespace Admin5.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AxesController : SuperController<Axe>
    {
        public AxesController(AdminContext context) : base(context)
        { }


        [HttpGet("{mecanisme}")]
        public async Task<IActionResult> StateAxes(string mecanisme) // used
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();

            // int recommendationsCount = await _context.Recommendations.CountAsync();

            var q = _context.Recommendations
                .Where(e => e.Axe != null)
                .Where(e => mecanisme == "" ? true : e.IdCycle != null)
                .Include(e => e.Axe)
                ;

            var list = await q.ToListAsync();
            var count = await q.CountAsync();
            var list2 = list
                .GroupBy(e => lng == "fr" ? e.Axe.Abv : e.Axe.LabelAr)
                .Select(e => new
                {
                    name = e.Key,
                    p = e.Where(s => s.EtatAvancementChiffre < 100 && s.EtatAvancementChiffre > 0).Count(),
                    r = e.Where(s => s.EtatAvancementChiffre == 100).Count(),
                    n = e.Where(s => s.EtatAvancementChiffre == 0).Count(),
                    t = count,
                })
                .ToList()
                ;

            return Ok(list2);
        }
        
    }
}
