﻿// <auto-generated />
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsyncInn.Migrations
{
    [DbContext(typeof(AsyncInnDbContext))]
    partial class AsyncInnDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsyncInn.Models.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Phone"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Hot Tub"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Mini Bar"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Coffee"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Dog"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<int>("RoomTotal");

                    b.HasKey("ID");

                    b.ToTable("Hotel");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "1 Main Street",
                            Name = "Seattle",
                            Phone = "1234567890",
                            RoomTotal = 0
                        },
                        new
                        {
                            ID = 2,
                            Address = "1 Horse",
                            Name = "Boise",
                            Phone = "1234567890",
                            RoomTotal = 0
                        },
                        new
                        {
                            ID = 3,
                            Address = "1 Deeze Street",
                            Name = "Eugene",
                            Phone = "1234567890",
                            RoomTotal = 0
                        },
                        new
                        {
                            ID = 4,
                            Address = "100 Here Street",
                            Name = "Los Angeles",
                            Phone = "1234567890",
                            RoomTotal = 0
                        },
                        new
                        {
                            ID = 5,
                            Address = "1 Landing Street",
                            Name = "Moon",
                            Phone = "1234567890",
                            RoomTotal = 0
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelID");

                    b.Property<int>("RoomNumber");

                    b.Property<bool>("PetFriendly");

                    b.Property<decimal>("Rate");

                    b.Property<int>("RoomID");

                    b.HasKey("HotelID", "RoomNumber");

                    b.HasIndex("RoomID")
                        .IsUnique();

                    b.ToTable("HotelRoom");
                });

            modelBuilder.Entity("AsyncInn.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Layout");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Layout = 0,
                            Name = "StudioFirstFloor"
                        },
                        new
                        {
                            ID = 2,
                            Layout = 0,
                            Name = "StudioSecondFloor"
                        },
                        new
                        {
                            ID = 3,
                            Layout = 1,
                            Name = "OneBedroomFirstFloor"
                        },
                        new
                        {
                            ID = 4,
                            Layout = 1,
                            Name = "OneBedroomSecondFloor"
                        },
                        new
                        {
                            ID = 5,
                            Layout = 2,
                            Name = "TwoBedroomFirstFloor"
                        },
                        new
                        {
                            ID = 6,
                            Layout = 2,
                            Name = "TwoBedroomSecondFloor"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.Property<int>("AmenitiesID");

                    b.Property<int>("RoomID");

                    b.HasKey("AmenitiesID", "RoomID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.HasOne("AsyncInn.Models.Hotel", "Hotel")
                        .WithMany("HotelRoom")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithOne("HotelRoom")
                        .HasForeignKey("AsyncInn.Models.HotelRoom", "RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.HasOne("AsyncInn.Models.Amenities", "Amenities")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
