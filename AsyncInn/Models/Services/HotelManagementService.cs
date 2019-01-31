using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class HotelManagementService : IHotel
    {
        private AsyncInnDbContext _context { get; }

        //bring in database
        public HotelManagementService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task CreateHotel(Hotel hotel)
        {
            await _context.Hotel.AddAsync(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<Hotel> GetHotel(int? id)
        {
            return await _context.Hotel.FirstOrDefaultAsync(hotel => hotel.ID == id);
        }

        public async Task<IEnumerable<Hotel>> GetHotels()
        {
            return await _context.Hotel.ToListAsync();
        }

        public void UpdateHotel(Hotel hotel)
        {
            _context.Hotel.Update(hotel);
            _context.SaveChanges();

        }

        public void DeleteHotel(int id)
        {
            Hotel hotel = _context.Hotel.FirstOrDefault(s => s.ID == id);
            _context.Hotel.Remove(hotel);
            _context.SaveChanges();
        }
    }
}
