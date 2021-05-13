using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.AppStart
{
    public class AppSettings
    {
        public struct Database
        {
            public static string CONNECTION_STRING { get; set; }
        }

        public static void Initialize(IConfiguration _configuration)
        {
            Database.CONNECTION_STRING = _configuration.GetSection("Database:ConnectionString").Value;
        }
    }
}
