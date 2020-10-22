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

namespace Admin5.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VisitesController : SuperController<Visite>
    {
        private IWebHostEnvironment _hostingEnvironment;
        public VisitesController(AdminContext context, IWebHostEnvironment hostingEnvironment) : base(context)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        // [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}")]
        // public async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir)
        // {

        //     var list = await _context.Visites
        //         // .FromSqlRaw($"SELECT * FROM dbo.[Visite] order by {sortBy} {sortDir} OFFSET {startIndex} ROWS FETCH NEXT {pageSize} ROWS ONLY")
        //         .FromSqlRaw($"SELECT * FROM dbo.[Visites] order by {sortBy} {sortDir}")
        //         .Skip(startIndex)
        //         .Take(pageSize)
        //         .ToListAsync();

        //     int count = await _context.Visites.CountAsync();


        //     return Ok(new { list = list, count = count });
        // }

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

    }
}
