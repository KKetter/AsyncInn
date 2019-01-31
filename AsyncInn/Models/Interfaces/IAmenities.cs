using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenities
    {
        //Create
        Task CreateAmenity(Amenities amenity);
        //Read
        Task<Amenities> GetAmenity(int? id);

        Task<IEnumerable<Amenities>> GetAmenities();
        //Update
        void UpdateAmenity(Amenities amenities);
        //Delete
        void DeleteAmenity(int id);
    }
}
