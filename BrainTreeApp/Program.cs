using System;
using Starcounter;
using BrainTreePaymentMethod;
using System.Reflection;
using BrainTreeWrapper;

namespace BrainTreePaymentMethod
{
    class Program
    {
        private static string APP_NAME = "BrainTree";
        private static string DESCRIPTION = "BrainTree it's the payment provider";

        static void Main()
        {
            MainHandlers mainHandlers = new MainHandlers();
            mainHandlers.RegisterLauncher(APP_NAME,DESCRIPTION);

            BrainTreeHandlers brainTreeHandlers = new BrainTreeHandlers();
            brainTreeHandlers.RegisterBrainTreeHandlers();

            new HookIsReady().Register();

            //UriMapping.Map("/braintree/app-settings", "/sc/mapping/settings");
        }
    }
}