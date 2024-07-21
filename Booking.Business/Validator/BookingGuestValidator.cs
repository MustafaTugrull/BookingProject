using Booking.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Business.Validator
{
    public class BookingGuestValidator : AbstractValidator<BookingGuest>
    {
        public BookingGuestValidator() 
        {
            RuleFor(b => b.Booking).NotEmpty
        }

    }
}
