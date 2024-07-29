using Booking.Entities.Abstractions;
using System.Net;
using System.Xml.Linq;

namespace Booking.Entities.Models
{
    public class Room : BaseEntity
    {
        public int RoomNumber { get; set; }
        public string FullName => $"{RoomNumber} - {Hotel.Name} -{RoomType.Name} ";
        public Guid HotelID { get; set; }
        public Guid RoomTypeID { get; set; }
        public bool Status { get; set; }
        public Hotel Hotel { get; set; }
        public RoomType RoomType { get; set; }
        public ICollection<Bookings> Bookings { get; set; }
        public override string ToString()
        {
            return $"{RoomNumber}";
        }
    }
}
