using Booking.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Business.Validator
{
    public class GuestValidator : AbstractValidator<Guest>
    {
        public GuestValidator()
        {
            RuleFor(g => g.TCKN)
                .NotEmpty()
                .WithMessage("Tc Kimlik No boş geçilemez.");
        }
    }
}
