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
    public static class JsonHandler
    {

        public static List<int> ToListInt(string jsonArrayOfInt) 
        {
            // Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            // Console.WriteLine(jsonArrayOfInt);
            // Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            if (jsonArrayOfInt == null)
            {
                return new List<int>();
            }

            if (!jsonArrayOfInt.Contains("["))
            {
                jsonArrayOfInt = $"[{jsonArrayOfInt}]";
            }

            var list = JsonConvert.DeserializeObject<List<int>>(jsonArrayOfInt);

            return list;
        }
    }
}