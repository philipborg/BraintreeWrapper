using BrainTreeApi.Models.Company;
using FluentValidation;

namespace BrainTreeApi.Validators.Company
{
    public class CompanyValidator : AbstractValidator<CompanyModel>
    {
        public CompanyValidator()
        {
            RuleFor(jk => jk.CompanyName).NotEmpty().WithMessage("This field cannot be blank");
        }
    }
}
