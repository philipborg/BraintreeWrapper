﻿using System;
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
            MainHandlers mainHandlers = new MainHandlers();
            mainHandlers.RegisterLauncher(APP_NAME,DESCRIPTION);

            BrainTreeHandlers brainTreeHandlers = new BrainTreeHandlers();
            brainTreeHandlers.RegisterBrainTreeHandlers();

            UriMapping.Map("/braintree/app-settings", "/sc/mapping/settings");

            UriMapping.OntologyMap("/braintree/partials/credit-card/@w", typeof(Payable).FullName, null, null);
        }
    }
}