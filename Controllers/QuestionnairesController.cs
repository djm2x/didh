using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Linq;
using Admin5.Providers;

using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionnairesController : SuperController<Questionnaire>
    {
        public QuestionnairesController(AdminContext context) : base(context)
        { }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{idAxe}/{idSousAxe}/{annee}")]
        public async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir, int idAxe, int idSousAxe, int annee)
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();
            
            var q = _context.Questionnaires
                .Where(e => idAxe == 0 ? true : e.IdAxe == idAxe)
                .Where(e => idSousAxe == 0 ? true : e.IdSousAxe == idSousAxe)
                .Where(e => annee == 0 ? true : e.Annee == annee)
                // .Where(e => reporter == "*" ? true : e.Reporter.ToLower().Contains(reporter.ToLower()))
                // .Where(e => reporterAr == "*" ? true : e.ReporterAr.ToLower().Contains(reporterAr.ToLower()))

                ;

            int count = await q.CountAsync();

            var list = await q.OrderByName<Questionnaire>(sortBy, sortDir == "desc")
                .Skip(startIndex)
                .Take(pageSize)

                 .Select(e => new
                 {
                     id = e.Id,
                     IdAxe = e.IdAxe,
                     IdSousAxe = e.IdSousAxe,
                     Annee = e.Annee,
                     Axe = lng == "fr" ? e.Axe.Label : e.Axe.LabelAr,
                     SousAxe = lng == "fr" ? e.SousAxe.Label : e.SousAxe.LabelAr,
                     PieceJointe = e.PieceJointe,
                 })
                .ToListAsync()
                ;

            return Ok(new { list = list, count = count });
        }

    }
}
