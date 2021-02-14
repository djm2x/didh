using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Linq;
using System.Collections.Generic;
using Admin5.Providers;
using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AxesController : SuperController<Axe>
    {
        public AxesController(AdminContext context) : base(context)
        { }

        [HttpGet]
        public override async Task<ActionResult<IEnumerable<Axe>>> Get()
        {
            return await _context.Axes.Include(e => e.SousAxes).ToListAsync();
        }

        [HttpGet]
        public async Task<IActionResult> StateDetailByMecanisme() // bar graph
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();

            var recommendations = await _context.Recommendations.ToListAsync();

            var list = (await _context.Axes.ToListAsync())
            .Select(e => new
            {
                axe = e,
                recommendations = recommendations.Where(r => r.Axes == null ? false : JsonHandler.ToListInt(r.Axes).Contains(e.Id)).ToList()
            })
            .Select(e => new
            {
                name = lng == "fr" ? e.axe.Abv : e.axe.AbvAr,

                one = e.recommendations.Where(s => s.Etat.Equals(Etat.one)).Count(),
                two = e.recommendations.Where(s => s.Etat.Equals(Etat.two)).Count(),
                three = e.recommendations.Where(s => s.Etat.Equals(Etat.three)).Count(),
                four = e.recommendations.Where(s => s.Etat.Equals(Etat.four)).Count(),

                total = e.recommendations.Count(),
            })
            .ToList()
            ;

            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> StateByMecanisme() // pie right graph
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();

            int lastCycle = await _context.Cycles.OrderByDescending(e => e.Id).Select(e => e.Id).FirstOrDefaultAsync();
            var recommendations = await _context.Recommendations.Where(r => r.Axes != null && r.IdCycle == lastCycle).ToListAsync();
            int recommendationsCount = recommendations.Count();

            var list = (await _context.Axes.ToListAsync())
                .Select(e => new
                {
                    axe = e,
                    Recommendations = recommendations.Where(r => JsonHandler.ToListInt(r.Axes).Contains(e.Id)).ToList()
                })
                .Select(e => new
                {
                    name = lng == "fr" ? e.axe.Abv : e.axe.AbvAr,
                    one = e.Recommendations.Count() * 100 / recommendationsCount,
                })
                .Distinct()
                .ToList()
            ;

            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> MecanismeState() // pie left graph
        {
            int lastCycle = await _context.Cycles.OrderByDescending(e => e.Id).Select(e => e.Id).FirstOrDefaultAsync();

            var list = await _context.Recommendations.Where(e => e.IdCycle != null && e.IdCycle == lastCycle && e.Annee != 2008).ToListAsync();

            var one = list.Where(s => s.Etat.Equals(Etat.one)).Count();
            var two = list.Where(s => s.Etat.Equals(Etat.two)).Count();
            var three = list.Where(s => s.Etat.Equals(Etat.three)).Count();
            var four = list.Where(s => s.Etat.Equals(Etat.four)).Count();

            var total = list.Count();

            return Ok(new { one, two, three, four, total });
        }



    }
}
