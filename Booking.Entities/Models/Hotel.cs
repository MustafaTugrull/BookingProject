﻿using Booking.Entities.Abstractions;

namespace Booking.Entities.Models
{
    public class Hotel : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Stars { get; set; }
        public TimeSpan CheckinTime { get; set; }
        public TimeSpan CheckoutTime { get; set; }
        public ICollection<Staff> Staffs { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}