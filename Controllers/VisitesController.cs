using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

using Microsoft.AspNetCore.Authorization;
using Admin5.Providers;

namespace Admin5.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VisitesController : SuperController<Visite>
    {
        private IWebHostEnvironment _hostingEnvironment;
        public VisitesController(AdminContext context, IWebHostEnvironment hostingEnvironment) : base(context)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        public string PostFile(IFormFile file)
        {
            // var file = Request.Form.Files[0];  
            string path = Path.Combine(_hostingEnvironment.WebRootPath, "visite");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (file.Length > 0)
            {
                string fullPath = Path.Combine(path, file.FileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            return file.FileName;
        }

        [HttpGet("{month}/{year}")]
        public async Task<IActionResult> GetDate(int month, int year)
        {
            var list = await _context.Visites
                .Where(e => e.Date.Value.Month == month && e.Date.Value.Year == year)
                // .Select(e => e.Date)
                .ToListAsync()
                ;


            return Ok(list);
        }


        
        [HttpGet]
        public async Task<IActionResult> StateVisites() // used
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();

            // int recommendationsCount = await _context.Recommendations.CountAsync();

            var q = _context.Recommendations.Where(e => e.Visite != null).Include(e => e.Visite);
            var list = await q.ToListAsync();
            // var count = await q.CountAsync();

            var list2 = list
                .GroupBy(e => lng == "fr" ? e.Visite.Mandat : e.Visite.MandatAr)
                .Select(e => new
                {
                    name = e.Key,
                    p = e.Where(s => s.EtatAvancementChiffre < 100 && s.EtatAvancementChiffre > 0).Count(),
                    r = e.Where(s => s.EtatAvancementChiffre == 100).Count(),
                    n = e.Where(s => s.EtatAvancementChiffre == 0).Count(),
                    // t = count,
                    t = e.Count(),
                })
                .ToList()
                ;

            return Ok(list2);
        }

        [HttpGet]
        public async Task<IActionResult> StateDetailByMecanisme() // bar graph
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();

            var list = (await _context.Recommendations.Where(e => e.Visite != null).Include(e => e.Visite).ToListAsync())
                .GroupBy(e => lng == "fr" ? e.Visite.Mandat : e.Visite.MandatAr)
                .Select(e => new
                {
                    name = e.Key,

                    one = e.Where(s => s.EtatAvancement.Equals(Etat.one)).Count(),
                    two = e.Where(s => s.EtatAvancement.Equals(Etat.two)).Count(),
                    three = e.Where(s => s.EtatAvancement.Equals(Etat.three)).Count(),
                    four = e.Where(s => s.EtatAvancement.Equals(Etat.four)).Count(),

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
