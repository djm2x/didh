using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Admin5.Providers;

using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrganismeController : SuperController<Organisme>
    {
        public OrganismeController(AdminContext context) : base(context)
        { }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{idOrganisme}")]
        public async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir, int idOrganisme)
        {
           
            var q = _context.Organismes
                .Where(e => idOrganisme == 0 ? true : e.Id == idOrganisme)
                .OrderByName<Organisme>(sortBy, sortDir == "desc")
                ;

            int count = await q.CountAsync();

            var list =await q.Skip(startIndex)
                .Take(pageSize)
                .ToListAsync()
                ;

            return Ok(new { list = list, count = count });
        }
    }
}