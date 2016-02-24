using System;
using Starcounter;
using Simplified.Ring6;

namespace BrainTreeWrapper
{
    public class HookIsReady
    {
        public void Register()
        {
            Hook<CreditCardPaymentAttempt>.CommitInsert += (e, creditCardPayment) =>
            {
                TransactionWithoutCustomer.CreateTrancation(creditCardPayment);
            };
        }
    }
}