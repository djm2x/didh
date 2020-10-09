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


        [HttpGet]
        public async Task<IActionResult> StateAxes() // used
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();

            // int recommendationsCount = await _context.Recommendations.CountAsync();

            var list = await _context.Recommendations.Where(e => e.Axe != null).Include(e => e.Axe).ToListAsync();

            var list2 = list
                .GroupBy(e => lng == "fr" ? e.Axe.Abv : e.Axe.LabelAr)
                .Select(e => new
                {
                    name = e.Key,
                    p = e.Where(s => s.EtatAvancementChiffre < 100 && s.EtatAvancementChiffre > 0).Count(),
                    r = e.Where(s => s.EtatAvancementChiffre == 100).Count(),
                    n = e.Where(s => s.EtatAvancementChiffre == 0).Count(),
                    t = e.Count(),
                })
                .ToList()
                ;

            return Ok(list2);
        }
        
    }
}
