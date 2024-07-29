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
            //RuleFor(bg => bg.BookingID)
            //    .NotEmpty().WithMessage("Rezervasyon ID'si boş olamaz.");

            //RuleFor(bg => bg.GuestID)
            //    .NotEmpty().WithMessage("Misafir ID'si boş olamaz.");

            //RuleFor(bg => bg.Guest)
            //    .NotNull().WithMessage("Misafir bilgisi geçerli olmalıdır.");

            //// Örneğin, Misafir bilgileri doğrulanabilir (optional)
            //RuleFor(bg => bg.Guest.FirstName)
            //    .NotEmpty().WithMessage("Misafir adı boş olamaz.")
            //    .MaximumLength(50).WithMessage("Misafir adı en fazla 50 karakter olmalıdır.");

            //RuleFor(bg => bg.Guest.LastName)
            //    .NotEmpty().WithMessage("Misafir soyadı boş olamaz.")
            //    .MaximumLength(50).WithMessage("Misafir soyadı en fazla 50 karakter olmalıdır.");

            //RuleFor(bg => bg.Guest.TCKN)
            //    .NotEmpty().WithMessage("Misafir TCKN boş olamaz.")
            //    .Length(11).WithMessage("Misafir TCKN 11 karakter olmalıdır.");
        }

    }
}
