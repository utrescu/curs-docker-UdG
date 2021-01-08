using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Colors.Data;
using Colors.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Colors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            var databaseCreated = false;
            do
            {
                databaseCreated = CreateDbIfNotExists(host);
                if (!databaseCreated)
                {
                    Thread.Sleep(5000);
                }

            } while (!databaseCreated);

            host.Run();
        }

        private static bool CreateDbIfNotExists(IHost host)
        {

            System.Console.WriteLine("Provant de crear la base de dades");
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ColorContext>();

                    DbInitializer.Initialize(context);

                    return true;

                }

                catch (Exception ex)
                {
                    System.Console.WriteLine($"No s'ha pogut crear la base de dades {ex.Message}");
                    // var logger = services.GetRequiredService<ILogger<Program>>();
                    // logger.LogError(ex, "An error occurred creating the DB.");
                    return false;
                }
            }


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
