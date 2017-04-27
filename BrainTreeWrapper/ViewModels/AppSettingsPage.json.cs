using Starcounter;
using System;

namespace BraintreeWrapper.ViewModels
{
    public partial class AppSettingsPage : Page
    {
        void Handle(Input.Save action)
        {
            var settings = this.Settings;

            //var settingValidate = new SettingValidator().Validate(settings);

            ClearErrorSettings();

            if (settings != null)
            {
                try
                {
                    Db.Transact(delegate
                    {
                        var bts = Db.SQL<BraintreeSettings>("SELECT i FROM BrainTreeSettings i").First;

                        if (bts == null)
                        {
                            new BraintreeSettings
                            {
                                Enviroment = settings.Enviroment.Selected,
                                MerchantId = settings.MerchantId,
                                PublicKey = settings.PublicKey,
                                PrivateKey = settings.PrivateKey
                            };
                        }
                        else
                        {
                            bts.Enviroment = settings.Enviroment.Selected;
                            bts.MerchantId = settings.MerchantId;
                            bts.PublicKey = settings.PublicKey;
                            bts.PrivateKey = settings.PrivateKey;
                        }
                    });

                    this.Result.IsSuccessful = true;
                    this.Result.Message = "BrainTree settings was saved !";
                }
                catch (Exception ex)
                {
                    this.Result.Message = ex.Message;
                }
            }
            else
            {
                //foreach (var field in settingsValidator.Errors)
                //{
                //    this.ErrorSettings[field.PropertyName] = "has-error has-feedbac";
                //}
            }
        }
        void ClearErrorSettings()
        {
            this.ErrorSettings.MerchantId = string.Empty;
            this.ErrorSettings.PublicKey = string.Empty;
            this.ErrorSettings.PrivateKey = string.Empty;
        }
    }
}