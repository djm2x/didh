using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Collections.Generic;

using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RecomOrgsController : SuperController<RecomOrg>
    {
        public RecomOrgsController(AdminContext context) : base(context) { }


        // [HttpPost]
        // public override async Task<ActionResult> PostRange(List<RecomOrg> models)
        // {
        //     if (models.Count == 0)
        //     {
        //         return Ok();
        //     }

        //     _context.RecomOrgs.AddRange(models);

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException ex)
        //     {
        //         return BadRequest(new { message = ex.Message });
        //     }

        //     return Ok();
        // }

        [HttpPost]
        public async Task<ActionResult> PutRange(ModelList<RecomOrg> model)
        {
            // if (model.modelsToDelete. == 0 || model.modelsToAdd.Count == 0)
            // {
            //     return BadRequest(new { message = "count = 0" });
            // }



            

            try
            {

                // await _context.SaveChangesAsync();
                //
                _context.RecomOrgs.RemoveRange(model.modelsToDelete);
                await _context.RecomOrgs.AddRangeAsync(model.modelsToAdd);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return BadRequest(new { message = ex.Message });
            }

            return Ok();
        }

        [HttpDelete("{idRecommendation}/{idOrganisme}")]
        public async Task<IActionResult> Delete([FromRoute] int idRecommendation, [FromRoute] int idOrganisme)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var model = await _context.RecomOrgs.FindAsync(idRecommendation, idOrganisme);
            if (model == null)
            {
                return NotFound();
            }

            _context.RecomOrgs.Remove(model);

            int i = await _context.SaveChangesAsync();

            return Ok(i);
        }


    }

    public class ModelList<T> {
        public List<T> modelsToDelete { get; set; }
        public List<T> modelsToAdd { get; set; }
    }
}
