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
    public class SyntheseRecommandationsController : SuperController<SyntheseRecommandation>
    {
        public SyntheseRecommandationsController(AdminContext context) : base(context)
        { }
        
        [HttpPost]
        public async Task<ActionResult> PutRange(ModelList<SyntheseRecommandation> model)
        {
            try
            {
                _context.SyntheseRecommandations.RemoveRange(model.modelsToDelete);
                // await _context.SaveChangesAsync();
                // // _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

                // _context.Entry(model.modelsToDelete).State = EntityState.Detached;
                // _context.Entry(model.modelsToAdd).State = EntityState.Added;
                // var list = model.modelsToAdd.ForEach(e => e.i)
                // {
                    
                // }
                await _context.SyntheseRecommandations.AddRangeAsync(model.modelsToAdd);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Ok(new { message = ex.Message });
            }

            return Ok();
        }
    }
}
