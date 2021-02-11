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


        [HttpGet("{mecanisme}")]
        public async Task<IActionResult> StateAxes(string mecanisme) // used
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
                p = e.recommendations.Where(s => s.EtatAvancementChiffre < 100 && s.EtatAvancementChiffre > 0).Count(),
                r = e.recommendations.Where(s => s.EtatAvancementChiffre == 100).Count(),
                n = e.recommendations.Where(s => s.EtatAvancementChiffre == 0).Count(),
                // // t = count,
                t = e.recommendations.Count(),
            })
            .ToList()
            ;

            return Ok(list);
        }

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

                one = e.recommendations.Where(s => s.EtatAvancement.Equals(Etat.one)).Count(),
                two = e.recommendations.Where(s => s.EtatAvancement.Equals(Etat.two)).Count(),
                three = e.recommendations.Where(s => s.EtatAvancement.Equals(Etat.three)).Count(),
                four = e.recommendations.Where(s => s.EtatAvancement.Equals(Etat.four)).Count(),

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

            var recommendations = await _context.Recommendations.Where(r => r.Axes != null).ToListAsync();
            int lastCyle = await _context.Cycles.Select(e => e.Id).LastOrDefaultAsync();
            int recommendationsCount = recommendations.Count();

            var list = (await _context.Axes.ToListAsync())
                .Select(e => new
                {
                    axe = e,
                    Recommendations = recommendations.Where(r => JsonHandler.ToListInt(r.Axes).Contains(e.Id)).ToList()
                })
                .Select(e => new
                {
                    table = lng == "fr" ? e.axe.Abv : e.axe.AbvAr,
                    value = e.Recommendations.Where(r => r.IdCycle != null && r.IdCycle == lastCyle).Count() * 100 / recommendationsCount,
                })
                .Distinct()
                .ToList()
            ;

            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> MecanismeState() // pie left graph
        {
            int lastCyle = await _context.Cycles.Select(e => e.Id).LastOrDefaultAsync();

            var list = await _context.Recommendations.Where(e => e.IdCycle != null && e.IdCycle == lastCyle && e.Annee != 2008).ToListAsync();

            var one = list.Where(s => s.EtatAvancement.Equals(Etat.one)).Count();
            var two = list.Where(s => s.EtatAvancement.Equals(Etat.two)).Count();
            var three = list.Where(s => s.EtatAvancement.Equals(Etat.three)).Count();
            var four = list.Where(s => s.EtatAvancement.Equals(Etat.four)).Count();

            var total = list.Count();

            return Ok(new { one, two, three, total });
        }



    }
}
