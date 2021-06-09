﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin5.Models;
using Microsoft.AspNetCore.Hosting;
using Admin5.Providers;

namespace Admin5.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RecommendationsController : SuperController<Recommendation>
    {
        public RecommendationsController(AdminContext context) : base(context) { }

        [HttpPost]
        public async Task<IActionResult> SearchAndGet(Model model)
        {
            // int idUser = HttpContext.GetIdUser();
            // int role = HttpContext.GetRoleUser();
            // bool hasAcess = (role == 1 || role == 4) ? true : false;
            string lng = Request.Headers["mylang"].FirstOrDefault();

            var q = await _context.Recommendations.OrderByName<Recommendation>(model.SortBy, model.SortDir == "desc")
                .Where(e => model.Nom == "" ? true :
                    lng == "fr" ? e.Nom.ToLower().Contains(model.Nom.ToLower()) :
                    e.NomAr.ToLower().Contains(model.Nom.ToLower())
                )
                .Where(e => model.Etat == "" ? true : e.Etat.ToLower().Contains(model.Etat.ToLower()))
                .Where(e => model.IdPays == 0 ? true : e.IdPays == model.IdPays)

                .Where(e => model.IdCycle == 0 ? true : e.IdCycle == model.IdCycle)
                .Where(e => model.Mecanisme == "" ? true : e.Mecanisme == model.Mecanisme)
                .Where(e => model.IdVisite == 0 ? true : e.IdVisite == model.IdVisite)
                .Where(e => model.IdOrgane == 0 ? true : e.IdOrgane == model.IdOrgane)
                .Where(e => model.Annee == 0 ? true : e.Annee == model.Annee)

                .Include(e => e.RecomOrgs).ThenInclude(e => e.Organisme)
                .Include(e => e.Cycle)
                .Include(e => e.Visite)
                .Include(e => e.Organe)
                .ToListAsync()
                ;
            // .Where(e => hasAcess ? true : (e.User.IdOrganisme == idOrganisme))
            var query = q.Where(e => model.IdOrganisme == 0 ? true : e.RecomOrgs.Any(o => o.IdOrganisme == model.IdOrganisme))
                 .Where(e => model.IdAxe == 0 ? true : JsonHandler.ToListInt(e.Axes).Contains(model.IdAxe))
                .Where(e => model.IdSousAxe == 0 ? true : JsonHandler.ToListInt(e.SousAxes).Contains(model.IdSousAxe))
                .ToList()
            ;

            var count = query.Count();

            var axes = await _context.Axes.ToListAsync();
            var sousAxes = await _context.SousAxes.ToListAsync();

            var list = query
                .Skip(model.StartIndex)
                .Take(model.PageSize)
                // .Include(e => e.RecomOrgs).ThenInclude(e => e.Organisme)
                .ToList().Select(e => new
                {
                    id = e.Id,
                    CodeRecommendation = e.CodeRecommendation,
                    Nom = e.Nom,
                    CodeRecommendationAr = e.CodeRecommendationAr,
                    NomAr = e.NomAr,
                    Etat = e.Etat,
                    Annee = e.Annee,
                    Mecanisme = e.Mecanisme,
                    Visite = lng == "fr" ? e.Visite?.Mandat : e.Visite?.MandatAr,
                    Cycle = lng == "fr" ? e.Cycle?.Label : e.Cycle?.LabelAr,
                    Organe = lng == "fr" ? e.Organe?.Label : e.Organe?.LabelAr,
                    Axe = axes.Where(r => JsonHandler.ToListInt(e.Axes).Contains(r.Id)).Select(r => lng == "fr" ? r.Label : r.LabelAr).ToList(),
                    SousAxe = sousAxes.Where(r => JsonHandler.ToListInt(e.SousAxes).Contains(r.Id)).Select(r => lng == "fr" ? r.Label : r.LabelAr).ToList(),
                    Observation = e.Observation,
                    Complement = e.Complement,
                    PieceJointe = e.PieceJointe,
                    organismes = e.RecomOrgs.Select(r => lng == "fr" ? r.Organisme?.Label : r.Organisme?.LabelAr).ToList(),
                    idsOrganisme = e.RecomOrgs.Select(r => r.IdOrganisme).ToList()
                }).ToList()
                ;

            return Ok(new { list = list, count = count });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Recommendation>> GetDetail(int id)
        {
            var axes = await _context.Axes.ToListAsync();
            var sousAxes = await _context.SousAxes.ToListAsync();

            string lng = Request.Headers["mylang"].FirstOrDefault();

            var model = await _context.Recommendations.Where(e => e.Id == id)
            // .Include(e => e.Axe)
            // .Include(e => e.SousAxe)
            .Include(e => e.Cycle)
            .Include(e => e.Visite)
            .Include(e => e.Organe)
            .FirstOrDefaultAsync();

            if (model == null)
            {
                return NotFound();
            }

            model.Axes = axes.Where(r => JsonHandler.ToListInt(model.Axes).Contains(r.Id)).Select(r => lng == "fr" ? r.Label : r.LabelAr)
                .ToList()
                .Aggregate((a, b) => a + ", " + b)
                ;

            model.SousAxes = sousAxes.Where(r => JsonHandler.ToListInt(model.SousAxes).Contains(r.Id)).Select(r => lng == "fr" ? r.Label : r.LabelAr)
                .ToList()
                .Aggregate((a, b) => a + ", " + b)
                ;

            return Ok(model);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> mecanismeCount(string name)
        {
            var q = _context.Recommendations;

            if (name == "examen")
            {
                return Ok(await q.Where(e => e.IdCycle != null).CountAsync());
            }

            if (name == "organe")
            {
                return Ok(await q.Where(e => e.IdOrgane != null).CountAsync());
            }

            return Ok(await q.Where(e => e.IdVisite != null).CountAsync());
        }



        [HttpGet]
        public async Task<IActionResult> RecommandationValues()
        {
            var realise = await _context.Recommendations.Where(e => e.EtatAvancementChiffre == 100).CountAsync();
            var nonRealise = await _context.Recommendations.Where(e => e.EtatAvancementChiffre == 0).CountAsync();
            var enCours = await _context.Recommendations.Where(e => e.EtatAvancementChiffre != 0 && e.EtatAvancementChiffre != 100).CountAsync();
            var count = await _context.Recommendations.CountAsync();
            return Ok(new { realise, nonRealise, enCours, count });
        }

        [HttpGet]
        public async Task<IActionResult> Annee()
        {
            // var list = await _context.Recommendations.Select(e => e.Annee)
            //     .Distinct()
            //     .OrderByDescending(e => e)
            //     .ToListAsync()
            //     ;

            var list0 = (await _context.Recommendations.Where(e => e.Annee != null).ToListAsync()).GroupBy(e => e.Annee)
                .Select(e => new
                {
                    annee = e.Key,
                    AnneeDisplay = e.First().AnneeDisplay,
                    AnneeDisplayAr = e.First().AnneeDisplayAr,
                })
                .ToList()
                ;

            return Ok(list0);
        }

        [HttpPost]
        public async Task<IActionResult> StateParamAxe(Model model) // used
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();



            var q = (await _context.Recommendations.Include(e => e.Visite).Include(e => e.Organe).Include(e => e.RecomOrgs).ThenInclude(e => e.Organisme).ToListAsync())
                .Where(e => model.IdCycle == 0 ? true : e.IdCycle == model.IdCycle)
                .Where(e => model.IdOrgane == 0 ? true : e.IdOrgane == model.IdOrgane)
                .Where(e => model.Mecanisme == "" ? true : e.Mecanisme.ToLower().Equals(model.Mecanisme.ToLower()))
                // .Where(e => model.Etat == "" ? true : e.Etat.Contains(model.Etat))
                .Where(e => model.IdVisite == 0 ? true : e.IdVisite == model.IdVisite)
                .Where(e => model.IdPays == 0 ? true : e.IdPays == model.IdPays)
                .Where(e => model.IdAxe == 0 ? true : JsonHandler.ToListInt(e.Axes).Contains(model.IdAxe))
                .Where(e => model.IdSousAxe == 0 ? true : JsonHandler.ToListInt(e.SousAxes).Contains(model.IdSousAxe))
                .Where(e => model.IdOrganisme == 0 ? true : e.RecomOrgs.Any(r => r.IdOrganisme == model.IdOrganisme))
                .Where(e => model.Annee == 0 ? true : e.Annee == model.Annee)

                .ToList()
                // .Where(e => model.Etat == "" ? true : e.Etat.Contains(model.Etat))
                ;


            var department = q
                .Where(e => e.RecomOrgs.Count > 0)
                .GroupBy(e => lng == "fr" ? e.RecomOrgs.FirstOrDefault().Organisme.Label : e.RecomOrgs.FirstOrDefault().Organisme.LabelAr)
                .Select(e => new
                {
                    id = e.First().RecomOrgs.First().IdOrganisme,
                    name = e.Key,
                    type = e.First().RecomOrgs.First().Organisme.Type,
                    // nameAr = e.First().RecomOrgs.First().Organisme.LabelAr,

                    one = e.Where(s => s.Etat.Equals(Etat.one)).Count(),
                    two = e.Where(s => s.Etat.Equals(Etat.two)).Count(),
                    three = e.Where(s => s.Etat.Equals(Etat.three)).Count(),
                    four = e.Where(s => s.Etat.Equals(Etat.four)).Count(),

                    total = e.Count(),
                    count = e.Count(),
                })
                .OrderByDescending(e => e.four * 100 / e.total)
                .ToList()

                ;

            var recommendationFiltred = q;

            var axe = (await _context.Axes.ToListAsync())
                .Select(e => new
                {
                    axe = lng == "fr" ? e.Abv : e.AbvAr,
                    recommendation = recommendationFiltred.Where(r => JsonHandler.ToListInt(r.Axes).Contains(e.Id)).ToList(),
                })
                // .ToList()
                .Select(e => new
                {
                    name = e.axe,
                    // nameAr = e.First().Axe.AbvAr,

                    one = e.recommendation.Where(s => s.Etat.Equals(Etat.one)).Count(),
                    two = e.recommendation.Where(s => s.Etat.Equals(Etat.two)).Count(),
                    three = e.recommendation.Where(s => s.Etat.Equals(Etat.three)).Count(),
                    four = e.recommendation.Where(s => s.Etat.Equals(Etat.four)).Count(),

                    total = e.recommendation.Count(),
                })
                .OrderByDescending(e => e.four * 100 / e.total)
                .ToList()
                ;

            var organe = (q.Where(e => e.Organe != null))
                .GroupBy(e => lng == "fr" ? e.Organe.Label : e.Organe.LabelAr)
                .Select(e => new
                {
                    name = e.Key,

                    one = e.Where(s => s.Etat.Equals(Etat.one)).Count(),
                    two = e.Where(s => s.Etat.Equals(Etat.two)).Count(),
                    three = e.Where(s => s.Etat.Equals(Etat.three)).Count(),
                    four = e.Where(s => s.Etat.Equals(Etat.four)).Count(),

                    total = e.Count(),
                })
                .OrderByDescending(e => e.four * 100 / e.total)
                .ToList()
                ;

            var visite = (q.Where(e => e.Visite != null))
                .GroupBy(e => lng == "fr" ? (e.Visite.Abr == "" ? e.Visite.Mandat : e.Visite.Abr) : (e.Visite.AbrAr == "" ? e.Visite.MandatAr : e.Visite.AbrAr))
                .Select(e => new
                {
                    name = e.Key,
                    one = e.Where(s => s.Etat.Equals(Etat.one)).Count(),
                    two = e.Where(s => s.Etat.Equals(Etat.two)).Count(),
                    three = e.Where(s => s.Etat.Equals(Etat.three)).Count(),
                    four = e.Where(s => s.Etat.Equals(Etat.four)).Count(),

                    total = e.Count(),
                })
                .OrderByDescending(e => e.four * 100 / e.total)
                .ToList()
                ;


            q = q.Where(e => model.Etat == "" ? true : e.Etat.Contains(model.Etat)).ToList();

            var nonRealise = q.Where(e => e.Etat.Equals(Etat.one)).Count();
            var enCours = q.Where(e => e.Etat.Equals(Etat.two)).Count();
            var enCoursRealisation = q.Where(e => e.Etat.Equals(Etat.three)).Count();
            var realise = q.Where(e => e.Etat.Equals(Etat.four)).Count();

            var recommandationValues = new { realise, nonRealise, enCoursRealisation, enCours, count = q.Count() };

            int recommendationsCount = await _context.Recommendations.CountAsync();

            return Ok(new { mecanisme = Calc(q), count = recommendationsCount, organe, visite, axe, epu = axe, department, recommandationValues });
        }

        private object Calc(List<Recommendation> q)
        {
            var l = q/*.Where(e => e.Annee != 2008)*/.ToList();

            var epu = new { total = l.Where(e => e.IdCycle != null).Count() };

            var organe = new { total = l.Where(e => e.IdOrgane != null).Count() };

            var visite = new { total = l.Where(e => e.IdVisite != null).Count() };

            return new { epu, organe, visite };

        }

        [HttpGet]
        public async Task<IActionResult> StateRecommendationByOrganisme() // userd home 
        {
            var recomOrgs = await _context.RecomOrgs.Include(e => e.Organisme).Include(e => e.Recommendation).ToListAsync();

            var count = await _context.Recommendations.Where(e => e.RecomOrgs.Count != 0).CountAsync();

            var list = recomOrgs.GroupBy(e => e.Organisme.Label)
                .Select(e => new
                {
                    name = e.Key,
                    type = e.First().Organisme.Type,
                    nameAr = e.First().Organisme.LabelAr,

                    one = e.Where(s => s.Recommendation.Etat.Equals(Etat.one)).Count(),
                    two = e.Where(s => s.Recommendation.Etat.Equals(Etat.two)).Count(),
                    three = e.Where(s => s.Recommendation.Etat.Equals(Etat.three)).Count(),
                    four = e.Where(s => s.Recommendation.Etat.Equals(Etat.four)).Count(),

                    total = e.Count(),
                })
                .ToList()
                ;

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
        public int Annee { get; set; }

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
