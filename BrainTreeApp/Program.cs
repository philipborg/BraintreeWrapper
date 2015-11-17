using System;
using Starcounter;
using BrainTreePaymentMethod;
using Simplified.Ring3;
using System.Reflection;
using BrainTreeApi.Common;

namespace BrainTreePaymentMethod
{
    class Program
    {
        private static string APP_NAME = "BrainTree";
        private static string DESCRIPTION = "BrainTree it's the payment provider";

        static void Main()
        {
            var app = Application.GetApplication(Assembly.GetExecutingAssembly());

            //WHEN INSTALL APP, ADD RECORDS TO SIMPLIFY PaymentMethod
            //BASKET APP KNOW ARE ANY PAYMENT METHODS
            //IF NO PAYMENT WAS BLOCKED - BASKET INFORMATION
            //IF PAYMENT EXISTS REDIRECT
            OnInstall(app.WorkingDirectory);

            MainHandlers mainHandlers = new MainHandlers();
            mainHandlers.RegisterLauncher(APP_NAME,DESCRIPTION);

            BrainTreeHandlers brainTreeHandlers = new BrainTreeHandlers();
            brainTreeHandlers.RegisterBrainTreeHandlers();

            //TODO ON UNISTALL
            //OnUnInstall();
        }

        private static void SetConfigFilePath(string appDirectory)
        {
            BrainTreeConfig.FileConfigPath = string.Format("{0}\\{1}", appDirectory, "Config\\BrainTreeConfig.xml");
        }

        private static void OnInstall(string appDirectory)
        {
            SetConfigFilePath(appDirectory);
            
            var isExist = Db.SQL<PaymentMethod>("SELECT p FROM Simplified.Ring3.PaymentMethod p WHERE p.MethodName = ?", APP_NAME).First;   
            
            if(isExist == null)
            {
                Db.Transact(delegate
                {
                    new PaymentMethod()
                    {
                        MethodName = APP_NAME,
                        MethodUrl = "/payment/{0}/customer-data",
                        Description = DESCRIPTION
                    };
                });
            }
        }

        private static void OnUnInstall()
        {
            var isExist = Db.SQL<PaymentMethod>("SELECT p FROM Simplified.Ring3.PaymentMethod p WHERE p.MethodName = ?", "BrainTree").First;
            
            if (isExist != null)
            {
                Db.Transact(delegate {
                    isExist.Delete();
                });
            }
        }
    }
}