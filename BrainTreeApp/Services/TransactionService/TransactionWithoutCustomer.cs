using System;
using Starcounter;
using Braintree;
using Simplified.Ring6;

namespace BrainTreeWrapper
{
    public static class TransactionWithoutCustomer
    {
        public static void CreateTrancation(PaymentAttempt paymentAttempt, CreditCardPaymentAttempt creditCard)
        {
            try
            {
                var transactionRequest = new TransactionRequest
                {
                    Amount = paymentAttempt.Order.TotalAmount,
                    CreditCard = new TransactionCreditCardRequest
                    {
                        CVV = creditCard.SecurityCode,
                        Number = creditCard.CardNumber,
                        ExpirationMonth = creditCard.ExpiryMonth,
                        ExpirationYear = creditCard.ExpiryYear
                    }
                };

                var brainTreeSettings = Db.SQL<BrainTreeSettings>("SELECT jk FROM BrainTreeSettings jk").First;

                SetStartedStatus(paymentAttempt, "Started");

                Result<Braintree.Transaction> result = BrainTreeSerivce.Instance.GetBrainTreeGateway(brainTreeSettings).Transaction.Sale(transactionRequest);

                if(result.Errors.Count > 0)
                    foreach(var error in result.Errors.All())
                        SetFailedStatus(paymentAttempt, error.Message);
                else
                    SetFinishedStatus(paymentAttempt, "Payment finished");
            }
            catch (Braintree.Exceptions.AuthenticationException ex)
            {
                SetFailedStatus(paymentAttempt, string.Format("{0} /r/n {1}", "API keys are incorrect", ex.Message));
            }
            catch (Braintree.Exceptions.AuthorizationException ex)
            {
                SetFailedStatus(paymentAttempt, string.Format("{0} /r/n {1}", "Not authorized to perform the attempted action", ex.Message));
            }
            catch (Braintree.Exceptions.DownForMaintenanceException ex)
            {
                SetFailedStatus(paymentAttempt, string.Format("{0} /r/n {1}", "Request times out", ex.Message));
            }
            catch (Braintree.Exceptions.ForgedQueryStringException ex)
            {
                SetFailedStatus(paymentAttempt, string.Format("{0} /r/n {1}", "Invalid hash", ex.Message));
            }
            catch (Braintree.Exceptions.InvalidChallengeException ex)
            {
                SetFailedStatus(paymentAttempt, string.Format("{0} /r/n {1}", "Invalid format", ex.Message));
            }
            catch (Braintree.Exceptions.InvalidSignatureException ex)
            {
                SetFailedStatus(paymentAttempt, string.Format("{0} /r/n {1}", "Invalid signature", ex.Message));
            }
            catch (Braintree.Exceptions.NotFoundException ex)
            {
                SetFailedStatus(paymentAttempt, string.Format("{0} /r/n {1}", "Not found exception", ex.Message));
            }
            catch (Braintree.Exceptions.ServerException ex)
            {
                SetFailedStatus(paymentAttempt, string.Format("{0} /r/n {1}", "Something goes wrong on the Braintree server ", ex.Message));
            }
            catch (Braintree.Exceptions.UnexpectedException ex)
            {
                SetFailedStatus(paymentAttempt, string.Format("{0} /r/n {1}", "Probably a bug in the client library", ex.Message));
            }
            catch (Braintree.Exceptions.UpgradeRequiredException ex)
            {
                SetFailedStatus(paymentAttempt, string.Format("{0} /r/n {1}", " Library is no longer supported", ex.Message));
            }
        }

        public static void SetStartedStatus(PaymentAttempt paymentAttempt, string reason)
        {
            var paymentStarted = new PaymentAttemptStatusStarted
            {
                Reason = reason,
                Time = new DateTime(),
                PaymentAttempt = paymentAttempt
            };
        }

        public static void SetFailedStatus(PaymentAttempt paymentAttempt, string reason)
        {
            var paymentStarted = new PaymentAttemptStatusFailed
            {
                Reason = reason,
                Time = new DateTime(),
                PaymentAttempt = paymentAttempt
            };
        }

        public static void SetFinishedStatus(PaymentAttempt paymentAttempt, string reason)
        {
            var paymentStarted = new PaymentAttemptStatusFinished
            {
                Reason = reason,
                Time = new DateTime(),
                PaymentAttempt = paymentAttempt
            };
        }
    }
}