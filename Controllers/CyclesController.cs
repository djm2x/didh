using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Linq;

using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CyclesController : SuperController<Cycle>
    {
        public CyclesController(AdminContext context) : base(context)
        { }


        

    }
}
