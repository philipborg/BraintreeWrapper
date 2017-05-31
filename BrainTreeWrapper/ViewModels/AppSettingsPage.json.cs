using Starcounter;
using System;

namespace BraintreeWrapper.ViewModels
{
    public partial class AppSettingsPage : Json
    {
        void Handle(Input.Save action)
        {
            var settings = this.Settings;

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
                                Environment = settings.Environment.Selected,
                                MerchantId = settings.MerchantId,
                                PublicKey = settings.PublicKey,
                                PrivateKey = settings.PrivateKey
                            };
                        }
                        else
                        {
                            bts.Environment = settings.Environment.Selected;
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
                this.Result.IsSuccessful = false;
                this.Result.Message = "No BrainTree settings to save!";
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