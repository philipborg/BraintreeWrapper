using System;
using Starcounter;
using BrainTreePaymentMethod;
using Simplified.Ring6;

namespace BrainTreePaymentMethod
{
    class Program
    {
        static void Main()
        {
            //OnInstall();

            MainHandlers mainHandlers = new MainHandlers();
            mainHandlers.RegisterLauncher();

            BrainTreeHandlers brainTreeHandlers = new BrainTreeHandlers();
            brainTreeHandlers.RegisterBrainTreeHandlers();
        }

        //METHOD ADD PAYMENT TO SIMPLYFI DATA MODEL
        //PAYABLE APP KNOW IS ANY PAYMENT METHOD
        //static void OnInstall()
        //{
        //    try
        //    {
        //        //var paymentSetting = new Simplified.Ring6.PaymentMethods()
        //        //{
        //        //    Name = "BrainTree payment method",
        //        //    Description = "blah",
        //        //    Url = "/payment/customer-data/{?}",
        //        //    IsEnabled = true,
        //        //};
        //    }
        //    catch(Exception ex)
        //    {
                
        //    }
        //}

        //static void OnUnInstall()
        //{
        //    //paymentSetting.IsEnabled = false;
        //}
    }
}