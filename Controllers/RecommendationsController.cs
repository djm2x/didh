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
using System.Linq.Expressions;
using System.Reflection;
using Admin5.Providers;

namespace Admin5.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RecommendationsController : SuperController<Recommendation>
    {
        private IWebHostEnvironment _hostingEnvironment;
        public RecommendationsController(AdminContext context, IWebHostEnvironment hostingEnvironment) : base(context)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("{startIndex}/{pageSize}/{sortBy}/{sortDir}/{idCycle}/{idOrgane}/{idVisite}/{idAxe}/{idSousAxe}")]
        public async Task<IActionResult> GetAllForSynthese(
            int startIndex, int pageSize, string sortBy, string sortDir, int idCycle, int idOrgane, int idVisite, int idAxe, int idSousAxe)
        {
            var query = _context.Recommendations
               .Where(e => idCycle == 0 ? true : e.IdCycle == idCycle)
               .Where(e => idOrgane == 0 ? true : e.IdOrgane == idOrgane)
               .Where(e => idVisite == 0 ? true : e.IdVisite == idVisite)
               .Where(e => idAxe == 0 ? true : e.IdAxe == idAxe)
               .Where(e => idSousAxe == 0 ? true : e.IdSousAxe == idSousAxe)
            //    .Include(e => e.RecomOrgs)
            //    .Select(e => e)
               ;

            int count = await query.CountAsync();

            var list = query.OrderByName<Recommendation>(sortBy, sortDir == "desc")
                .Skip(startIndex)
                .Take(pageSize)
                // .Select(e => new {
                //         id = e.Id,
                //         CodeRecommendation = e.CodeRecommendation,
                //         Nom = e.Nom,
                //         Etat = e.Etat,
                //         Mecanisme = e.Mecanisme,
                //         Axe = e.Axe,
                //         SousAxe = e.SousAxe,
                //         PieceJointe = e.PieceJointe,
                //     })
                .ToListAsync()
            ;



            return Ok(new { list = list, count = count });
        }

        [HttpGet("{idOrganisme}")]
        public async Task<ActionResult<int>> GetCount(int idOrganisme)
        {
            // var i = await _context.Recommendations
            //     .Where(e => e.RecomOrgs.Any(o => o.IdOrganisme == idOrganisme))
            //     .CountAsync()
            //     ;
            return await _context.Recommendations
                .Where(e => e.RecomOrgs.Any(o => o.IdOrganisme == idOrganisme))
                .CountAsync()
                ;
        }

        [HttpGet]
        public async Task<IActionResult> RecommandationByCycle()
        {
            var list = await _context.Recommendations
                .Include(e => e.Cycle)
                .GroupBy(e => e.Cycle.Label)
                .Select(e => new { cycle = e.Key, recommandations = e.Count() })
                .ToListAsync()
                ;

            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> StateRecommendationByOrganisme()
        {
            var list = await _context.Organismes
                    .Select(e => new
                    {
                        name = e.Label,
                        value = e.RecomOrgs.Sum(r => r.Recommendation.EtatAvancementChiffre) / e.RecomOrgs.Count(),
                    })
                    .Distinct()
                    .ToListAsync()
                ;


            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> StateRecommendationByAxe()
        {
            var list = await _context.Axes
                    .Select(e => new
                    {
                        table = e.Label,
                        value = e.Recommendations.Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count()
                    })
                   .ToListAsync()
                ;


            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> StateRecommendationByMecanismeTaux()
        {
            var axe = await _context.Axes
                    .Select(e => e.Recommendations.Count())
                   .FirstOrDefaultAsync()
                ;

            var visite = await _context.Visites
                   .Select(e => e.Recommendations.Count())
                   .FirstOrDefaultAsync()
               ;

            var organe = await _context.Organes
                .Select(e => e.Recommendations.Count())
                .FirstOrDefaultAsync()
            ;

            var list = new[] { new { table = "", value = 0 } }.ToList();

            list.Add(new { table = "Examen Périodique universelle", value = axe });
            list.Add(new { table = "Organes de Traités", value = organe });
            list.Add(new { table = "Procédures spéciales", value = visite });


            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> StateRecommendationByMecanismePercentage()
        {
            var axe = await _context.Axes
                    .Select(e => e.Recommendations.Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count())
                   .FirstOrDefaultAsync()
                ;

            var visite = await _context.Visites
                   .Select(e => e.Recommendations.Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count())
                   .FirstOrDefaultAsync()
               ;

            var organe = await _context.Organes
                .Select(e => e.Recommendations.Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count())
                .FirstOrDefaultAsync()
            ;

            var list = new[] { new { table = "", value = 0 } }.ToList();

            list.Add(new { table = "Examen Périodique universelle", value = axe });
            list.Add(new { table = "Organes de Traités", value = organe });
            list.Add(new { table = "Procédures spéciales", value = visite });


            return Ok(list);
        }


        [HttpGet("{table}/{type}")]
        public async Task<IActionResult> GenericByRecommendation(string table, string type)
        {
            //https://stackoverflow.com/questions/57131550/why-cant-i-create-a-listt-of-anonymous-type-in-c

            var list = new[] { new { table = "", value = 0 } }.ToList();

            if (table == "axe")
            {
                list = await _context.Axes
                    .Select(e => new
                    {
                        table = e.Label,
                        value = type == "count" ? (e.Recommendations.Count()) : (e.Recommendations.Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count()),
                    })
                    .Distinct()
                    .ToListAsync()
                ;
            }
            else if (table == "organe")
            {
                list = await _context.Organes
                    .Select(e => new
                    {
                        table = e.Label,
                        value = type == "count" ? (e.Recommendations.Count()) : (e.Recommendations.Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count()),
                    })
                    .Distinct()
                    .ToListAsync()
                ;
            }
            else
            {
                list = _context.Visites
                    .Select(e => new
                    {
                        table = e.Mandat,
                        value = type == "count" ? (e.Recommendations.Count()) : (e.Recommendations.Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count()),
                    })
                    .Distinct()
                    .ToList()
                ;
            }

            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> RecommandationByOrganisme()
        {
            var list = await _context.Organismes
                // .Include(e => e.us)
                // .GroupBy(e => e.RecomOrgs.Label)
                .Select(e => new { name = e.Label, count = e.RecomOrgs.Count })
                .ToListAsync()
                ;

            return Ok(list);
        }


        [HttpGet("{idCycle}")]
        public async Task<IActionResult> RecommandationByAxe(int idCycle)
        {
            var list = await _context.Recommendations
                .Where(e => idCycle == 0 ? true : e.IdCycle == idCycle)
                .Include(e => e.Axe)
                .GroupBy(e => e.Axe.Label)
                .Select(e => new { axe = e.Key, recommandations = e.Count() })
                .ToListAsync()
                ;

            return Ok(list);
        }

        [HttpGet("{idTraite}")]
        public async Task<IActionResult> RecommandationByConvention(int idTraite)
        {
            var lastCycle = _context.Cycles.AsEnumerable().LastOrDefault();
            var list = await _context.Recommendations
                .Where(e => idTraite == 0 ? true : e.SyntheseRecommandations.Any(sr => sr.Synthese.Rapport.IdTraite == idTraite))
                .Where(e => e.Cycle.Id == lastCycle.Id)
                .Include(e => e.Axe)
                .GroupBy(e => e.Axe.Label)
                .Select(e => new { axe = e.Key, recommandations = e.Count() })
                .ToListAsync()
                ;

            return Ok(list);
        }

        [HttpGet("{idCycle}/{idOrgane}/{idVisite}")]
        public async Task<IActionResult> RecommandationByMecanisme(int idCycle, int idOrgane, int idVisite)
        {
            var list = await _context.Recommendations
                .Where(e => idCycle == 0 ? true : e.IdCycle == idCycle)
                .Where(e => idOrgane == 0 ? true : e.IdOrgane == idOrgane)
                .Where(e => idVisite == 0 ? true : e.IdVisite == idVisite)
                .Include(e => e.Axe)
                .GroupBy(e => e.Axe.Label)
                .Select(e => new { axe = e.Key, recommandations = e.Count() })
                .ToListAsync()
                ;

            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> SearchAndGet2(Model model)
        {
            int idUser = HttpContext.GetIdUser();
            int role = HttpContext.GetRoleUser();
            bool hasAcess = (role == 1 || role == 4) ? true : false;

            var query = _context.Recommendations
                // .Where(e => hasAcess ? true : (e.User.IdOrganisme == idOrganisme))
                .Where(e => model.IdOrganisme == 0 ? true : e.RecomOrgs.Any(o => o.IdOrganisme == model.IdOrganisme))
                .Where(e => model.Nom == "" ? true : e.Nom.ToLower().Contains(model.Nom.ToLower()))
                .Where(e => model.Etat == "" ? true : e.Etat.ToLower().Contains(model.Etat.ToLower()))
                .Where(e => model.IdPays == 0 ? true : e.IdPays == model.IdPays)
                .Where(e => model.IdAxe == 0 ? true : e.IdAxe == model.IdAxe)
                .Where(e => model.IdCycle == 0 ? true : e.IdCycle == model.IdCycle)
                .Where(e => model.IdSousAxe == 0 ? true : e.IdSousAxe == model.IdSousAxe)
                .Where(e => model.Mecanisme == "" ? true : e.Mecanisme == model.Mecanisme)
                .Where(e => model.IdVisite == 0 ? true : e.IdVisite == model.IdVisite)
                .Where(e => model.IdOrgane == 0 ? true : e.IdOrgane == model.IdOrgane)
            ;

            int count = 0;
            var list = new List<Recommendation>();
            if (model.IsAllEmpty())
            {
                count = await _context.Recommendations.CountAsync();

                list = await query.OrderByName<Recommendation>(model.SortBy, model.SortDir == "desc")
                    .Skip(model.StartIndex)
                    .Take(model.PageSize)
                    // .Include(e => e.RecomOrgs)
                    .Include(e => e.Axe)
                    // .Include(e => e.Organe)
                    // .Include(e => e.Visite)
                    .Include(e => e.SousAxe)
                    // .Select(e => new {
                    //     id = e.Id,
                    //     CodeRecommendation = e.CodeRecommendation,
                    //     Nom = e.Nom,
                    //     Etat = e.Etat,
                    //     Mecanisme = e.Mecanisme,
                    //     Axe = e.Axe,
                    //     SousAxe = e.SousAxe,
                    //     PieceJointe = e.PieceJointe,
                    // })
                    .ToListAsync();
                ;
            }
            else
            {
                count = await query.CountAsync();

                list = await query.OrderByName<Recommendation>(model.SortBy, model.SortDir == "desc")
                    .Skip(model.StartIndex)
                    .Take(model.PageSize)
                    // .Include(e => e.RecomOrgs)
                    .Include(e => e.Axe)
                    // .Include(e => e.Organe)
                    // .Include(e => e.Visite)
                    .Include(e => e.SousAxe)
                    .ToListAsync();
                ;
            }

            return Ok(new { list = list, count = count });
        }

        [HttpPost]
        public async Task<IActionResult> SearchAndGet(Model model)
        {
            int idUser = HttpContext.GetIdUser();
            int role = HttpContext.GetRoleUser();
            bool hasAcess = (role == 1 || role == 4) ? true : false;

            var query = _context.Recommendations
                // .Where(e => hasAcess ? true : (e.User.IdOrganisme == idOrganisme))
                .Where(e => model.IdOrganisme == 0 ? true : e.RecomOrgs.Any(o => o.IdOrganisme == model.IdOrganisme))
                .Where(e => model.Nom == "" ? true : e.Nom.ToLower().Contains(model.Nom.ToLower()))
                .Where(e => model.Etat == "" ? true : e.Etat.ToLower().Contains(model.Etat.ToLower()))
                .Where(e => model.IdPays == 0 ? true : e.IdPays == model.IdPays)
                .Where(e => model.IdAxe == 0 ? true : e.IdAxe == model.IdAxe)
                .Where(e => model.IdCycle == 0 ? true : e.IdCycle == model.IdCycle)
                .Where(e => model.IdSousAxe == 0 ? true : e.IdSousAxe == model.IdSousAxe)
                .Where(e => model.Mecanisme == "" ? true : e.Mecanisme == model.Mecanisme)
                .Where(e => model.IdVisite == 0 ? true : e.IdVisite == model.IdVisite)
                .Where(e => model.IdOrgane == 0 ? true : e.IdOrgane == model.IdOrgane)
            ;

            var count = await query.CountAsync();

            var list = await query.OrderByName<Recommendation>(model.SortBy, model.SortDir == "desc")
                    .Skip(model.StartIndex)
                    .Take(model.PageSize)
                    // .Include(e => e.RecomOrgs)
                    // .Include(e => e.Axe)
                    // .Include(e => e.Organe)
                    // .Include(e => e.Visite)
                    // .Include(e => e.SousAxe)
                    .Select(e => new
                    {
                        id = e.Id,
                        CodeRecommendation = e.CodeRecommendation,
                        Nom = e.Nom,
                        Etat = e.Etat,
                        Mecanisme = e.Mecanisme,
                        Axe = e.Axe.Label,
                        SousAxe = e.SousAxe.Label,
                        PieceJointe = e.PieceJointe,
                    })
                    .ToListAsync();

            return Ok(new { list = list, count = count });
        }

        // [HttpGet("{id}")]
        // public async Task<ActionResult<Recommendation>> GetByIdCycle(int id)
        // {
        //     return Ok(await _context.Recommendations.Where(e => e.IdCycle == id).ToListAsync());
        // }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Recommendation>>> GetByIdSynthese(int id)
        {
            var model = await _context.Recommendations.Where(e => e.SyntheseRecommandations.Any(o => o.IdSynthese == id))
            .ToListAsync();

            return Ok(model);
        }


        [HttpGet("{id}")]
        public override async Task<ActionResult<Recommendation>> Get(int id)
        {
            var model = await _context.Recommendations.Where(e => e.Id == id)
            .Include(e => e.RecomOrgs)
            .FirstOrDefaultAsync();

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Recommendation>> GetDetail(int id)
        {
            var model = await _context.Recommendations.Where(e => e.Id == id)
            .Include(e => e.Axe)
            .Include(e => e.SousAxe)
            .Include(e => e.Cycle)
            .Include(e => e.Visite)
            .Include(e => e.Organe)
            .FirstOrDefaultAsync();

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        [HttpPost]
        public string PostFile(IFormFile file)
        {
            // var file = Request.Form.Files[0];  
            string path = Path.Combine(_hostingEnvironment.WebRootPath, "Recommendation");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (file.Length > 0)
            {
                string fullPath = Path.Combine(path, file.FileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            return file.FileName;
        }

        // [HttpPost]
        // public override async Task<ActionResult> updateRange(List<Recommendation> models)
        // {
        //     // Console.WriteLine("-----------------------------------------------------------------");
        //     // Console.WriteLine(JsonConvert.SerializeObject(models));
        //     // Console.WriteLine("---------------------------------------------------------------- - ");

        //     if (models.Count == 0)
        //     {
        //         return Ok(new { message = "count = 0" });
        //     }

        //     _context.Recommendations.UpdateRange(models);

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


        public static string FirstCharToUpper(string str)
        {
            return str?.First().ToString().ToUpper() + str?.Substring(1);
        }
        public IQueryable<T> OrderByName<T>(
            IQueryable<T> source,
            string propertyName,
            Boolean isDescending)
        {
            propertyName = FirstCharToUpper(propertyName);
            if (source == null) throw new ArgumentNullException("source");
            if (propertyName == null) throw new ArgumentNullException("propertyName");

            Type type = typeof(T);
            ParameterExpression arg = Expression.Parameter(type, "x");

            PropertyInfo pi = type.GetProperty(propertyName);
            Expression expr = Expression.Property(arg, pi);
            type = pi.PropertyType;

            Type delegateType = typeof(Func<,>).MakeGenericType(typeof(T), type);
            LambdaExpression lambda = Expression.Lambda(delegateType, expr, arg);

            String methodName = isDescending ? "OrderByDescending" : "OrderBy";
            object result = typeof(Queryable).GetMethods().Single(
                    method => method.Name == methodName &&
                    method.IsGenericMethodDefinition &&
                    method.GetGenericArguments().Length == 2 &&
                    method.GetParameters().Length == 2)
                .MakeGenericMethod(typeof(T), type)
                .Invoke(null, new object[] { source, lambda });
            return (IQueryable<T>)result;
        }

    }

    public class Model
    {
        public int IdAxe { get; set; }
        public int IdSousAxe { get; set; }
        public int IdOrganisme { get; set; }
        public int IdCycle { get; set; }
        public int IdPays { get; set; }
        public string Nom { get; set; }
        public string Etat { get; set; }
        public int IdOrgane { get; set; }
        public int IdVisite { get; set; }
        public string Mecanisme { get; set; }
        public int StartIndex { get; set; }
        public int PageSize { get; set; }
        public string SortBy { get; set; }
        public string SortDir { get; set; }

        public bool IsAllEmpty()
        {
            if (IdSousAxe == 0 && IdOrganisme == 0 && IdOrgane == 0 && IdVisite == 0
                && IdAxe == 0 && IdCycle == 0 && Mecanisme == "" && Nom == "" && Etat == "")
            {
                return true;
            }


            return false;
        }
    }
}
