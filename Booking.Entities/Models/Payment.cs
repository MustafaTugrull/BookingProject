using Booking.Entities.Abstractions;

namespace Booking.Entities.Models
{
    public class Payment : BaseEntity
    {
        public Guid BookingID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public Bookings Booking { get; set; }
    }
}
