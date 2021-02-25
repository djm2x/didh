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
using Admin5.Providers;

using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RapportsController : SuperController<Rapport>
    {
        // private readonly AdminContext _context;
        private IWebHostEnvironment _hostingEnvironment;

        public RapportsController(AdminContext context, IWebHostEnvironment hostingEnvironment) : base(context)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}")]
        public override async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir)
        {
            var list = await _context.Rapports
                .OrderByName<Rapport>(sortBy, sortDir == "desc")
                .Skip(startIndex)
                .Take(pageSize)
                .ToListAsync()
                ;

            int count = await _context.Rapports.CountAsync();

            return Ok(new { list = list, count = count });
        }

        [HttpGet("{idTraite}")]
        public async Task<IActionResult> GetByIdTraite(int idTraite)
        {
            var list = await _context.Rapports
                .Where(e => e.IdTraite == idTraite)
                .Select(e => new { Id = e.Id, Titre = e.Titre})
                .ToListAsync()
                ;

            return Ok(list);
        }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{idTraite}")]
        public async Task<IActionResult> GetAllByTraite(int startIndex, int pageSize, string sortBy, string sortDir, int idTraite)
        {
            var q = _context.Rapports
                .Where(e => e.IdTraite == idTraite)
                .OrderByName<Rapport>(sortBy, sortDir == "desc")
                ;

            int count = await q.CountAsync();

            var list = await q
               .Skip(startIndex)
               .Take(pageSize)
               .Include(e => e.Syntheses)
               .ToListAsync()
               ;

            return Ok(new { list = list, count = count });
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> UploadFiles(/*[FromForm] IFormFileCollection files*/)
        {
            IFormFileCollection files = Request.Form.Files;
            string path = Path.Combine(_hostingEnvironment.WebRootPath, "rapport");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (files.Count > 0)
            {
                try
                {
                    foreach (var file in files)
                    {
                        string fullPath = Path.Combine(path, file.FileName);
                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    BadRequest(ex.Message);
                }

            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public override async Task<ActionResult> Delete(int id)
        {
            var model = await _context.Rapports.Where(e => e.Id == id)
                .Include(e => e.Syntheses)
                .FirstOrDefaultAsync()
                ;

            if (model == null)
            {
                return NotFound();
            }
            var syns = model.Syntheses.ToList();
            syns.ForEach(e => e.IdRapport = null);
            _context.Syntheses.UpdateRange(syns);

            model.Syntheses = null;

            _context.Rapports.Remove(model);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return BadRequest(new { message = ex.Message });
            }

            return Ok();
        }
    }
}
