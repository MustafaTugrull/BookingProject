using Booking.DataAccess.Context;
using Booking.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DataAccess.Repository
{
    public class RoomTypeRepository : GenericRepository<RoomType>
    {
        public RoomTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
