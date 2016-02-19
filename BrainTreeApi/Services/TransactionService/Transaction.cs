using Braintree;
using Braintree.Exceptions;
using BrainTreeApi.Common;
using BrainTreeApi.Models.CreditCard;
using BrainTreeApi.Models.Customer;
using BrainTreeApi.Models.Payment;
using System;
namespace BrainTreeApi.Service.TransactionService
{
    public static class Transaction
    {
        public static void CreateTransactionWithCustomer(string enviroment, string merchantId, string publicKey, string privateKey, CustomerModel customer, CreditCardModel creditCard, PaymentModel payment)
        {
            try
            {
            //    var transactionRequest = new TransactionRequest
            //    {
            //        Amount = payment.Amount,
            //        Customer = new CustomerRequest
            //        {
            //            FirstName = customer.FirstName,
            //            LastName = customer.LastName,
            //            Email = customer.Email
            //        },
            //        CreditCard = new TransactionCreditCardRequest
            //        {
            //            Number = creditCard.CardNumber,
            //            CVV = creditCard.SecurityNumber,
            //            ExpirationMonth = creditCard.ExpiryMonth.ToString(),
            //            ExpirationYear = creditCard.ExpiryYear.ToString(),
            //        }
            //    };

            //    var result = BrainTreeSerivce.Instance.GetBrainTreeGateway(enviroment, merchantId, publicKey,privateKey).Transaction.Sale(transactionRequest);

            //    Result<Transaction> settle = BrainTreeSerivce.Instance.GetBrainTreeGateway(enviroment, merchantId, publicKey, privateKey).Transaction.SubmitForSettlement("");

            //    var settleAmount = settle.Transaction.Amount;

            //    if (!result.IsSuccess())
            //        throw new Exception(result.Message);
                    
            }
            catch (Braintree.Exceptions.AuthenticationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            catch (Braintree.Exceptions.AuthorizationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            catch (Braintree.Exceptions.DownForMaintenanceException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            catch (Braintree.Exceptions.InvalidChallengeException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            catch (Braintree.Exceptions.InvalidSignatureException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            catch (Braintree.Exceptions.NotFoundException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            catch (Braintree.Exceptions.ServerException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            catch (Braintree.Exceptions.UnexpectedException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            catch (Braintree.Exceptions.UpgradeRequiredException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
