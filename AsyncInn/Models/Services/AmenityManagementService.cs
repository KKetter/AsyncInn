using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class AmenityManagementService : IAmenities
    {
        private AsyncInnDbContext _context { get; }

        public AmenityManagementService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task CreateAmenity(Amenities amenity)
        {
            await _context.Amenities.AddAsync(amenity);
            await _context.SaveChangesAsync();
        }

        public void DeleteAmenity(int id)
        {
            Amenities amenity = _context.Amenities.FirstOrDefault(s => s.ID == id);
            _context.Amenities.Remove(amenity);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Amenities>> GetAmenities()
        {
            return await _context.Amenities.ToListAsync();
        }

        public async Task<Amenities> GetAmenity(int? id)
        {
            return await _context.Amenities.FirstOrDefaultAsync(Amenities => Amenities.ID == id);
        }

        public void UpdateAmenity(Amenities amenities)
        {
            _context.Amenities.AddAsync(amenities);
            _context.SaveChangesAsync();
        }
    }
}
