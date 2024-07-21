using Booking.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DataAccess.Repository
{
    public class Guest : GenericRepository<Guest>
    {
        public Guest(ApplicationDbContext context) : base(context)
        {

        }
    }
}
