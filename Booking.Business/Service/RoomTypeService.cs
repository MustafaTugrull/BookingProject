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
    public class RoomTypeService : IManager<RoomType>
    {
        private readonly RoomTypeRepository _roomTypeRepository;

        public RoomTypeService(RoomTypeRepository roomTypeRepository)
        {
            _roomTypeRepository = roomTypeRepository;
        }

        public void Create(RoomType entity)
        {
            _roomTypeRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var room = _roomTypeRepository.GetByID(id);
            if (room != null)
                _roomTypeRepository.Delete(id);
        }

        public IEnumerable<RoomType> GetAll()
        {
            return _roomTypeRepository.GetAll();
        }

        public RoomType GetByID(Guid id)
        {
            var room = _roomTypeRepository.GetByID(id);
            if (room != null)
            {
                throw new Exception("Oda bulunamadı.");
            }
            return room;
        }

        public void Update(RoomType entity)
        {
            _roomTypeRepository.Update(entity);
        }
    }
}
