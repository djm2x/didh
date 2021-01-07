using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Linq;
using System.Collections.Generic;
using Admin5.Providers;

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

            // var q = _context.Recommendations
            //     .Where(e => e.Axes != null)
            //     .Where(e => mecanisme == "" ? true : e.IdCycle != null)
            //     .Include(e => e.Axes)
            //     ;

            var recommendations = await _context.Recommendations.ToListAsync();

            var l0 = await _context.Axes.ToListAsync();

            var l1 = l0.Select(e => new
            {
                axe = e,
                recommendations = recommendations.Where(r => r.Axes == null ? false : JsonHandler.ToListInt(r.Axes).Contains(e.Id)).ToList()
            }).ToList();

            var l = l1.Select(e => new
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

            // var list = await q.ToListAsync();
            // // var count = await q.CountAsync();
            // var list2 = list
            //     .GroupBy(e => lng == "fr" ? e.Axes.Abv : e.Axes.AbvAr)
            //     .Select(e => new
            //     {
            //         name = e.Key,
            //         p = e.Where(s => s.EtatAvancementChiffre < 100 && s.EtatAvancementChiffre > 0).Count(),
            //         r = e.Where(s => s.EtatAvancementChiffre == 100).Count(),
            //         n = e.Where(s => s.EtatAvancementChiffre == 0).Count(),
            //         // // t = count,
            //         t = e.Count(),
            //     })
            //     .ToList()
            //     ;

            return Ok(l);
        }

        [HttpGet]
        public override async Task<ActionResult<IEnumerable<Axe>>> Get()
        {
            return await _context.Axes.Include(e => e.SousAxes).ToListAsync();
        }

    }
}
