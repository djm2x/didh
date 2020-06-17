using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Reflection;
using Admin5.Providers;
using Microsoft.AspNetCore.Authorization;

namespace Admin5.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EvenementsController : SuperController<Evenement>
    {
        public EvenementsController(AdminContext context ) : base(context)
        { }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{title}")]
        public async Task<IActionResult> GetAll(int startIndex, int pageSize, string sortBy, string sortDir , string title)
        {
            var q = _context.Evenements
                .Where(e => title == "*" ? true : e.Title.ToLower().Contains(title.ToLower()))

                ;

            int count = await q.CountAsync();

            var list = await q.OrderByName<Evenement>(sortBy, sortDir == "desc")
                .Skip(startIndex)
                .Take(pageSize)
                
                .Select(e => new 
                {
                    id = e.Id,
                    categorie = e.Categorie,
                    title = e.Title,
                    description = e.Description,
                    date = e.Date,

                })
                .ToListAsync()
                ;

            return Ok(new { list = list, count = count });
        }

    }
}