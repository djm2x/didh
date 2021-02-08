using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;

using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    [Authorize]
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
