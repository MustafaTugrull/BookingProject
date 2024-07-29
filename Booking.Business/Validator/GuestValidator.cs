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
            //RuleFor(guest => guest.FirstName)
            //    .NotEmpty().WithMessage("İsim boş olamaz.")
            //    .Length(2, 50).WithMessage("İsim uzunluğu 2 ile 50 karakter arasında olmalıdır.");

            //RuleFor(guest => guest.LastName)
            //    .NotEmpty().WithMessage("Soyisim boş olamaz.")
            //    .Length(2, 50).WithMessage("Soyisim uzunluğu 2 ile 50 karakter arasında olmalıdır.");

            //RuleFor(guest => guest.TCKN)
            //    .NotEmpty().WithMessage("TCKN boş olamaz.")
            //    .Length(11).WithMessage("TCKN 11 karakter uzunluğunda olmalıdır.");

            //RuleFor(guest => guest.DateOfBirth)
            //    .NotEmpty()
            //    .WithMessage("Doğum Tarihi boş geçilemez.");

            //RuleFor(guest => guest.Address)
            //    .NotEmpty()
            //    .WithMessage("Adres boş geçilemez.");

            //RuleFor(guest => guest.Email)
            //    .NotEmpty().WithMessage("Email boş olamaz.")
            //    .EmailAddress().WithMessage("Geçerli bir email adresi girin.");

            //RuleFor(guest => guest.Phone)
            //    .NotEmpty().WithMessage("Telefon numarası boş olamaz.")
            //    .Matches(@"^\d+$").WithMessage("Telefon numarası sadece rakamlardan oluşmalıdır.");
        }
    }
}
