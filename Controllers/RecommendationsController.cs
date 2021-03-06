﻿using System;
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

        [HttpPost]
        public async Task<IActionResult> SearchAndGet(Model model)
        {
            // int idUser = HttpContext.GetIdUser();
            // int role = HttpContext.GetRoleUser();
            // bool hasAcess = (role == 1 || role == 4) ? true : false;
            string lng = Request.Headers["mylang"].FirstOrDefault();

            var query = _context.Recommendations
                // .Where(e => hasAcess ? true : (e.User.IdOrganisme == idOrganisme))
                .Where(e => model.IdOrganisme == 0 ? true : e.RecomOrgs.Any(o => o.IdOrganisme == model.IdOrganisme))
                .Where(e => model.Nom == "" ? true : 
                    lng == "fr" ? e.Nom.ToLower().Contains(model.Nom.ToLower()) :
                    e.NomAr.ToLower().Contains(model.Nom.ToLower())
                )
                .Where(e => model.Etat == "" ? true : e.Etat.ToLower().Contains(model.Etat.ToLower()))
                .Where(e => model.IdPays == 0 ? true : e.IdPays == model.IdPays)
                .Where(e => model.IdAxe == 0 ? true : e.IdAxe == model.IdAxe)
                .Where(e => model.IdCycle == 0 ? true : e.IdCycle == model.IdCycle)
                .Where(e => model.IdSousAxe == 0 ? true : e.IdSousAxe == model.IdSousAxe)
                .Where(e => model.Mecanisme == "" ? true : e.Mecanisme == model.Mecanisme)
                .Where(e => model.IdVisite == 0 ? true : e.IdVisite == model.IdVisite)
                .Where(e => model.IdOrgane == 0 ? true : e.IdOrgane == model.IdOrgane)
                .Where(e => model.Annee == 0 ? true : e.Annee == model.Annee)
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
                        CodeRecommendationAr = e.CodeRecommendationAr,
                        NomAr = e.NomAr,
                        Etat = e.Etat,
                        Annee = e.Annee,
                        Mecanisme = e.Mecanisme,
                        Axe = lng == "fr" ? e.Axe.Label : e.Axe.LabelAr,
                        SousAxe = lng == "fr" ? e.SousAxe.Label : e.SousAxe.LabelAr,
                        Observation = e.Observation,
                        Complement = e.Complement,
                        PieceJointe = e.PieceJointe,
                        organismes = e.RecomOrgs.Select(r => lng == "fr" ? r.Organisme.Label : r.Organisme.LabelAr)
                    })
                    .ToListAsync();

            return Ok(new { list = list, count = count });
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

            var list = await query.OrderByName<Recommendation>(sortBy, sortDir == "desc")
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
        public async Task<IActionResult> RecommandationValues()
        {
            var realise = await _context.Recommendations.Where(e => e.EtatAvancementChiffre == 100).CountAsync();
            var nonRealise = await _context.Recommendations.Where(e => e.EtatAvancementChiffre == 0).CountAsync();
            var enCours = await _context.Recommendations.Where(e => e.EtatAvancementChiffre != 0 && e.EtatAvancementChiffre != 100).CountAsync();
            var count = await _context.Recommendations.CountAsync();
            return Ok(new { realise, nonRealise, enCours, count });
        }

        [HttpGet]
        public async Task<IActionResult> StateRecommendationByOrganisme() // userd home 
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();

            // int recommendationsCount = _context.Recommendations.Count();

            // var list0 = await _context.Recommendations
            //         .Where(e => e.RecomOrgs.Count > 0)
            //         .Include(e => e.RecomOrgs)
            //         .ThenInclude(e => e.Organisme)
            //         .ToListAsync();

            // var list = list0
            // // .GroupBy(e => lng == "fr" ? e.RecomOrgs.FirstOrDefault().Organisme.Label : e.RecomOrgs.FirstOrDefault().Organisme.LabelAr)
            // .GroupBy(e => e.RecomOrgs.FirstOrDefault().Organisme.Label)

            //     .Select(e => new
            //     {
            //         name = e.Key,
            //         type = e.First().RecomOrgs.First().Organisme.Type,
            //         nameAr = e.First().RecomOrgs.First().Organisme.LabelAr,
            //         p = e.Where(s => s.EtatAvancementChiffre != 100).Sum(r => r.EtatAvancementChiffre) / e.Count(),
            //         r = e.Where(s => s.EtatAvancementChiffre == 100).Sum(r => r.EtatAvancementChiffre) / e.Count(),
            //         t = (double.Parse(e.Count().ToString()) / recommendationsCount) * 100,
            //     })
            //     .ToList();

            var q = _context.RecomOrgs.Include(e => e.Organisme).Include(e => e.Recommendation);
            var list0 = await q.ToListAsync();
            var count = await _context.Recommendations.Where(e => e.RecomOrgs.Count != 0).CountAsync();

            var list = list0
            // .GroupBy(e => lng == "fr" ? e.RecomOrgs.FirstOrDefault().Organisme.Label : e.RecomOrgs.FirstOrDefault().Organisme.LabelAr)
            .GroupBy(e => e.Organisme.Label)
            .Select(e => new
            {
                name = e.Key,
                type = e.First().Organisme.Type,
                nameAr = e.First().Organisme.LabelAr,
                // p = e.Where(s => s.Recommendation.EtatAvancementChiffre < 100 && s.Recommendation.EtatAvancementChiffre > 0).Sum(r => r.Recommendation.EtatAvancementChiffre) / e.Count(),
                // r = e.Where(s => s.Recommendation.EtatAvancementChiffre == 100).Sum(r => r.Recommendation.EtatAvancementChiffre) / e.Count(),
                // n = e.Where(s => s.Recommendation.EtatAvancementChiffre == 0).Sum(r => r.Recommendation.EtatAvancementChiffre) / e.Count(),

                p = e.Where(s => s.Recommendation.EtatAvancementChiffre < 100 && s.Recommendation.EtatAvancementChiffre > 0).Count(),
                r = e.Where(s => s.Recommendation.EtatAvancementChiffre == 100).Count(),
                n = e.Where(s => s.Recommendation.EtatAvancementChiffre == 0).Count(),


                // t = (double.Parse(e.Count().ToString()) * 100) / recommendationsCount,
                // t = count,
                    t = e.Count(),
            })
            .ToList();


            return Ok(list);
            // return Ok(new {list, count = recommendationsCount});
        }

        [HttpGet]
        public async Task<IActionResult> Annee()
        {
            var list = await _context.Recommendations
                    .Select(e => e.Annee)
                    .Distinct()
                   .ToListAsync()
                ;

            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> StateRecommendationByAxe()
        {
            int recommendationsCount = _context.Recommendations.Count();
            var list = await _context.Axes
                    .Select(e => new
                    {
                        id = e.Id,
                        table = e.Label,
                        // value = e.Recommendations.Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count(),
                        value = (double.Parse(e.Recommendations.Count().ToString()) / recommendationsCount) * 100,
                    })
                   .ToListAsync()
                ;


            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> StateParamAxe(Model model) // used
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();
            int recommendationsCount = _context.Recommendations.Count();
            var q = _context.Recommendations
                .Where(e => model.IdCycle == 0 ? true : e.IdCycle == model.IdCycle)
                .Where(e => model.IdOrgane == 0 ? true : e.IdOrgane == model.IdOrgane)
                .Where(e => model.Mecanisme == "" ? true : e.Mecanisme.ToLower().Equals(model.Mecanisme.ToLower()))
                // .Where(e => model.Etat == "" ? true : e.Etat.Contains(model.Etat))
                .Where(e => model.IdVisite == 0 ? true : e.IdVisite == model.IdVisite)
                .Where(e => model.IdPays == 0 ? true : e.IdPays == model.IdPays)
                .Where(e => model.IdAxe == 0 ? true : e.IdAxe == model.IdAxe)
                .Where(e => model.IdSousAxe == 0 ? true : e.IdSousAxe == model.IdSousAxe)
                .Where(e => model.IdOrganisme == 0 ? true : e.RecomOrgs.Any(r => r.IdOrganisme == model.IdOrganisme))
                .Where(e => model.Annee == 0 ? true : e.Annee == model.Annee)
                // .Where(e => model.Etat == "" ? true : e.Etat.Contains(model.Etat))
                ;

            // var countR = await q.CountAsync();
            
            var department0 = await q.Include(e => e.RecomOrgs).ThenInclude(e => e.Organisme).ToListAsync();
            var department = department0
                .Where(e => e.RecomOrgs.Count > 0)
                .GroupBy(e => lng == "fr" ? e.RecomOrgs.FirstOrDefault().Organisme.Label : e.RecomOrgs.FirstOrDefault().Organisme.Label)
                .Select(e => new
                {
                    name = e.Key,
                    type = e.First().RecomOrgs.First().Organisme.Type,
                    id = e.First().RecomOrgs.First().IdOrganisme,
                    nameAr = e.First().RecomOrgs.First().Organisme.LabelAr,
                    p = e.Where(s => s.EtatAvancementChiffre < 100 && s.EtatAvancementChiffre > 0).Count(),
                    r = e.Where(s => s.EtatAvancementChiffre == 100).Count(),
                    n = e.Where(s => s.EtatAvancementChiffre == 0).Count(),
                    // c = e.Count() * recommendationsCount / 100,
                    c = e.Count(),
                    // t = countR,
                    t = e.Count(),
                })
                .ToList()

                ;

            // countR = await q.CountAsync();
            // var epu = await q
            //     .GroupBy(e => e.Cycle.Label)
            //     .Select(e => new
            //     {
            //         name = e.Key,
            //         p = e.Sum(r => r.EtatAvancementChiffre) / e.Count(),
            //         // t = (double.Parse(e.Count().ToString()) / recommendationsCount) * 100,
            //     })
            //     .SumAsync(e => e.p)
            //     ;

            var axe0 = await q.Include(e => e.Axe).ToListAsync();
            var axe = axe0.Where(e => e.Axe != null)
                .GroupBy(e => lng == "fr" ? e.Axe.Abv : e.Axe.AbvAr)
                .Select(e => new
                {
                    name = e.Key,
                    // nameAr = e.First().Axe.AbvAr,
                    p = e.Where(s => s.EtatAvancementChiffre < 100 && s.EtatAvancementChiffre > 0).Count(),
                    r = e.Where(s => s.EtatAvancementChiffre == 100).Count(),
                    n = e.Where(s => s.EtatAvancementChiffre == 0).Count(),
                    // t = countR,
                    t = e.Count(),
                })
                .ToList()
                ;

            var epu = axe0.Where(e => e.Axe != null && e.IdCycle != null)
                .GroupBy(e => lng == "fr" ? e.Axe.Abv : e.Axe.AbvAr)
                .Select(e => new
                {
                    name = e.Key,
                    // nameAr = e.First().Axe.AbvAr,
                    p = e.Where(s => s.EtatAvancementChiffre < 100 && s.EtatAvancementChiffre > 0).Count(),
                    r = e.Where(s => s.EtatAvancementChiffre == 100).Count(),
                    n = e.Where(s => s.EtatAvancementChiffre == 0).Count(),
                    // t = countR,
                    t = e.Count(),
                })
                .ToList()
                ;



            var organe0 = await q.Where(e => e.Organe != null).Include(e => e.Organe).ToListAsync();

            var organe = organe0
                .GroupBy(e => lng == "fr" ? e.Organe.Label : e.Organe.LabelAr)
                .Select(e => new
                {
                    name = e.Key,
                    p = e.Where(s => s.EtatAvancementChiffre < 100 && s.EtatAvancementChiffre > 0).Count(),
                    r = e.Where(s => s.EtatAvancementChiffre == 100).Count(),
                    n = e.Where(s => s.EtatAvancementChiffre == 0).Count(),
                    // t = countR,
                    t = e.Count(),
                })
                .ToList()
                ;

            var visite0 = await q.Where(e => e.Visite != null).Include(e => e.Visite).ToListAsync();

            var visite = visite0
                .GroupBy(e => lng == "fr" ? e.Visite.Mandat : e.Visite.MandatAr)
                .Select(e => new
                {
                    name = e.Key,
                    p = e.Where(s => s.EtatAvancementChiffre < 100 && s.EtatAvancementChiffre > 0).Count(),
                    r = e.Where(s => s.EtatAvancementChiffre == 100).Count(),
                    n = e.Where(s => s.EtatAvancementChiffre == 0).Count(),
                    // t = countR,
                    t = e.Count(),
                })
                .ToList()
                ;

            // var pays0 = await q.Include(e => e.Pays).ToListAsync();
            // var pays = pays0
            //     .Where(e => e.Pays != null)
            //     .GroupBy(e => lng == "fr" ? e.Pays.Nom : e.Pays.NomAr)
            //     .Select(e => new
            //     {
            //         name = e.Key,
            //         p = e.Where(e => e.EtatAvancementChiffre != 100).Sum(r => r.EtatAvancementChiffre) / e.Count(),
            //         r = e.Where(e => e.EtatAvancementChiffre == 100).Sum(r => r.EtatAvancementChiffre) / e.Count(),
            //         t = (double.Parse(e.Count().ToString()) / recommendationsCount) * 100,
            //     })
            //     .ToList()

            //     ;

            q = q.Where(e => model.Etat == "" ? true : e.Etat.Contains(model.Etat));
            var realise = await q.Where(e => e.EtatAvancementChiffre == 100).CountAsync();
            var nonRealise = await q.Where(e => e.EtatAvancementChiffre == 0).CountAsync();
            var enCours = await q.Where(e => e.EtatAvancementChiffre > 0 && e.EtatAvancementChiffre < 100).CountAsync();
            var count = await q.CountAsync();




            return Ok(new { mecanisme = await Calc(q), count = recommendationsCount, organe, visite, axe, epu, department, pays = 1, recommandationValues = new { realise, nonRealise, enCours, count } });
        }

        private async Task<object> Calc(IQueryable<Recommendation> q)
        {

            // int recommendationsCount = _context.Recommendations.Count();

            var l = await q.ToListAsync();
            l = l.GroupBy(e => e.CodeRecommendation).Select(e => e.First()).ToList();

            var t = l.Where(e => e.IdCycle != null).Count();
            var n = l.Where(e => e.IdCycle != null && e.EtatAvancementChiffre == 0).Count();
            var r = l.Where(e => e.IdCycle != null && e.EtatAvancementChiffre == 100).Count();
            var p = l.Where(e => e.IdCycle != null && e.EtatAvancementChiffre < 100 && e.EtatAvancementChiffre > 0).Count();

            var epu = new { n, r, p, t };

            t = l.Where(e => e.IdOrgane != null).Count();
            n = l.Where(e => e.IdOrgane != null && e.EtatAvancementChiffre == 0).Count();
            r = l.Where(e => e.IdOrgane != null && e.EtatAvancementChiffre == 100).Count();
            p = l.Where(e => e.IdOrgane != null && e.EtatAvancementChiffre < 100 && e.EtatAvancementChiffre > 0).Count();
            // var h = t == 0 ? 1 : t;
            // var h2 = 0/1;
            var ot = new { n, r, p, t };

            t = l.Where(e => e.IdVisite != null).Count();
            n = l.Where(e => e.IdVisite != null && e.EtatAvancementChiffre == 0).Count();
            r = l.Where(e => e.IdVisite != null && e.EtatAvancementChiffre == 100).Count();
            p = l.Where(e => e.IdVisite != null && e.EtatAvancementChiffre < 100 && e.EtatAvancementChiffre > 0).Count();

            var ps = new { n, r, p, t };

            return new { epu, ot, ps, count = 0 };

        }

        private async Task<object> Calc0(IQueryable<Recommendation> q)
        {

            var t = await q.Where(e => e.IdCycle != null).CountAsync();
            var n = await q.Where(e => e.IdCycle != null && e.EtatAvancementChiffre == 0).CountAsync();
            var r = await q.Where(e => e.IdCycle != null && e.EtatAvancementChiffre == 100).CountAsync();
            var p = await q.Where(e => e.IdCycle != null && e.EtatAvancementChiffre < 100 && e.EtatAvancementChiffre > 0).CountAsync();

            var epu = new { n, r, p, t };

            t = await q.Where(e => e.IdOrgane != null).CountAsync();
            n = await q.Where(e => e.IdOrgane != null && e.EtatAvancementChiffre == 0).CountAsync();
            r = await q.Where(e => e.IdOrgane != null && e.EtatAvancementChiffre == 100).CountAsync();
            p = await q.Where(e => e.IdOrgane != null && e.EtatAvancementChiffre < 100 && e.EtatAvancementChiffre > 0).CountAsync();
            // var h = t == 0 ? 1 : t;
            // var h2 = 0/1;
            var ot = new { n, r, p, t };

            t = await q.Where(e => e.IdVisite != null).CountAsync();
            n = await q.Where(e => e.IdVisite != null && e.EtatAvancementChiffre == 0).CountAsync();
            r = await q.Where(e => e.IdVisite != null && e.EtatAvancementChiffre == 100).CountAsync();
            p = await q.Where(e => e.IdVisite != null && e.EtatAvancementChiffre < 100 && e.EtatAvancementChiffre > 0).CountAsync();

            var ps = new { n, r, p, t };

            return new { epu, ot, ps, count = 0 };

        }

        //  private async Task<object> Calc(IQueryable<Recommendation> q)
        // {

        //     int recommendationsCount = _context.Recommendations.Count();

        //     var t = await q.Where(e => e.IdCycle != null).CountAsync();
        //     var p = t == 0 ? 0 : (await q.Where(e => e.IdCycle != null && e.EtatAvancementChiffre != 100).SumAsync(e => e.EtatAvancementChiffre));
        //     var r = t == 0 ? 0 : (await q.Where(e => e.IdCycle != null && e.EtatAvancementChiffre == 100).SumAsync(e => e.EtatAvancementChiffre));

        //     var epu = new { p = p / (t == 0 ? 1 : t), r = r / (t == 0 ? 1 : t), t = (double.Parse(t.ToString()) / recommendationsCount) * 100 };

        //     t = await q.Where(e => e.IdOrgane != null).CountAsync();
        //     p = t == 0 ? 0 : (await q.Where(e => e.IdOrgane != null && e.EtatAvancementChiffre != 100).SumAsync(e => e.EtatAvancementChiffre));
        //     r = t == 0 ? 0 : (await q.Where(e => e.IdOrgane != null && e.EtatAvancementChiffre == 100).SumAsync(e => e.EtatAvancementChiffre));
        //     // var h = t == 0 ? 1 : t;
        //     // var h2 = 0/1;
        //     var ot = new { p = p / (t == 0 ? 1 : t), r = r / (t == 0 ? 1 : t), t = (double.Parse(t.ToString()) / recommendationsCount) * 100 };

        //     t = await q.Where(e => e.IdVisite != null).CountAsync();
        //     p = t == 0 ? 0 : (await q.Where(e => e.IdVisite != null && e.EtatAvancementChiffre != 100).SumAsync(e => e.EtatAvancementChiffre));
        //     r = t == 0 ? 0 : (await q.Where(e => e.IdVisite != null && e.EtatAvancementChiffre == 100).SumAsync(e => e.EtatAvancementChiffre));

        //     var ps = new { p = p / (t == 0 ? 1 : t), r = r / (t == 0 ? 1 : t), t = (double.Parse(t.ToString()) / recommendationsCount) * 100 };

        //     return new { epu, ot, ps, count = recommendationsCount };

        // }


        [HttpGet]
        public async Task<IActionResult> StateMecanisme() // used
        {
            return Ok(await Calc(_context.Recommendations));
        }

        [HttpGet]
        public async Task<IActionResult> StateOrgane() // used
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();

            // int recommendationsCount = await _context.Recommendations.CountAsync();

            var q = _context.Recommendations.Where(e => e.Organe != null).Include(e => e.Organe);
            var list = await q.ToListAsync();
            // var count = await q.CountAsync();

            var list2 = list
                .GroupBy(e => lng == "fr" ? e.Organe.Label : e.Organe.LabelAr)
                .Select(e => new
                {
                    name = e.Key,
                    p = e.Where(s => s.EtatAvancementChiffre < 100 && s.EtatAvancementChiffre > 0).Count(),
                    r = e.Where(s => s.EtatAvancementChiffre == 100).Count(),
                    n = e.Where(s => s.EtatAvancementChiffre == 0).Count(),
                    // t = count,
                    t = e.Count(),
                })
                .ToList()
                ;

            return Ok(list2);
        }

        [HttpGet]
        public async Task<IActionResult> StateVisite() // used
        {
            string lng = Request.Headers["mylang"].FirstOrDefault();

            // int recommendationsCount = _context.Recommendations.Count();

            var q = _context.Recommendations.Where(e => e.Visite != null).Include(e => e.Visite);
            var list = await q.ToListAsync();
            // var count = await q.CountAsync();

            var list2 = list.GroupBy(e => lng == "fr" ? e.Visite.Mandat : e.Visite.MandatAr)
                .Select(e => new
                {
                    name = e.Key,
                    p = e.Where(s => s.EtatAvancementChiffre < 100 && s.EtatAvancementChiffre > 0).Count(),
                    r = e.Where(s => s.EtatAvancementChiffre == 100).Count(),
                    n = e.Where(s => s.EtatAvancementChiffre == 0).Count(),
                    // t = count,
                    t = e.Count(),
                })
                .ToList()
                ;

            return Ok(list2);
        }

        [HttpPost]
        public async Task<IActionResult> StateParamOrganisme(Model model)
        {
            var list = await _context.Recommendations
                .Where(e => model.IdCycle == 0 ? true : e.IdCycle == model.IdCycle)
                .Where(e => model.IdOrgane == 0 ? true : e.IdOrgane == model.IdOrgane)
                .Where(e => model.IdVisite == 0 ? true : e.IdVisite == model.IdVisite)
                .Where(e => model.IdAxe == 0 ? true : e.IdAxe == model.IdAxe)
                .Where(e => model.IdSousAxe == 0 ? true : e.IdSousAxe == model.IdSousAxe)
                .Where(e => model.IdOrganisme == 0 ? true : e.RecomOrgs.Any(r => r.IdOrganisme == model.IdOrganisme))
                // .GroupBy(e => e.IdAxe)
                .Select(e => new
                {
                    table = e.RecomOrgs.FirstOrDefault().Organisme.Label,
                    value = e.Axe.Recommendations.Count
                })
                .Distinct()
                .ToListAsync()
                ;


            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> StateRecommendationByMecanismeTaux()
        {
            int recommendationsCount = _context.Recommendations.Count();
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

            var list = new[] { new { table = "", value = 0.0 } }.ToList();

            list.Add(new { table = "Examen Périodique universel", value = (double.Parse(axe.ToString()) / recommendationsCount) * 100 });
            list.Add(new { table = "Organes de Traités", value = (double.Parse(organe.ToString()) / recommendationsCount) * 100 });
            list.Add(new { table = "Procédures spéciales", value = (double.Parse(visite.ToString()) / recommendationsCount) * 100 });

            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> stateEPU()
        {
            int recommendationsCount = _context.Recommendations.Count();

            var p = await _context.Recommendations
                    .Where(e => e.IdCycle != null)
                    .SumAsync(e => e.EtatAvancementChiffre)
                ;

            var t = await _context.Recommendations
                    .Where(e => e.IdCycle != null)
                    .CountAsync()
                ;

            return Ok(new { p = p / t, t = (double.Parse(t.ToString()) / recommendationsCount) * 100 });
        }

        [HttpGet]
        public async Task<IActionResult> stateOT()
        {
            int recommendationsCount = _context.Recommendations.Count();

            var p = await _context.Recommendations
                    .Where(e => e.IdOrgane != null)
                    .SumAsync(e => e.EtatAvancementChiffre)
                ;

            var t = await _context.Recommendations
                    .Where(e => e.IdOrgane != null)
                    .CountAsync()
                ;

            return Ok(new { p = p / t, t = (double.Parse(t.ToString()) / recommendationsCount) * 100 });
        }

        [HttpGet]
        public async Task<IActionResult> statePS()
        {
            int recommendationsCount = _context.Recommendations.Count();

            var p = await _context.Recommendations
                    .Where(e => e.IdVisite != null)
                    .SumAsync(e => e.EtatAvancementChiffre)
                ;

            var t = await _context.Recommendations
                    .Where(e => e.IdVisite != null)
                    .CountAsync()
                ;

            return Ok(new { p = p / t, t = (double.Parse(t.ToString()) / recommendationsCount) * 100 });
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

            list.Add(new { table = "Examen Périodique universel", value = axe });
            list.Add(new { table = "Organes de Traités", value = organe });
            list.Add(new { table = "Procédures spéciales", value = visite });


            return Ok(list);
        }


        // [HttpGet("{table}/{type}")]
        // public async Task<IActionResult> GenericByRecommendation(string table, string type) // used
        // {
        //     //https://stackoverflow.com/questions/57131550/why-cant-i-create-a-listt-of-anonymous-type-in-c
        //     string lng = Request.Headers["mylang"].FirstOrDefault();
        //     var list = new[] { new { table = "", value = 0.0 } }.ToList();
        //     int recommendationsCount = _context.Recommendations.Count();
        //     if (table == "axe")
        //     {
        //         list = await _context.Axes
        //             .Select(e => new
        //             {
        //                 table = lng == "fr" ? e.Abv : e.LabelAr,
        //                 value = type == "taux" ?
        //                     (double.Parse(e.Recommendations.Count().ToString()) / recommendationsCount) * 100 :
        //                     (type == "etat" ?
        //                         e.Recommendations.Where(s => s.EtatAvancementChiffre != 100).Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count() :
        //                         e.Recommendations.Where(s => s.EtatAvancementChiffre == 100).Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count()
        //                     ),
        //             })
        //             .Distinct()
        //             .ToListAsync()
        //         ;
        //     }
        //     else if (table == "organe")
        //     {
        //         list = await _context.Organes
        //             // .Select(e => new
        //             // {
        //             //     table = e.Abv,
        //             //     value = type == "count" ? (double.Parse(e.Recommendations.Count().ToString()) / recommendationsCount) * 100 : (e.Recommendations.Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count()),
        //             // })

        //             .Select(e => new
        //             {
        //                 table = lng == "fr" ? e.Abv : e.LabelAr,
        //                 value = type == "taux" ?
        //                     (double.Parse(e.Recommendations.Count().ToString()) / recommendationsCount) * 100 :
        //                     (type == "etat" ?
        //                         e.Recommendations.Where(s => s.EtatAvancementChiffre != 100).Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count() :
        //                         e.Recommendations.Where(s => s.EtatAvancementChiffre == 100).Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count()
        //                     ),
        //             })
        //             .Distinct()
        //             .ToListAsync()
        //         ;
        //     }
        //     else if (table == "visite")
        //     {
        //         list = _context.Visites
        //              // .Select(e => new
        //              // {
        //              //     table = e.Mandat,
        //              //     value = type == "count" ? (double.Parse(e.Recommendations.Count().ToString()) / recommendationsCount) * 100 : (e.Recommendations.Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count()),
        //              // })
        //              .Select(e => new
        //              {
        //                  table = lng == "fr" ? e.Mandat : e.MandatAr,
        //                  value = type == "taux" ?
        //                     (double.Parse(e.Recommendations.Count().ToString()) / recommendationsCount) * 100 :
        //                     (type == "etat" ?
        //                         e.Recommendations.Where(s => s.EtatAvancementChiffre != 100).Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count() :
        //                         e.Recommendations.Where(s => s.EtatAvancementChiffre == 100).Sum(r => r.EtatAvancementChiffre) / e.Recommendations.Count()
        //                     ),
        //              })
        //             .Distinct()
        //             .ToList()
        //         ;
        //     }

        //     return Ok(list);
        // }

        [HttpGet("{table}/{type}")]
        public async Task<IActionResult> GenericByRecommendation(string table, string type) // used 
        {
            //https://stackoverflow.com/questions/57131550/why-cant-i-create-a-listt-of-anonymous-type-in-c
            string lng = Request.Headers["mylang"].FirstOrDefault();
            var list = new[] { new { table = "", value = 0 } }.ToList();
            int recommendationsCount = 0;
            if (table == "axe")
            {
                recommendationsCount = await _context.Recommendations.Where(r => r.IdCycle != null).CountAsync();
                list = await _context.Axes.Where(e => e.Recommendations.Any(r => r.IdCycle != null))
                    .Select(e => new
                    {
                        table = lng == "fr" ? e.Abv : e.LabelAr,
                        value = e.Recommendations.Where(r => r.IdCycle != null).Count() * 100 / recommendationsCount,
                    })
                    .Distinct()
                    .ToListAsync()
                ;
            }
            else if (table == "organe")
            {
                recommendationsCount = await _context.Recommendations.Where(r => r.IdOrgane != null).CountAsync();
                list = await _context.Organes
                    .Select(e => new
                    {
                        table = lng == "fr" ? e.Abv : e.LabelAr,
                        value = e.Recommendations.Where(r => r.IdOrgane != null).Count() * 100 / recommendationsCount,
                    })
                    .Distinct()
                    .ToListAsync()
                ;
            }
            else if (table == "visite")
            {
                recommendationsCount = await _context.Recommendations.Where(r => r.IdVisite != null).CountAsync();
                list = _context.Visites
                     .Select(e => new
                     {
                         table = lng == "fr" ? e.Mandat : e.MandatAr,
                         value = e.Recommendations.Where(r => r.IdVisite != null).Count() * 100 / recommendationsCount,
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

        // [HttpPost]
        // public async Task<IActionResult> SearchAndGet2(Model model)
        // {
        //     int idUser = HttpContext.GetIdUser();
        //     int role = HttpContext.GetRoleUser();
        //     bool hasAcess = (role == 1 || role == 4) ? true : false;

        //     var query = _context.Recommendations
        //         // .Where(e => hasAcess ? true : (e.User.IdOrganisme == idOrganisme))
        //         .Where(e => model.IdOrganisme == 0 ? true : e.RecomOrgs.Any(o => o.IdOrganisme == model.IdOrganisme))
        //         .Where(e => model.Nom == "" ? true : e.Nom.ToLower().Contains(model.Nom.ToLower()))
        //         .Where(e => model.Etat == "" ? true : e.Etat.ToLower().Contains(model.Etat.ToLower()))
        //         .Where(e => model.IdPays == 0 ? true : e.IdPays == model.IdPays)
        //         .Where(e => model.IdAxe == 0 ? true : e.IdAxe == model.IdAxe)
        //         .Where(e => model.IdCycle == 0 ? true : e.IdCycle == model.IdCycle)
        //         .Where(e => model.IdSousAxe == 0 ? true : e.IdSousAxe == model.IdSousAxe)
        //         .Where(e => model.Mecanisme == "" ? true : e.Mecanisme == model.Mecanisme)
        //         .Where(e => model.IdVisite == 0 ? true : e.IdVisite == model.IdVisite)
        //         .Where(e => model.IdOrgane == 0 ? true : e.IdOrgane == model.IdOrgane)
        //     ;

        //     int count = 0;
        //     var list = new List<Recommendation>();
        //     if (model.IsAllEmpty())
        //     {
        //         count = await _context.Recommendations.CountAsync();

        //         list = await query.OrderByName<Recommendation>(model.SortBy, model.SortDir == "desc")
        //             .Skip(model.StartIndex)
        //             .Take(model.PageSize)
        //             // .Include(e => e.RecomOrgs)
        //             .Include(e => e.Axe)
        //             // .Include(e => e.Organe)
        //             // .Include(e => e.Visite)
        //             .Include(e => e.SousAxe)
        //             // .Select(e => new {
        //             //     id = e.Id,
        //             //     CodeRecommendation = e.CodeRecommendation,
        //             //     Nom = e.Nom,
        //             //     Etat = e.Etat,
        //             //     Mecanisme = e.Mecanisme,
        //             //     Axe = e.Axe,
        //             //     SousAxe = e.SousAxe,
        //             //     PieceJointe = e.PieceJointe,
        //             // })
        //             .ToListAsync();
        //         ;
        //     }
        //     else
        //     {
        //         count = await query.CountAsync();

        //         list = await query.OrderByName<Recommendation>(model.SortBy, model.SortDir == "desc")
        //             .Skip(model.StartIndex)
        //             .Take(model.PageSize)
        //             // .Include(e => e.RecomOrgs)
        //             .Include(e => e.Axe)
        //             // .Include(e => e.Organe)
        //             // .Include(e => e.Visite)
        //             .Include(e => e.SousAxe)
        //             .ToListAsync();
        //         ;
        //     }

        //     return Ok(new { list = list, count = count });
        // }



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
