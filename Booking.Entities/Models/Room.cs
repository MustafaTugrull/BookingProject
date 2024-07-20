using Booking.Entities.Abstractions;

namespace Booking.Entities.Models
{
    public class Room : BaseEntity
    {
        public int RoomNumber { get; set; }
        public Guid HotelID { get; set; }
        public Guid TypeID { get; set; }
        public string Status { get; set; }
        public Hotel Hotel { get; set; }
        public RoomType RoomType { get; set; }
        public ICollection<Bookings> Bookings { get; set; }
    }
}
