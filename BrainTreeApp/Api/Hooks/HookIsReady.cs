using System;
using Starcounter;
using Simplified.Ring6;

namespace BrainTreeWrapper
{
    public class HookIsReady
    {
        public void Register()
        {
            Hook<PaymentAttempt>.CommitInsert += (e, paymentAttempt) =>
            {
                var creditCard = paymentAttempt.PaymentMethod.GetPayment();

                TransactionWithoutCustomer.CreateTrancation(paymentAttempt, creditCard);
            };
        }
    }
}