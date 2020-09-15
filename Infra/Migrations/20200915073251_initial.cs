using Microsoft.EntityFrameworkCore.Migrations;

namespace Airport.Infra.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirlinesCompanies",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirlinesCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirportsFlights",
                columns: table => new
                {
                    FlightId = table.Column<string>(nullable: false),
                    AirportId = table.Column<string>(nullable: false),
                    Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirportsFlights", x => new { x.FlightId, x.AirportId });
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    StartingPointId = table.Column<string>(nullable: true),
                    FinalPointId = table.Column<string>(nullable: true),
                    StartTime = table.Column<int>(nullable: false),
                    ArrivingTime = table.Column<int>(nullable: false),
                    Occupancy = table.Column<int>(nullable: false),
                    Company = table.Column<string>(nullable: true),
                    PlaneId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlightsPassengers",
                columns: table => new
                {
                    FlightId = table.Column<string>(nullable: false),
                    PassengersFlightId = table.Column<string>(nullable: false),
                    Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightsPassengers", x => new { x.PassengersFlightId, x.FlightId });
                });

            migrationBuilder.CreateTable(
                name: "Luggages",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PassengerId = table.Column<string>(nullable: true),
                    Dimensions = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luggages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassengersFlights",
                columns: table => new
                {
                    PassengerId = table.Column<string>(nullable: false),
                    FlightsPassengerId = table.Column<string>(nullable: false),
                    Id = table.Column<string>(nullable: true),
                    StartDestinationId = table.Column<string>(nullable: true),
                    FinalDestinationId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengersFlights", x => new { x.FlightsPassengerId, x.PassengerId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirlinesCompanies");

            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "AirportsFlights");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "FlightsPassengers");

            migrationBuilder.DropTable(
                name: "Luggages");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "PassengersFlights");
        }
    }
}
