using Simplified.Ring6;
using Starcounter;

namespace BrainTreeWrapper.Api
{
    public class CommitHooks
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