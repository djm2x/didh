using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;

namespace Admin5.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SituationReservesController : SuperController<SituationReserve>
    {
        public SituationReservesController(AdminContext context) : base(context)
        { }

         [HttpGet]
        public async Task<IActionResult> GetFirst()
        {
            var model = await _context.SituationReserves.FirstOrDefaultAsync();

            if (model == null)
            {
                return Ok(new SituationReserve());
            }

            return Ok(model);
        }

        
    }
}
