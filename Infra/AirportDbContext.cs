using Airport.Data.AirlineCompany;
using Airport.Data.Airport;
using Airport.Data.Flight;
using Airport.Data.FlightOfPassenger;
using Airport.Data.Luggage;
using Airport.Data.Passenger;
using Airport.Data.StopOver;
using Microsoft.EntityFrameworkCore;

namespace Airport.Infra
{
    public class AirportDbContext : DbContext
    {
        public AirportDbContext(){}
        public AirportDbContext(DbContextOptions<AirportDbContext> options) : base(options) { }

        public DbSet<AirlineCompanyData> AirlineCompanies { get; set; }
        public DbSet<AirportData> Airports { get; set; }
        public DbSet<FlightData> Flights { get; set; }
        public DbSet<StopOverData> StopOvers { get; set; }
        public DbSet<LuggageData> Luggages { get; set; }
        public DbSet<PassengerData> Passengers { get; set; }
        public DbSet<FlightOfPassengerData> FlightOfPassengers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }

        public static void InitializeTables(ModelBuilder builder)
        {
            if (builder is null) return;
            builder.Entity<AirlineCompanyData>().ToTable(nameof(AirlineCompanies));
            builder.Entity<AirportData>().ToTable(nameof(Airports));
            builder.Entity<FlightData>().ToTable(nameof(Flights));
            builder.Entity<StopOverData>().ToTable(nameof(StopOvers)).HasKey(x => new {x.FlightOfPassengerId, x.FlightId });
            builder.Entity<LuggageData>().ToTable(nameof(Luggages));
            builder.Entity<PassengerData>().ToTable(nameof(Passengers));
            builder.Entity<FlightOfPassengerData>().ToTable(nameof(FlightOfPassengers)).HasKey(x => new { x.PassengerId, x.FlightId, x.LuggageId});
        }
    }
}