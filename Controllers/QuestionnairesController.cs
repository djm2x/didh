using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Linq;
using Admin5.Providers;

namespace Admin5.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionnairesController : SuperController<Questionnaire>
    {
        public QuestionnairesController(AdminContext context) : base(context)
        { }

         [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{theme}/{sousTheme}")]
        public async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir, string theme, string sousTheme)
        {
            var q = _context.Questionnaires
                // .Where(e => theme == "*" ? true : e.Theme.Contains(theme))
                // .Where(e => sousTheme == "*" ? true : e.SousTheme.Contains(sousTheme))
                
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
