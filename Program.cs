using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MySite_MVC
{
    public class Program
    {
        //private static readonly string dbHost = Environment.GetEnvironmentVariable("DB_HOST");
        //private static readonly string dbUser = Environment.GetEnvironmentVariable("DB_USER");
        //private static readonly string dbPass = Environment.GetEnvironmentVariable("DB_PASS");
        //private static readonly string dbName = Environment.GetEnvironmentVariable("DB_NAME");

        //public static readonly string ConnectionString = $"Host={dbHost};Username={dbUser};Password={dbPass};Database={dbName}";
        public static readonly string ConnectionString = "Host=localhost;Username=postgres;Password=admin;Database=db_PA";

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
