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
            MainHandlers mainHandlers = new MainHandlers();
            mainHandlers.RegisterLauncher();

            BrainTreeHandlers brainTreeHandlers = new BrainTreeHandlers();
            brainTreeHandlers.RegisterBrainTreeHandlers();
        }
    }
}