using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;

namespace Admin5.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController: ControllerBase
    {
        protected readonly AdminContext _context;
        public ValuesController(AdminContext context)
        { 
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult>  GetValues()
        {
            var list = await _context.Axes.ToListAsync();

            return Ok(list);
        }
        
    }
}
