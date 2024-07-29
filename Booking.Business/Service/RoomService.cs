using Booking.Business.Abstractions;
using Booking.DataAccess.Repository;
using Booking.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Business.Service
{
    public class RoomService : IManager<Room>
    {
        private readonly RoomRepository _roomRepository;

        public RoomService(RoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public void Create(Room entity)
        {
            _roomRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var room = _roomRepository.GetByID(id);

            if (room != null)
                _roomRepository.Delete(id);
        }

        public IEnumerable<Room> GetAll()
        {
            return _roomRepository.GetAll();
        }

        public Room GetByID(Guid id)
        {
            var room = _roomRepository.GetByID(id);
            if (room == null)
            {
                throw new Exception("Oda bulunamadı.");
            }
            return room;
        }

        public void Update(Room entity)
        {
            _roomRepository.Update(entity);
        }
    }
}
