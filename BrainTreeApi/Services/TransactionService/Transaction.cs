using Braintree;
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
        //NOT WORKING ? APPLICATION RESTARTING WTF :/
        //private static BraintreeGateway _gateway
        //{
        //    get
        //    {
        //        //TODO GET FROM BRAINTREECONFIG.XML
        //        return _gateway ?? new BraintreeGateway
        //        {
        //            Environment = Braintree.Environment.SANDBOX,
        //            MerchantId = "3t7txmqspfhwygry",
        //            PublicKey = "xgdnqmpn4qjdvfns",
        //            PrivateKey = "e288172b64376e5c9e56d2f5b91e0283"
        //        };
        //    }
        //}
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

            var _gateway = new BraintreeGateway {
                Environment = Braintree.Environment.SANDBOX,
                MerchantId = "3t7txmqspfhwygry",
                PublicKey = "xgdnqmpn4qjdvfns",
                PrivateKey = "e288172b64376e5c9e56d2f5b91e0283"
            };

            var result = _gateway.Transaction.Sale(transactionRequest);
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
