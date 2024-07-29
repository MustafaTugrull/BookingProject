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
            //RuleFor(booking => booking.CheckinDate)
            //    .LessThan(booking => booking.CheckoutDate)
            //    .WithMessage("Check-in tarihi, check-out tarihinden önce olmalıdır.");

            //RuleFor(booking => booking.RoomID)
            //    .NotEmpty().WithMessage("Oda ID'si boş olamaz.");

            //RuleFor(booking => booking.TotalPrice)
            //    .GreaterThan(0).WithMessage("Toplam fiyat 0'dan büyük olmalıdır.");

        }

    }
}
