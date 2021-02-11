using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.StaticFiles;
using Newtonsoft.Json;
using System;

namespace Admin5.Providers
{
        public static class Etat
        {
            public static string one = "Réalisé";
            public static string two = "En cours";
            public static string three = "Recommendation continue";
            public static string four = "Non réalisé";
        }
}