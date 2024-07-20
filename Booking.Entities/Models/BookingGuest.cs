namespace Booking.Entities.Models
{
    public class BookingGuest 
    {
        public Guid BookingID { get; set; }
        public Bookings Booking { get; set; }
        public Guid GuestID { get; set; }
        public Guest Guest { get; set; }
    }
}
