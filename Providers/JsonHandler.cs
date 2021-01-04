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

namespace Admin5.Providers
{
    public static class JsonHandler
    {
        public static string FirstCharToUpper(string str)
        {
            return str?.First().ToString().ToUpper() + str?.Substring(1);
        }

        public static List<int> ToListInt(string jsonArrayOfInt) {

            if (!jsonArrayOfInt.Contains("["))
            {
                jsonArrayOfInt = $"[{jsonArrayOfInt}]";
            }

            return JsonConvert.DeserializeObject<List<int>>(jsonArrayOfInt);
        }
        

    }
}