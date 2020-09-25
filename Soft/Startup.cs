using Airport.Domain.AirlineCompany;
using Airport.Domain.Airport;
using Airport.Domain.AirportOfFlight;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.FlightsPassenger;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Infra;
using Airport.Infra.AirlineCompany;
using Airport.Infra.Airport;
using Airport.Infra.AirportOfFlight;
using Airport.Infra.Flight;
using Airport.Infra.FlightOfPassenger;
using Airport.Infra.FlightsPassenger;
using Airport.Infra.Luggage;
using Airport.Infra.Passenger;
using Airport.Soft.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Airport.Soft
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<AirportDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"))); 
            services.AddScoped<IAirlineCompaniesRepository, AirlineCompaniesRepository>();
            services.AddScoped<IAirportsRepository, AirportsRepository>();
            services.AddScoped<IAirportOfFlightsRepository, AirportOfFlightsRepository>();
            services.AddScoped<IFlightsRepository, FlightsRepository>();
            services.AddScoped<IFlightsPassengersRepository, FlightsPassengersRepository>();
            services.AddScoped<ILuggagesRepository, LuggagesRepository>();
            services.AddScoped<IPassengersRepository, PassengersRepository>();
            services.AddScoped<IFlightOfPassengersRepository, FlightOfPassengersRepository>();

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
