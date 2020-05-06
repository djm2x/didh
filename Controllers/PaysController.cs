using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;

namespace Admin5.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaysController : SuperController<Pays>
    {
        public PaysController(AdminContext context) : base(context)
        { }
        
    }
}
