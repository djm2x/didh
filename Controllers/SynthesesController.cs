using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Linq;
using Admin5.Providers;
using System.Collections.Generic;

namespace Admin5.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SynthesesController : SuperController<Synthese>
    {
        public SynthesesController(AdminContext context) : base(context)
        { }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{idOrganisme}/{idOrganismeEmetteur}/{idTraite}/{idRaport}/{idAxe}/{idSousAxe}")]
        public async Task<IActionResult> GetAll(
            int startIndex
            , int pageSize
            , string sortBy
            , string sortDir
            , int idOrganisme
            , int idOrganismeEmetteur
            , int idTraite
            , int idRaport
            , int idAxe
            , int idSousAxe
            )
        {
            //  int idUser = HttpContext.GetIdUser();
            // int role = HttpContext.GetRoleUser();
            // bool hasAcess = (role == 1 /*|| role == 2*/) ? true : false;
            // var b = (e.User.Id == idUser || e.User.IdOrganisme == idOrganisme);

            var q = _context.Syntheses
                // .Where(e => hasAcess ? true : (e.User.IdOrganisme == idOrganisme))
                .Where(e => idOrganisme == 0 ? true : (e.User.IdOrganisme == idOrganisme))
                .Where(e => idOrganismeEmetteur == 0 ? true : e.FicheSyntheses.Any(o => o.IdOrganisme == idOrganismeEmetteur))
                .Where(e => idTraite == 0 ? true : e.Rapport.IdTraite == idTraite)
                .Where(e => idRaport == 0 ? true : e.IdRapport == idRaport)
                .Where(e => idAxe == 0 ? true : e.SyntheseRecommandations.Any(r => r.Recommendation.IdAxe == idAxe))
                .Where(e => idSousAxe == 0 ? true : e.SyntheseRecommandations.Any(r => r.Recommendation.IdSousAxe == idSousAxe))
                .OrderByName<Synthese>(sortBy, sortDir == "desc")
                ;

            int count = await q.CountAsync();

            var list = await q
                .Skip(startIndex)
                .Take(pageSize)
                .ToListAsync()
                ;

            return Ok(new { list = list, count = count });
        }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{idRapport}")]
        public async Task<IActionResult> GetAllWithNoRapport(int startIndex, int pageSize, string sortBy, string sortDir, int idRapport)
        {
            var q = _context.Syntheses
            .Where(e => e.IdRapport == null || e.IdRapport == idRapport)
            .OrderByName<Synthese>(sortBy, sortDir == "desc")
            ;

            int count = await q.CountAsync();

            var list = await q
                .Skip(startIndex)
                .Take(pageSize)
                // .Include(e => e.Rapport)
                .ToListAsync()
                ;


            return Ok(new { list = list, count = count });
        }

        [HttpGet("{id}")]
        public override async Task<ActionResult<Synthese>> Get(int id)
        {
            var model = await _context.Syntheses
            .Include(e => e.SyntheseRecommandations)
            // .ThenInclude(e => e.Recommendation)
            // .ThenInclude(e => e.RecomOrgs)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Synthese>> GetDetail(int id)
        {
            var model = await _context.Syntheses.Where(e => e.Id == id)
                .Include(e => e.SyntheseRecommandations)
                    .ThenInclude(e => e.Recommendation)
                    .ThenInclude(e => e.Axes)
                .Include(e => e.SyntheseRecommandations)
                    .ThenInclude(e => e.Recommendation)
                    .ThenInclude(e => e.SousAxes)
                .Include(e => e.SyntheseRecommandations)
                    .ThenInclude(e => e.Recommendation)
                    .ThenInclude(e => e.Cycle)
                .FirstOrDefaultAsync();

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // [HttpPost]
        // public async Task<ActionResult> updateRange(List<Synthese> models)
        // {
        //     // Console.WriteLine("-----------------------------------------------------------------");
        //     // Console.WriteLine(JsonConvert.SerializeObject(models));
        //     // Console.WriteLine("---------------------------------------------------------------- - ");

        //     if (models.Count == 0)
        //     {
        //         return Ok(new { message = "count = 0" });
        //     }

        //     _context.Syntheses.UpdateRange(models);

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException ex)
        //     {
        //         return BadRequest(new { message = ex.Message });
        //     }

        //     return Created("", "ok");
        // }

       

        // [HttpGet("{id}")]
        // public override async Task<ActionResult<Synthese>> Post(int id)
        // {
        //     var model = await _context.Syntheses.Include(e => e.Recommendations)
        //         .FirstOrDefaultAsync(e => e.Id == id);

        //     if (model == null)
        //     {
        //         return NotFound();
        //     }

        //     return Ok(model);
        // }



    }
}
