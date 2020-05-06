using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using System.Linq;

namespace Admin5.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CyclesController : SuperController<Cycle>
    {
        public CyclesController(AdminContext context) : base(context)
        { }


        

    }
}
