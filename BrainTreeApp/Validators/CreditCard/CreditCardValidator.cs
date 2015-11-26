using FluentValidation;

namespace BrainTreeApp
{
    public class CreditCardValidator : AbstractValidator<CreditCardPage.CreditCardJson>
    {
        public CreditCardValidator()
        {
            RuleFor(jk => jk.CardNumber).NotEmpty().WithMessage("This field cannot be blank");
            RuleFor(jk => jk.CardNumber).Length(16, 19).WithMessage("This field cannot be blank");

            RuleFor(jk => jk.ExpiryMonth).NotEmpty().WithMessage("This field cannot be blank");
            //RuleFor(jk => jk.ExpiryMonth).GreaterThan(0).LessThan(12).WithMessage("This field expiry month is not valid");

            RuleFor(jk => jk.ExpiryYear).NotEmpty().WithMessage("This field cannot be blank");

            RuleFor(jk => jk.SecurityNumber).NotEmpty().WithMessage("This field cannot be blank");
        }

    }
}
