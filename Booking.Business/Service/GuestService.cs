using Booking.Business.Abstractions;
using Booking.DataAccess.Repository;
using Booking.Entities.Models;
using Booking.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Business.Validator;
using FluentValidation.Results;

namespace Booking.Business.Service
{
    public class GuestService : IManager<Guest>
    {
        private readonly GuestRepository _guestRepository;

        public GuestService(GuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }

        public void Create(Guest entity)
        {
            GuestValidator gval = new GuestValidator();
            ValidationResult result = gval.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }
            _guestRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var guest = _guestRepository.GetByID(id);

            if (guest != null)
                _guestRepository.Delete(id);
        }

        public IEnumerable<Guest> GetAll()
        {
            return _guestRepository.GetAll();
        }

        public Guest GetByID(Guid id)
        {
            var guest = _guestRepository.GetByID(id);
            if (guest == null)
            {
                throw new Exception("Misaifir Bulunamadı.");
            }
            return guest;
        }

        public void Update(Guest entity)
        {
            _guestRepository.Update(entity);
        }
    }
}
