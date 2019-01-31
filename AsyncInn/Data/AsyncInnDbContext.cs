using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;

namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {

        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasKey(ce => new { ce.HotelID, ce.RoomNumber });
            modelBuilder.Entity<RoomAmenities>().HasKey(ce => new { ce.AmenitiesID, ce.RoomID });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "Seattle",
                    Address = "1 Main Street",
                    Phone = "1234567890"
                },
                new Hotel
                {
                    ID = 2,
                    Name = "Boise",
                    Address = "1 Horse",
                    Phone = "1234567890"
                },
                new Hotel
                {
                    ID = 3,
                    Name = "Eugene",
                    Address = "1 Deeze Street",
                    Phone = "1234567890"
                },
                new Hotel
                {
                    ID = 4,
                    Name = "Los Angeles",
                    Address = "100 Here Street",
                    Phone = "1234567890"
                },
                new Hotel
                {
                    ID = 5,
                    Name = "Moon",
                    Address = "1 Landing Street",
                    Phone = "1234567890"
                }
                );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Name = "StudioFirstFloor",
                    Layout = Layout.Studio,
                },
                new Room
                {
                    ID = 2,
                    Name = "StudioSecondFloor",
                    Layout = Layout.Studio,
                },
                new Room
                {
                    ID = 3,
                    Name = "OneBedroomFirstFloor",
                    Layout = Layout.OneBedroom,
                },
                new Room
                {
                    ID = 4,
                    Name = "OneBedroomSecondFloor",
                    Layout = Layout.OneBedroom,
                },
                new Room
                {
                    ID = 5,
                    Name = "TwoBedroomFirstFloor",
                    Layout = Layout.TwoBedroom,
                },
                new Room
                {
                    ID = 6,
                    Name = "TwoBedroomSecondFloor",
                    Layout = Layout.TwoBedroom,
                }
                );

            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Name = "Phone",
                },
                new Amenities
                {
                     ID = 2,
                     Name = "Hot Tub",
                },
                new Amenities
                {
                     ID = 3,
                     Name = "Mini Bar",
                },
                new Amenities
                {
                    ID = 4,
                    Name = "Coffee",
                },
                new Amenities
                {
                    ID = 5,
                    Name = "Dog"
                }

                );
        }

        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelRoom> HotelRoom { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
    }
}
