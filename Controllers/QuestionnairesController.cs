using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Linq;
using Admin5.Providers;

using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionnairesController : SuperController<Questionnaire>
    {
        public QuestionnairesController(AdminContext context) : base(context)
        { }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{theme}/{sousTheme}/{annee}/{reporter}/{reporterAr}")]
        public async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir, int theme, int sousTheme, int annee , string reporter, string reporterAr)
        {
            var q = _context.Questionnaires
                .Where(e => theme == 0 ? true : e.Theme == theme)
                .Where(e => sousTheme == 0 ? true : e.SousTheme == sousTheme)
                .Where(e => annee == 0 ? true : e.Annee == annee)
                .Where(e => reporter == "*" ? true : e.Reporter.ToLower().Contains(reporter.ToLower()))
                .Where(e => reporterAr == "*" ? true : e.ReporterAr.ToLower().Contains(reporterAr.ToLower()))

                ;

            int count = await q.CountAsync();

            var list = await q.OrderByName<Questionnaire>(sortBy, sortDir == "desc")
                .Skip(startIndex)
                .Take(pageSize)
                .ToListAsync()
                ;

            return Ok(new { list = list, count = count });
        }

    }
}
