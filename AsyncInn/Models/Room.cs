using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [EnumDataType(typeof(Layout))]
        public Layout Layout { get; set; }

        //Navigation
        public HotelRoom HotelRoom { get; set; } 
        public ICollection<RoomAmenities> RoomAmenities { get; set; }

    }

    public enum Layout
    {
        [Display(Name = "Studio")]
        Studio = 1,
        [Display(Name = "One Bedroom")]
        OneBedroom = 2,
        [Display(Name = "Two Bedroom")]
        TwoBedroom,
    }
}
