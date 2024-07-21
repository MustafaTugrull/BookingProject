using Booking.DataAccess.Context;
using Booking.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DataAccess.Repository
{
    public class BookingGuestRepository : GenericRepository<BookingGuest>
    {
        public BookingGuestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
