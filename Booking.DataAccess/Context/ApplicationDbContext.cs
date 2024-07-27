using Booking.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<BookingGuest> BookingGuests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-AO5K0VF;Initial Catalog=Hotels;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Guest>().HasData(
        new Guest
        {
            Id = Guid.NewGuid(),
            FirstName = "John",
            LastName = "Doe",
            DateOfBirth = new DateTime(1980, 1, 1),
            Address = "123 Main St",
            Phone = "123-456-7890",
            Email = "john.doe@example.com",
            TCKN = "12345678901",
            IsActive = true,
            CreatedDate = DateTime.UtcNow
        },
        new Guest
        {
            Id = Guid.NewGuid(),
            FirstName = "Jane",
            LastName = "Doe",
            DateOfBirth = new DateTime(1985, 5, 15),
            Address = "456 Elm St",
            Phone = "987-654-3210",
            Email = "jane.doe@example.com",
            TCKN = "10987654321",
            IsActive = true,
            CreatedDate = DateTime.UtcNow
        });

            modelBuilder.Entity<Hotel>().HasData(
        new Hotel
        {
            Id = Guid.NewGuid(),
            Name = "Grand Hotel",
            Address = "789 Oak St",
            Phone = "555-123-4567",
            Email = "contact@grandhotel.com",
            Stars = 5,
            CheckinTime = new TimeSpan(15, 0, 0),
            CheckoutTime = new TimeSpan(11, 0, 0),
            IsActive = true,
            CreatedDate = DateTime.UtcNow
        });

            modelBuilder.Entity<RoomType>().HasData(
        new RoomType
        {
            Id = Guid.NewGuid(),
            Name = "Deluxe Suite",
            Description = "A luxurious suite with a king-sized bed and ocean view.",
            PricePerNight = 250.00m,
            Capacity = 2,
            IsActive = true,
            CreatedDate = DateTime.UtcNow
        },
        new RoomType
        {
            Id = Guid.NewGuid(),
            Name = "Standard Room",
            Description = "A comfortable room with all standard amenities.",
            PricePerNight = 100.00m,
            Capacity = 2,
            IsActive = true,
            CreatedDate = DateTime.UtcNow
        });

            //modelBuilder.Entity<Room>()
            //    .HasKey(r => new { r.RoomNumber, r.HotelID });

            //modelBuilder.Entity<Staff>()
            //    .HasOne(s => s.Hotel)
            //    .WithMany(h => h.Staffs)
            //    .HasForeignKey(s => s.HotelID);

            //modelBuilder.Entity<Room>()
            //    .HasOne(r => r.Hotel)
            //    .WithMany(h => h.Rooms)
            //    .HasForeignKey(r => r.HotelID);

            //modelBuilder.Entity<Room>()
            //    .HasOne(r => r.RoomType)
            //    .WithMany(rt => rt.Rooms)
            //    .HasForeignKey(r => r.TypeID);

            //modelBuilder.Entity<Bookings>()
            //    .HasOne(b => b.Room)
            //    .WithMany(r => r.Bookings)
            //    .HasForeignKey(b => new { b.RoomNumber, b.HotelID });

            //modelBuilder.Entity<Payment>()
            //    .HasOne(p => p.Booking)
            //    .WithMany(b => b.Payments)
            //    .HasForeignKey(p => p.BookingID);

            //modelBuilder.Entity<BookingGuest>()
            //    .HasKey(bg => new { bg.BookingID, bg.GuestID });

            //modelBuilder.Entity<BookingGuest>()
            //    .HasOne(bg => bg.Booking)
            //    .WithMany(b => b.BookingGuests)
            //    .HasForeignKey(bg => bg.BookingID)
            //    .OnDelete(DeleteBehavior.NoAction);  

            //modelBuilder.Entity<BookingGuest>()
            //    .HasOne(bg => bg.Guest)
            //    .WithMany(g => g.BookingGuests)
            //    .HasForeignKey(bg => bg.GuestID)
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
