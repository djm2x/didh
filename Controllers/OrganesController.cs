using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;

using Microsoft.AspNetCore.Authorization;
using System.Linq;
using Admin5.Providers;

namespace Admin5.Controllers
{
    // [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrganesController : SuperController<Organe>
    {
        public OrganesController(AdminContext context) : base(context)
        { }

        [HttpGet]
        public async Task<IActionResult> StateDetailByMecanisme() // used
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();

            var lastYear = await _context.Recommendations.Select(e => e.Annee).OrderByDescending(e => e).FirstOrDefaultAsync();

            var list = (await _context.Recommendations.Where(e => e.IdOrgane != null && e.Annee == lastYear).Include(e => e.Organe).ToListAsync())
                .GroupBy(e => lng == "fr" ? e.Organe.Label : e.Organe.LabelAr)
                .Select(e => new
                {
                    name = e.Key,

                    one = e.Where(s => s.Etat.Equals(Etat.one)).Count(),
                    two = e.Where(s => s.Etat.Equals(Etat.two)).Count(),
                    three = e.Where(s => s.Etat.Equals(Etat.three)).Count(),
                    four = e.Where(s => s.Etat.Equals(Etat.four)).Count(),

                    total = e.Count(),
                })
                .ToList()
                ;

            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> StateByMecanisme() // pie right graph
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();

            var lastYear = await _context.Recommendations.Select(e => e.Annee).OrderByDescending(e => e).FirstOrDefaultAsync();

            var recommendationsCount = await _context.Recommendations.Where(r => r.IdOrgane != null && r.Annee == lastYear).CountAsync();
            var list = await _context.Organes
                .Select(e => new
                {
                    name = lng == "fr" ? e.Abv : e.LabelAr,
                    one = e.Recommendations.Where(e => e.IdOrgane != null && e.Annee == lastYear).Count() * 100 / recommendationsCount,
                })
                .Distinct()
                .ToListAsync()
            ;

            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> MecanismeState() // pie left graph
        {
            var lastYear = await _context.Recommendations.Select(e => e.Annee).OrderByDescending(e => e).FirstOrDefaultAsync();

            var list = await _context.Recommendations.Where(e => e.IdOrgane != null && e.Annee == lastYear).ToListAsync();

            var one = list.Where(s => s.Etat.Equals(Etat.one)).Count();
            var two = list.Where(s => s.Etat.Equals(Etat.two)).Count();
            var three = list.Where(s => s.Etat.Equals(Etat.three)).Count();
            var four = list.Where(s => s.Etat.Equals(Etat.four)).Count();

            var total = list.Count();

            return Ok(new { one, two, three, four, total });
        }

    }
}
