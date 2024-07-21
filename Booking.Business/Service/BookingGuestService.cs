using Booking.Business.Abstractions;
using Booking.Business.Validator;
using Booking.DataAccess.Repository;
using Booking.Entities.Models;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Business.Service
{
    public class BookingGuestService : IManager<BookingGuest>
    {
        private readonly BookingGuestRepository _bookingGuestRepository;

        public BookingGuestService(BookingGuestRepository bookingGuestRepository)
        {
            _bookingGuestRepository = bookingGuestRepository;
        }

        public void Create(BookingGuest entity)
        {
            BookingGuestValidator bvgal = new BookingGuestValidator();
            ValidationResult result = bvgal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }
            _bookingGuestRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var bg = _bookingGuestRepository.GetByID(id);
            if (bg != null)
                _bookingGuestRepository.Delete(id);
        }

        public IEnumerable<BookingGuest> GetAll()
        {
            return _bookingGuestRepository.GetAll();
        }

        public BookingGuest GetByID(Guid id)
        {
            var bg = _bookingGuestRepository.GetByID(id);
            if (bg == null)
            {
                throw new Exception("Rezervasyon bulunamadı.");
            }
            return bg;
        }

        public void Update(BookingGuest entity)
        {
            _bookingGuestRepository.Update(entity);
        }
    }
}
