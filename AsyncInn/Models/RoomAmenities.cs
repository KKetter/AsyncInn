using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class RoomAmenities
    {
        [Required]
        [ForeignKey("Amenities")]
        public int AmenitiesID { get; set; }
        [Required]
        [ForeignKey("Room")]
        public int RoomID { get; set; }

        //Navigation
        public Amenities Amenities { get; set; }
        public Room Room { get; set; }
    }
}
