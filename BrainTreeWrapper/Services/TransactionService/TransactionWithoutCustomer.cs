using System;
using Starcounter;
using Braintree;
using Simplified.Ring6;
using BraintreeWrapper.Common;

namespace BraintreeWrapper
{
    public static class TransactionWithoutCustomer
    {
        public static void CreateTrancation(CreditCardPaymentAttempt creditCardPayment)
        {
            var paymentAttempt = Db.SQL<PaymentAttempt>("SELECT r FROM Simplified.Ring6.PaymentAttempt r WHERE r.\"Order\" = ?", creditCardPayment.Order).First;
            try
            {
                var transactionRequest = new TransactionRequest
                {
                    Amount = creditCardPayment.Amount,
                    CreditCard = new TransactionCreditCardRequest
                    {
                        CVV = creditCardPayment.SecurityCode,
                        Number = creditCardPayment.CardNumber,
                        ExpirationMonth = creditCardPayment.ExpiryMonth,
                        ExpirationYear = creditCardPayment.ExpiryYear
                    }
                };

                var brainTreeSettings = Db.SQL<BrainTreeSettings>("SELECT jk FROM BrainTreeSettings jk").First;

                SetStartedStatus(paymentAttempt, creditCardPayment, "Started");

                Result<Braintree.Transaction> result = BrainTreeSerivce.Instance.GetBrainTreeGateway(brainTreeSettings).Transaction.Sale(transactionRequest);

                if (result.Errors?.Count > 0)
                {
                    foreach (var error in result.Errors.All())
                    {
                        SetFailedStatus(paymentAttempt, creditCardPayment, error.Message);
                    }
                }
                else
                {
                    SetFinishedStatus(paymentAttempt, creditCardPayment, "Payment finished");
                }
            }
            catch (Braintree.Exceptions.AuthenticationException ex)
            {
                SetFailedStatus(paymentAttempt, creditCardPayment, string.Format("{0} /r/n {1}", "API keys are incorrect", ex.Message));
            }
            catch (Braintree.Exceptions.AuthorizationException ex)
            {
                SetFailedStatus(paymentAttempt, creditCardPayment, string.Format("{0} /r/n {1}", "Not authorized to perform the attempted action", ex.Message));
            }
            catch (Braintree.Exceptions.DownForMaintenanceException ex)
            {
                SetFailedStatus(paymentAttempt, creditCardPayment, string.Format("{0} /r/n {1}", "Request times out", ex.Message));
            }
            catch (Braintree.Exceptions.ForgedQueryStringException ex)
            {
                SetFailedStatus(paymentAttempt, creditCardPayment, string.Format("{0} /r/n {1}", "Invalid hash", ex.Message));
            }
            catch (Braintree.Exceptions.InvalidChallengeException ex)
            {
                SetFailedStatus(paymentAttempt, creditCardPayment, string.Format("{0} /r/n {1}", "Invalid format", ex.Message));
            }
            catch (Braintree.Exceptions.InvalidSignatureException ex)
            {
                SetFailedStatus(paymentAttempt, creditCardPayment, string.Format("{0} /r/n {1}", "Invalid signature", ex.Message));
            }
            catch (Braintree.Exceptions.NotFoundException ex)
            {
                SetFailedStatus(paymentAttempt, creditCardPayment, string.Format("{0} /r/n {1}", "Not found exception", ex.Message));
            }
            catch (Braintree.Exceptions.ServerException ex)
            {
                SetFailedStatus(paymentAttempt, creditCardPayment, string.Format("{0} /r/n {1}", "Something goes wrong on the Braintree server ", ex.Message));
            }
            catch (Braintree.Exceptions.UnexpectedException ex)
            {
                SetFailedStatus(paymentAttempt, creditCardPayment, string.Format("{0} /r/n {1}", "Probably a bug in the client library", ex.Message));
            }
            catch (Braintree.Exceptions.UpgradeRequiredException ex)
            {
                SetFailedStatus(paymentAttempt, creditCardPayment, string.Format("{0} /r/n {1}", " Library is no longer supported", ex.Message));
            }
        }

        public static void SetStartedStatus(PaymentAttempt paymentAttempt, CreditCardPaymentAttempt creditCardPayment, string reason)
        {
            creditCardPayment.IsStarted = true;

            var paymentStarted = new PaymentAttemptStatusStarted
            {
                Reason = reason,
                Time = DateTime.Now,
                PaymentAttempt = paymentAttempt
            };
        }

        public static void SetFailedStatus(PaymentAttempt paymentAttempt, CreditCardPaymentAttempt creditCardPayment, string reason)
        {
            creditCardPayment.IsFinished = true;
            creditCardPayment.IsSuccessful = false;

            var paymentStarted = new PaymentAttemptStatusFailed
            {
                Reason = reason,
                Time = DateTime.Now,
                PaymentAttempt = paymentAttempt
            };
        }

        public static void SetFinishedStatus(PaymentAttempt paymentAttempt, CreditCardPaymentAttempt creditCardPayment, string reason)
        {
            creditCardPayment.IsFinished = true;
            creditCardPayment.IsSuccessful = true;

            var paymentStarted = new PaymentAttemptStatusFinished
            {
                Reason = reason,
                Time = DateTime.Now,
                PaymentAttempt = paymentAttempt
            };
        }
    }
}