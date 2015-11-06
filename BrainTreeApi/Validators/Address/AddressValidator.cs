using BrainTreeApi.Models.Address;
using FluentValidation;

namespace BrainTreeApi.Validators.Address
{
    public class AddressValidator : AbstractValidator<AddressModel>
    {
        public AddressValidator()
        {
            RuleFor(jk => jk.StreetAddress).NotEmpty().WithMessage("This field cannot be blank");

            RuleFor(jk => jk.Locality).NotEmpty().WithMessage("This field cannot be blank");

            RuleFor(jk => jk.Region).NotEmpty().WithMessage("This field cannot be blank");

            RuleFor(jk => jk.PostalCode).NotEmpty().WithMessage("This field cannot be blank");

            RuleFor(jk => jk.CountryName).NotEmpty().WithMessage("This field cannot be blank");
        }
    }
}
