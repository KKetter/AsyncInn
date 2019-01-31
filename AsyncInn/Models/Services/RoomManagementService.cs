using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class RoomManagementService : IRoom
    {
        private AsyncInnDbContext _context { get; }

        //bring in database
        public RoomManagementService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task CreateRoom(Room room)
        {
            await _context.Room.AddAsync(room);
            await _context.SaveChangesAsync();
        }

        public async Task<Room> GetRoom(int? id)
        {
            return await _context.Room.FirstOrDefaultAsync(Room => Room.ID == id);
        }

        public async Task<IEnumerable<Room>> GetRooms()
        {
            return await _context.Room.ToListAsync();
        }

        public void UpdateRoom(Room room)
        {
            _context.Room.AddAsync(room);
            _context.SaveChangesAsync();
        }

        public void DeleteRoom(int id)
        {
            Room room = _context.Room.FirstOrDefault(s => s.ID == id);
            _context.Room.Remove(room);
            _context.SaveChanges();

        }
    }
}
