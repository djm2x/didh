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
    public class OrganesController : SuperController<Organe>
    {
        public OrganesController(AdminContext context) : base(context)
        { }
        
    }
}
