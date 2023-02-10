﻿// <auto-generated />
using System;
using CityBreaks.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CityBreaks.Migrations
{
    [DbContext(typeof(CityBreaksContext))]
    partial class CityBreaksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.13");

            modelBuilder.Entity("CityBreaks.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Image");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 5,
                            Name = "Amsterdam",
                            Photo = "amsterdam.jpg"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 7,
                            Name = "Barcelona",
                            Photo = "barcelona.jpg"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 4,
                            Name = "Berlin",
                            Photo = "berlin.jpg"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 2,
                            Name = "Copenhagen",
                            Photo = "copenhagen.jpg"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 1,
                            Name = "Dubrovnik",
                            Photo = "dubrovnik.jpg"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 8,
                            Name = "Edinburgh",
                            Photo = "edinburgh.jpg"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 8,
                            Name = "London",
                            Photo = "london.jpg"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 7,
                            Name = "Madrid",
                            Photo = "madrid.jpg"
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 9,
                            Name = "New York",
                            Photo = "new-york.jpg"
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 3,
                            Name = "Paris",
                            Photo = "paris.jpg"
                        },
                        new
                        {
                            Id = 11,
                            CountryId = 6,
                            Name = "Rome",
                            Photo = "rome.jpg"
                        },
                        new
                        {
                            Id = 12,
                            CountryId = 6,
                            Name = "Venice",
                            Photo = "venice.jpg"
                        });
                });

            modelBuilder.Entity("CityBreaks.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT")
                        .HasColumnName("ISO 3166 code");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryCode = "hr",
                            CountryName = "Croatia"
                        },
                        new
                        {
                            Id = 2,
                            CountryCode = "dk",
                            CountryName = "Denmark"
                        },
                        new
                        {
                            Id = 3,
                            CountryCode = "fr",
                            CountryName = "France"
                        },
                        new
                        {
                            Id = 4,
                            CountryCode = "de",
                            CountryName = "Germany"
                        },
                        new
                        {
                            Id = 5,
                            CountryCode = "nl",
                            CountryName = "Holland"
                        },
                        new
                        {
                            Id = 6,
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 7,
                            CountryCode = "es",
                            CountryName = "Spain"
                        },
                        new
                        {
                            Id = 8,
                            CountryCode = "gb",
                            CountryName = "United Kingdom"
                        },
                        new
                        {
                            Id = 9,
                            CountryCode = "us",
                            CountryName = "United States"
                        });
                });

            modelBuilder.Entity("CityBreaks.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AvailableFrom")
                        .HasColumnType("TEXT");

                    b.Property<int>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("DayRate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxNumberOfGuests")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("SmokingPermitted")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rue de Reynard",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 10,
                            DayRate = 81.00m,
                            MaxNumberOfGuests = 1,
                            Name = "Hotel Paris",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 2,
                            Address = "Vester Volgade",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 4,
                            DayRate = 75.00m,
                            MaxNumberOfGuests = 1,
                            Name = "Andersen Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 3,
                            Address = "The Strand",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 7,
                            DayRate = 72.00m,
                            MaxNumberOfGuests = 2,
                            Name = "Ratz Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 4,
                            Address = "Carrer Dels Talles",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 2,
                            DayRate = 42.00m,
                            MaxNumberOfGuests = 2,
                            Name = "Gothic Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 5,
                            Address = "Kurfürstenstraße",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 3,
                            DayRate = 68.00m,
                            MaxNumberOfGuests = 3,
                            Name = "Beetle Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 6,
                            Address = "Calle dei Mercanti",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 12,
                            DayRate = 50.00m,
                            MaxNumberOfGuests = 3,
                            Name = "Merchant's Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 7,
                            Address = "Calle del Amparo",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 8,
                            DayRate = 87.00m,
                            MaxNumberOfGuests = 2,
                            Name = "Tapas Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 8,
                            Address = "Cowgate",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 6,
                            DayRate = 81.00m,
                            MaxNumberOfGuests = 1,
                            Name = "Halfpenny Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 9,
                            Address = "Magstraede",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 4,
                            DayRate = 60.00m,
                            MaxNumberOfGuests = 3,
                            Name = "Mermaid Inn",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 10,
                            Address = "Beursstraat",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 1,
                            DayRate = 72.00m,
                            MaxNumberOfGuests = 2,
                            Name = "Dam Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 11,
                            Address = "Calle Oche",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 12,
                            DayRate = 70.00m,
                            MaxNumberOfGuests = 3,
                            Name = "Gondalo Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 12,
                            Address = "7th Avenue",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 9,
                            DayRate = 52.00m,
                            MaxNumberOfGuests = 4,
                            Name = "New Yorker",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 13,
                            Address = "Hlidina ul.",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 5,
                            DayRate = 66.00m,
                            MaxNumberOfGuests = 2,
                            Name = "Hotel Kalisi",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 14,
                            Address = "Svætegarde",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 4,
                            DayRate = 66.00m,
                            MaxNumberOfGuests = 1,
                            Name = "Schlaafhaus",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 15,
                            Address = "Carrer de Ferren",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 2,
                            DayRate = 68.00m,
                            MaxNumberOfGuests = 1,
                            Name = "The Schafer",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 16,
                            Address = "Pohlstraße",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 3,
                            DayRate = 58.00m,
                            MaxNumberOfGuests = 1,
                            Name = "Beliner Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 17,
                            Address = "Đorđićeva ul.",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 5,
                            DayRate = 50.00m,
                            MaxNumberOfGuests = 4,
                            Name = "7",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 18,
                            Address = "Calle de la Fe",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 8,
                            DayRate = 86.00m,
                            MaxNumberOfGuests = 3,
                            Name = "Ceveceria Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 19,
                            Address = "Charing Cross Road",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 7,
                            DayRate = 89.00m,
                            MaxNumberOfGuests = 2,
                            Name = "The Sleepover",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 20,
                            Address = "Nieuwendijk",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 1,
                            DayRate = 69.00m,
                            MaxNumberOfGuests = 1,
                            Name = "14",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 21,
                            Address = "Sankt Annæ Pl",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 4,
                            DayRate = 41.00m,
                            MaxNumberOfGuests = 3,
                            Name = "Nummer Ni",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 22,
                            Address = "Wolvenstraate",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 1,
                            DayRate = 86.00m,
                            MaxNumberOfGuests = 1,
                            Name = "33",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 23,
                            Address = "Grassmarket",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 6,
                            DayRate = 86.00m,
                            MaxNumberOfGuests = 2,
                            Name = "The Drop Inn Well",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 24,
                            Address = "Christianshavn Voldgade",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 4,
                            DayRate = 50.00m,
                            MaxNumberOfGuests = 3,
                            Name = "32",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 25,
                            Address = "Broadway",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 9,
                            DayRate = 52.00m,
                            MaxNumberOfGuests = 2,
                            Name = "The Theatre Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 26,
                            Address = "Castle Hill",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 6,
                            DayRate = 82.00m,
                            MaxNumberOfGuests = 2,
                            Name = "Bide A Wee",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 27,
                            Address = "Nørre Allé",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 4,
                            DayRate = 59.00m,
                            MaxNumberOfGuests = 1,
                            Name = "16",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 28,
                            Address = "Oudezijds Voorburgwal",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 1,
                            DayRate = 69.00m,
                            MaxNumberOfGuests = 3,
                            Name = "The Lion Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 29,
                            Address = "Fraser Street",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 6,
                            DayRate = 89.00m,
                            MaxNumberOfGuests = 2,
                            Name = "15",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 30,
                            Address = "W 30th St",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 9,
                            DayRate = 63.00m,
                            MaxNumberOfGuests = 1,
                            Name = "1742",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 31,
                            Address = "Hans Kirks Wej",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 4,
                            DayRate = 53.00m,
                            MaxNumberOfGuests = 2,
                            Name = "6",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 32,
                            Address = "Calle Ponti di Venici",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 12,
                            DayRate = 69.00m,
                            MaxNumberOfGuests = 4,
                            Name = "17",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 33,
                            Address = "Princes Street",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 6,
                            DayRate = 43.00m,
                            MaxNumberOfGuests = 1,
                            Name = "The Majestic",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 34,
                            Address = "Calle del Bosce",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 8,
                            DayRate = 71.00m,
                            MaxNumberOfGuests = 4,
                            Name = "Hotel Mardi Gras",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 35,
                            Address = "George Street",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 6,
                            DayRate = 56.00m,
                            MaxNumberOfGuests = 1,
                            Name = "Atlantic Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 36,
                            Address = "Damstraat",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 1,
                            DayRate = 46.00m,
                            MaxNumberOfGuests = 4,
                            Name = "Van Dijk Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 37,
                            Address = "Madison Avenue",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 9,
                            DayRate = 89.00m,
                            MaxNumberOfGuests = 1,
                            Name = "The Presidents Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 38,
                            Address = "Via Laietana",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 2,
                            DayRate = 88.00m,
                            MaxNumberOfGuests = 3,
                            Name = "Hotel Colonial",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 39,
                            Address = "Bülowstraße",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 3,
                            DayRate = 87.00m,
                            MaxNumberOfGuests = 2,
                            Name = "Saigon Night",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 40,
                            Address = "Queen Street",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 6,
                            DayRate = 81.00m,
                            MaxNumberOfGuests = 3,
                            Name = "The Royal",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 41,
                            Address = "Calle de Mezzo",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 12,
                            DayRate = 58.00m,
                            MaxNumberOfGuests = 3,
                            Name = "Hotel Soprano",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 42,
                            Address = "St Andrew Square",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 6,
                            DayRate = 44.00m,
                            MaxNumberOfGuests = 1,
                            Name = "The Cudogan",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 43,
                            Address = "Via Canale",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 12,
                            DayRate = 60.00m,
                            MaxNumberOfGuests = 3,
                            Name = "Hotel Antonio",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 44,
                            Address = "Via Barberini",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 11,
                            DayRate = 53.00m,
                            MaxNumberOfGuests = 4,
                            Name = "Hotel Ponti",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 45,
                            Address = "Rue Visconti",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 10,
                            DayRate = 53.00m,
                            MaxNumberOfGuests = 3,
                            Name = "Hotel Seine",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 46,
                            Address = "6th Ave",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 9,
                            DayRate = 65.00m,
                            MaxNumberOfGuests = 3,
                            Name = "452",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 47,
                            Address = "Favergade",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 4,
                            DayRate = 60.00m,
                            MaxNumberOfGuests = 2,
                            Name = "City Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 48,
                            Address = "Via della Corozza",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 11,
                            DayRate = 89.00m,
                            MaxNumberOfGuests = 1,
                            Name = "Bottino Hotel",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 49,
                            Address = "South Bridge",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 6,
                            DayRate = 73.00m,
                            MaxNumberOfGuests = 1,
                            Name = "124",
                            SmokingPermitted = false
                        },
                        new
                        {
                            Id = 50,
                            Address = "Lavendelstræde",
                            AvailableFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 4,
                            DayRate = 75.00m,
                            MaxNumberOfGuests = 4,
                            Name = "Det Lille",
                            SmokingPermitted = false
                        });
                });

            modelBuilder.Entity("CityBreaks.Models.City", b =>
                {
                    b.HasOne("CityBreaks.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("CityBreaks.Models.Property", b =>
                {
                    b.HasOne("CityBreaks.Models.City", "City")
                        .WithMany("Properties")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("CityBreaks.Models.City", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("CityBreaks.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
