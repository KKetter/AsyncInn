using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelRoom
    {
        [Key]
        public int HotelID { get; set; }
        
        public int RoomNumber { get; set; }
        [ForeignKey("Room")]
        public int RoomID { get; set; }
        public decimal Rate { get; set; }
        public bool PetFriendly { get; set; }

        //Navigation
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }

    }
}
