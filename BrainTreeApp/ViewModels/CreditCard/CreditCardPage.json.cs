using BrainTreeApi;
using BrainTreeApi.Models.CreditCard;
using BrainTreeApi.Models.Customer;
using BrainTreeApi.Models.Payment;
using Starcounter;
using System;

namespace BrainTreeApp
{
    public partial class CreditCardPage : Page, IBound<Payable>
    {
        void Handle(Input.Pay action)
        {
            this.Errors.Clear();

            var creditCardJson = this.CreditCard as CreditCardJson;

            if (!ValidCreditCard(creditCardJson))
                return;

                try
                {
                    var payable = this.Data as Payable;

                    var customer = MappingDataToCustomer(payable.PayableCustomer);
                    var creditCard = MappingDataToCreditCard(creditCardJson);
                    var payment = MappingDataToPayment(payable);

                    var request = Serializator.ToSerialize(customer);

                    BrainTreeApi.Service.TransactionService.Transaction.CreateTransactionWithCustomer(customer, creditCard, payment);
                }
                catch (ApplicationException ex)
                {
                    SaveTransaction("Start", ex.Message, false);
                }
                catch (Exception ex)
                {
                    var errors = ex.Message.Split('\n');

                    foreach (string err in errors)
                    {
                        this.Errors.Add(new ErrorsElementJson {
                            Error = err
                        });
                    }
                }
                finally
                {
                    if(this.Errors.Count == 0)
                        SaveTransaction("Start", string.Empty, true);
                }
        }

        private void SaveTransaction(string request = "", string response = "", bool isSuccessful = false)
        {
            Db.Transact(delegate {
                var status = new PayableStatus();

                status.Payable = this.Data;
                status.RequestStart = DateTime.Now;
                status.Request = request;
                status.Response = response;
                status.IsSuccessful = isSuccessful;
            });
        }


        #region SIMPLE MAPPING

        private CustomerModel MappingDataToCustomer(PayableCustomer customer)
        {
            return new CustomerModel
            {
                CustomerId = string.Empty,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email
            };
        }

        private CreditCardModel MappingDataToCreditCard(CreditCardJson creditCard)
        {
            return new CreditCardModel
            {
                CardNumber = creditCard.CardNumber,
                ExpiryMonth = Int32.Parse(creditCard.ExpiryMonth),
                ExpiryYear = Int32.Parse(creditCard.ExpiryYear),
                SecurityNumber = creditCard.SecurityNumber
            };
        }

        private PaymentModel MappingDataToPayment(Payable payment)
        {
            return new PaymentModel
            {
                Amount = payment.TotalGrossPrice
            };
        }

        #endregion

        #region VALID

        private bool ValidCreditCard(CreditCardJson creditCard)
        {
            this.CreditCardError = new CreditCardErrorJson();

            var isValidCreditCard = new CreditCardValidator().Validate(creditCard);

            if (isValidCreditCard.Errors.Count > 0)
            {
                foreach (var inValidFields in isValidCreditCard.Errors)
                {
                    this.CreditCardError[inValidFields.PropertyName] = "has-error has-feedbac";
                }
            }

            return isValidCreditCard.IsValid;
        }

        #endregion
    }
}