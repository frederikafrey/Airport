using Airport.Data.AirlinesCompany;
using Airport.Data.Airport;
using Airport.Data.AirportsFlight;
using Airport.Data.Flight;
using Airport.Data.FlightsPassenger;
using Airport.Data.Luggage;
using Airport.Data.Passenger;
using Airport.Data.PassengersFlight;
using Microsoft.EntityFrameworkCore;

namespace Airport.Infra
{
    public class AirportDbContext : DbContext
    {
        public AirportDbContext(DbContextOptions<AirportDbContext> options) : base(options) { }

        public DbSet<AirlinesCompanyData> AirlinesCompanies { get; set; }
        public DbSet<AirportData> Airports { get; set; }
        public DbSet<AirportsFlightData> AirportsFlights { get; set; }
        public DbSet<FlightData> Flights { get; set; }
        public DbSet<FlightsPassengerData> FlightsPassengers { get; set; }
        public DbSet<LuggageData> Luggages { get; set; }
        public DbSet<PassengerData> Passengers { get; set; }
        public DbSet<PassengersFlightData> PassengersFlights { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }

        public static void InitializeTables(ModelBuilder builder)
        {
            if (builder is null) return;
            builder.Entity<AirlinesCompanyData>().ToTable(nameof(AirlinesCompanies));
            builder.Entity<AirportData>().ToTable(nameof(Airports));
            builder.Entity<AirportsFlightData>().ToTable(nameof(AirportsFlights)).HasKey(x => new { x.FlightId, x.AirportId });
            builder.Entity<FlightData>().ToTable(nameof(Flights));
            builder.Entity<FlightsPassengerData>().ToTable(nameof(FlightsPassengers)).HasKey(x => new { x.PassengersFlightId, x.FlightId });
            builder.Entity<LuggageData>().ToTable(nameof(Luggages));
            builder.Entity<PassengerData>().ToTable(nameof(Passengers));
            builder.Entity<PassengersFlightData>().ToTable(nameof(PassengersFlights)).HasKey(x => new { x.FlightsPassengerId, x.PassengerId });

        }
    }
}