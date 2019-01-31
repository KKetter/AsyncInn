using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotel
    {
        //Create
        Task CreateHotel(Hotel hotel);
        //Read
        Task<Hotel> GetHotel(int? id);

        Task<IEnumerable<Hotel>> GetHotels();
        //Update
        void UpdateHotel(Hotel hotel);
        //Delete
        void DeleteHotel(int id);
    }
}
