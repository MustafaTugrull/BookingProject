using Booking.Entities.Abstractions;

namespace Booking.Entities.Models
{
    public class Staff : BaseEntity
    {
        public Guid HotelID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }
        public Hotel Hotel { get; set; }
    }
}
