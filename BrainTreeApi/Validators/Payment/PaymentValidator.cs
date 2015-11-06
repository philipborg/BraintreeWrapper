using BrainTreeApi.Models.Payment;
using FluentValidation;

namespace BrainTreeApi.Validators.Payment
{
    public class PaymentValidator : AbstractValidator<PaymentModel>
    {
        public PaymentValidator()
        {
            RuleFor(jk => jk.Amount).NotEmpty().WithMessage("This field cannot be blank");

            RuleFor(jk => jk.Amount).GreaterThan(0).WithMessage("This field have to greater then 0");
        }
    }
}
