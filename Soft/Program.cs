using Airport.Domain.Common;
using Airport.Infra;
using Airport.Infra.AirlineCompany;
using Airport.Infra.Airport;
using Airport.Infra.Luggage;
using Airport.Infra.StopOver;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Airport.Soft
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbQuantity = services.GetRequiredService<AirportDbContext>();
                AirportsDbInitializer.Initialize(dbQuantity);
                StopOversDbInitializer.Initialize(dbQuantity);
                AirlineCompaniesDbInitializer.Initialize(dbQuantity);
                DimensionsDbInitializer.Initialize(dbQuantity);
            }
            GetRepository.SetServiceProvider(host.Services);
            host.Run();
        }
            public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
