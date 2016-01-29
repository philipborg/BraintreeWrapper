using Starcounter;
using Simplified.Ring6;
using System;

namespace BrainTree
{
    public partial class AppSettingsPage : Page
    {
        void Handle(Input.Save action)
        {
            var settings = this.Settings[0];

            var isValid = true;

            if(isValid)
            {
                if(settings != null)
                {
                    try
                    {
                        Db.Transact(delegate {

                            var bts = Db.SQL<BrainTreeSettings>("SELECT i FROM BrainTreeSettings i").First;

                            if (bts == null)
                            {
                                new BrainTreeSettings {
                                    Enviroment = settings.Enviroment,
                                    MerchantId = settings.MerchantId,
                                    PublicKey = settings.PublicKey,
                                    PrivateKey = settings.PrivateKey
                                };
                            }
                            else
                            {
                                bts.Enviroment = settings.Enviroment;
                                bts.MerchantId = settings.MerchantId;
                                bts.PublicKey = settings.PublicKey;
                                bts.PrivateKey = settings.PrivateKey;
                            }
                        });

                        this.Result.IsSuccessful = true;

                        ClearForm();

                        this.Result.Message = "BrainTree settings was saved !";
                    }
                    catch(Exception ex)
                    {
                        this.Result.Message = ex.Message;
                    }
                }
            }
        }

        void ClearForm()
        {
            this.Settings.Clear();
        }
    }
}