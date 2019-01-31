using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IRoom
    {
        //Create
        Task CreateRoom(Room room);
        //Read
        Task<Room> GetRoom(int? id);

        Task<IEnumerable<Room>> GetRooms();
        //Update
        void UpdateRoom(Room room);
        //Delete
        void DeleteRoom(int id);
    }
}
