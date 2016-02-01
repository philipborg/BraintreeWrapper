using BrainTree;
using FluentValidation;
using System;

namespace BrainTreeApp
{
    public class SettingValidator : AbstractValidator<AppSettingsPage.SettingsJson>
    {
        public SettingValidator()
        {
            //RuleFor(jk => jk.Enviroment.Selected).NotEmpty();

            RuleFor(jk=>jk.MerchantId).NotEmpty();

            RuleFor(jk => jk.PublicKey).NotEmpty();

            RuleFor(jk => jk.PrivateKey).NotEmpty();
        }
    }
}