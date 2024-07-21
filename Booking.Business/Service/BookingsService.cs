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
    public class BookingsService : IManager<Bookings>
    {
        private readonly BookingsRepository _bookingsRepository;

        public BookingsService(BookingsRepository bRepo)
        {
            _bookingsRepository = bRepo;
        }

        public void Create(Bookings entity)
        {
            BookingsValidator bval = new BookingsValidator();
            ValidationResult result = bval.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }
            _bookingsRepository.Create(entity);

        }

        public void Delete(Guid id)
        {
            var booking = _bookingsRepository.GetByID(id);
            if (booking != null)
                _bookingsRepository.Delete(id);
        }

        public IEnumerable<Bookings> GetAll()
        {
            return _bookingsRepository.GetAll();
        }

        public Bookings GetByID(Guid id)
        {
            var book = _bookingsRepository.GetByID(id);
            if (book == null)
            {
                throw new Exception("Rezervasyon bulunamadı.");
            }
            return book;
        }

        public void Update(Bookings entity)
        {
            _bookingsRepository.Update(entity);
        }
    }
}
