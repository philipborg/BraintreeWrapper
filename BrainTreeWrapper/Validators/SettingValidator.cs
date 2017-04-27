using BraintreeWrapper.ViewModels;
using FluentValidation;

namespace BraintreeWrapper
{
    public class SettingValidator : AbstractValidator<AppSettingsPage.SettingsJson>
    {
        public SettingValidator()
        {
            RuleFor(jk=>jk.Enviroment).NotEmpty();

            RuleFor(jk => jk.MerchantId).NotEmpty();

            RuleFor(jk => jk.PublicKey).NotEmpty();

            RuleFor(jk => jk.PrivateKey).NotEmpty();
        }
    }
}
