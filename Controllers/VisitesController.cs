using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;

using Microsoft.AspNetCore.Authorization;
using Admin5.Providers;

namespace Admin5.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VisitesController : SuperController<Visite>
    {
        public VisitesController(AdminContext context) : base(context)  { }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}")]
        public override async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir)
        {
            var list = await _context.Visites
                .OrderByName<Visite>("Date", sortDir == "desc")
                .Skip(startIndex)
                .Take(pageSize)
                .ToListAsync()
                ;
            int count = await _context.Visites.CountAsync();

            return Ok(new { list = list, count = count });
        }


       [HttpGet]
        public async Task<IActionResult> StateDetailByMecanisme() // used
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();

            var list = (await _context.Recommendations.Where(e => e.IdVisite != null).Include(e => e.Visite).ToListAsync())
                .GroupBy(e => lng == "fr" ? e.Visite.Mandat : e.Visite.MandatAr)
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

            var recommendationsCount = await _context.Recommendations.Where(r => r.IdVisite != null).CountAsync();
            var list = await _context.Visites
                .Select(e => new
                {
                    name = lng == "fr" ? e.Mandat : e.MandatAr,
                    one = e.Recommendations.Where(e => e.IdVisite != null).Count() * 100 / recommendationsCount,
                })
                .Distinct()
                .ToListAsync()
            ;

            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> MecanismeState() // pie left graph
        {

            var list = await _context.Recommendations.Where(e => e.IdVisite != null).ToListAsync();

            var one = list.Where(s => s.Etat.Equals(Etat.one)).Count();
            var two = list.Where(s => s.Etat.Equals(Etat.two)).Count();
            var three = list.Where(s => s.Etat.Equals(Etat.three)).Count();
            var four = list.Where(s => s.Etat.Equals(Etat.four)).Count();

            var total = list.Count();

            return Ok(new { one, two, three, four, total });
        }

    }
}
