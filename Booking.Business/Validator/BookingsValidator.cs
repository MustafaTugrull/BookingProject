using Booking.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Business.Validator
{
    public class BookingsValidator : AbstractValidator<Bookings>
    {
        public BookingsValidator()
        {
            RuleFor(b => b.Id)
                .NotEmpty()
                .WithMessage("Misafir alanı boş olamaz.");
        }

    }
}
