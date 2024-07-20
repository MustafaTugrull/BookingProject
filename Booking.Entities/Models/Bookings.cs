using Booking.Entities.Abstractions;

namespace Booking.Entities.Models
{
    public class Bookings : BaseEntity
    {
        public Guid RoomID { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public Room Room { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<BookingGuest> BookingGuests { get; set; }
    }
}
