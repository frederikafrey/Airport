﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Airport.Infra.Migrations
{
    [DbContext(typeof(AirportDbContext))]
    partial class AirportDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Airport.Data.AirlinesCompany.AirlinesCompanyData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AirlinesCompanies");
                });

            modelBuilder.Entity("Airport.Data.Airport.AirportData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Airports");
                });

            modelBuilder.Entity("Airport.Data.AirportsFlight.AirportsFlightData", b =>
                {
                    b.Property<string>("FlightId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AirportId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FlightId", "AirportId");

                    b.ToTable("AirportsFlights");
                });

            modelBuilder.Entity("Airport.Data.Flight.FlightData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ArrivingTime")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinalPointId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<string>("PlaneId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartTime")
                        .HasColumnType("int");

                    b.Property<string>("StartingPointId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("Airport.Data.FlightsPassenger.FlightsPassengerData", b =>
                {
                    b.Property<string>("PassengersFlightId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FlightId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PassengersFlightId", "FlightId");

                    b.ToTable("FlightsPassengers");
                });

            modelBuilder.Entity("Airport.Data.Luggage.LuggageData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Dimensions")
                        .HasColumnType("int");

                    b.Property<string>("PassengerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Luggages");
                });

            modelBuilder.Entity("Airport.Data.Passenger.PassengerData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("Airport.Data.PassengersFlight.PassengersFlightData", b =>
                {
                    b.Property<string>("FlightsPassengerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PassengerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FinalDestinationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDestinationId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FlightsPassengerId", "PassengerId");

                    b.ToTable("PassengersFlights");
                });
#pragma warning restore 612, 618
        }
    }
}