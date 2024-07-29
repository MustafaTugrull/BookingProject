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
    public class HotelService: IManager<Hotel>
    {
        private readonly HotelRepository _hotelRepository;

        public HotelService(HotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public void Create(Hotel entity)
        {
            _hotelRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var hotel = _hotelRepository.GetByID(id);
            
            if(hotel != null)
                _hotelRepository.Delete(id);
        }

        public IEnumerable<Hotel> GetAll()
        {
            return _hotelRepository.GetAll();
        }

        public Hotel GetByID(Guid id)
        {
            var hotel =_hotelRepository.GetByID(id);
            if (hotel == null)
            {
                throw new Exception("Otel bulunamadı.");
            }
            return hotel;
        }

        public void Update(Hotel entity)
        {
            _hotelRepository.Update(entity);
        }
    }
}
