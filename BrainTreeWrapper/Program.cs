using System;
using Starcounter;
using BrainTreePaymentMethod;
using System.Reflection;
using BrainTreeWrapper;
using BrainTreeWrapper.Api;

namespace BrainTreePaymentMethod
{
    class Program
    {
        static void Main()
        {
            var mainHandlers = new MainHandlers();
            mainHandlers.Register();

            var hooks = new CommitHooks();
            hooks.Register();
        }
    }
}