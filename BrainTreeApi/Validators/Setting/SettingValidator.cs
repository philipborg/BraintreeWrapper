using FluentValidation;
using System;

namespace BrainTreeApi.Validators.Setting
{
    public class SettingValidator : AbstractValidator<BrainTreeApi.Models.Setting.Setting>
    {
        public SettingValidator()
        {
            RuleFor(jk => jk.Enviroment).NotEmpty();

            RuleFor(jk=>jk.MerchantId).NotEmpty();

            RuleFor(jk => jk.PublicKey).NotEmpty();

            RuleFor(jk => jk.PrivateKey).NotEmpty();
        }
    }
}
