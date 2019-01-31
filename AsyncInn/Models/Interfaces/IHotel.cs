using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotel
    {
        //Create
        Task CreateHotel(Hotel hotel);
        //Read - int? is a nullable value
        Task<Hotel> GetHotel(int? id);

        Task<IEnumerable<Hotel>> GetHotels();
        //Update
        void UpdateHotel(Hotel hotel);
        //Delete
        void DeleteHotel(int id);
    }
}
