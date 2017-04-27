using BrainTree;
using FluentValidation;
using System;

namespace BrainTreeWrapper
{
    public class SettingValidator : AbstractValidator<BrainTree.AppSettingsPage.SettingsJson>
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
