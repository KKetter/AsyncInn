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
        }

        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelRoom> HotelRoom { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
    }
}
