using Braintree;
using BrainTreeApi.Common;
using BrainTreeApi.Models.Address;
using BrainTreeApi.Models.CreditCard;
using BrainTreeApi.Models.Customer;
using BrainTreeApi.Models.Payment;
using BrainTreeApi.Service.CustomerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainTreeApi.Service.TransactionService
{
    public static class Transaction
    {
        public static Tuple<bool, string> CreateTransactionWithBillingAddress(string customerId, string billingAddressId, CreditCardModel creditCard, PaymentModel payment)
        {
            var transactionRequest = new TransactionRequest
            {
                Amount = payment.Amount,
                CustomerId = customerId,
                BillingAddressId = billingAddressId,
                CreditCard = new TransactionCreditCardRequest
                {
                    Number = creditCard.CardNumber,
                    CVV = creditCard.SecurityNumber,
                    ExpirationMonth = creditCard.ExpiryMonth.ToString(),
                    ExpirationYear = creditCard.ExpiryYear.ToString(),
                }
            };

            var result = BrainTreeSerivce.Instance.GetBrainTreeGateway().Transaction.Sale(transactionRequest);

            if (result.IsSuccess())
            {
                return new Tuple<bool, string>(result.IsSuccess(), result.Target.Id);
            }
            else
            {
                return new Tuple<bool, string>(result.IsSuccess(), result.Message);
            }
        }
    }
}
