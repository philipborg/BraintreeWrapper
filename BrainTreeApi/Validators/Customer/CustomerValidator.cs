using BrainTreeApi.Models.Customer;
using FluentValidation;

namespace BrainTreeApi.Validators.Customer
{
    public class CustomerValidator : AbstractValidator<CustomerModel>
    {
        public CustomerValidator()
        {
            RuleFor(jk => jk.FirstName).NotEmpty().WithMessage("This field cannot be blank");

            RuleFor(jk => jk.LastName).NotEmpty().WithMessage("This field cannot be blank");

            RuleFor(jk => jk.Email).NotEmpty().WithMessage("This field cannot be blank");

            RuleFor(jk => jk.Phone).NotEmpty().WithMessage("This field cannot be blank");
        }
    }
}
