using Booking.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DataAccess.Repository
{
    public class BookingGuestRepository : GenericRepository<BookingGuestRepository>
    {
        public BookingGuestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
