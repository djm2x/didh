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

            int recommendationsCount = await _context.Recommendations.CountAsync();

            var list = await _context.Recommendations.Where(e => e.Axe != null).Include(e => e.Axe).ToListAsync();

            var list2 = list
                .GroupBy(e => lng == "fr" ? e.Axe.Abv : e.Axe.AbvAr)
                .Select(e => new
                {
                    name = e.Key,
                    p = e.Where(e => e.EtatAvancementChiffre != 100).Sum(r => r.EtatAvancementChiffre) / e.Count(),
                    r = e.Where(e => e.EtatAvancementChiffre == 100).Sum(r => r.EtatAvancementChiffre) / e.Count(),
                    t = (double.Parse(e.Count().ToString()) / recommendationsCount) * 100,
                })
                .ToList()
                ;

            return Ok(list2);
        }
        
    }
}
