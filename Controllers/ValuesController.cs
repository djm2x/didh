using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Collections.Generic;

namespace Admin5.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : SuperController<Axe>
    {
        public ValuesController(AdminContext context) : base(context)
        { }

        [HttpGet]
        public IActionResult GetValues()
        {
            return Ok(new List<string>() {"me ", "you"});
        }
        
    }
}
