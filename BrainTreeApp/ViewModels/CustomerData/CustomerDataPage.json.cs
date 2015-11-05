using Starcounter;
using System;
using BrainTreeApi.Models.Payment;
using BrainTreeApi.Service.TransactionService;
using BrainTreeApi.Service.CustomerServices;
using BrainTreeApi.Models.Company;
using BrainTreeApi.Models.CreditCard;
using BrainTreeApi.Models.Address;
using BrainTreeApi.Models.Customer;

namespace BrainTreePaymentMethod
{
    public partial class CustomerDataPage : Page
    {
        void Handle(Input.Pay action)
        {
            var page = (CustomerDataPage)this;

            this.Errors.Clear();

            var addressModel = MappingDataToAddress(page.Address);

            var customerModel = MappingDataToCustomer(page.Customer);

            var creditCardModel = MappingDataToCreditCard(page.CreditCard);

            var paymentModel = MappingDataToCreditCard(this);

            var company = MappingDataToCompany(page.Company);

            var customer = BrainTreeApi.Service.CustomerServices.Customer.CreateCustomer(customerModel);

            var customerId = string.Empty;

            if (!customer.Item1)
            {
                this.Errors.Add(new ErrorsElementJson
                {
                    Error = customer.Item2
                });

                return;
            }

            customerModel.CustomerId = customer.Item2;

            var billingAddress = BrainTreeApi.Service.CustomerServices.Customer.CreateAddress(customerModel, addressModel, company);
            var billingAddressId = string.Empty;

            if (!billingAddress.Item1)
            {
                this.Errors.Add(new ErrorsElementJson
                {
                    Error = billingAddress.Item2
                });

                return;
            }

            billingAddressId = billingAddress.Item2;
            var result = CreateTransaction(customerModel.CustomerId, billingAddressId, creditCardModel, paymentModel);

            if (!result.Item1)
            {
                this.Errors.Add(new ErrorsElementJson
                {
                    Error = result.Item2
                });

                return;
            }

            this.Success = "Payment completed ;) !";
        }

        private Tuple<bool, string> CreateTransaction(string customerId, string billingAddressId, CreditCardModel creditCard, PaymentModel payment)
        {
            return BrainTreeApi.Service.TransactionService.Transaction.CreateTransactionWithBillingAddress(customerId, billingAddressId, creditCard, payment);
        }

        #region Mapping JSON TO MODEL

        private AddressModel MappingDataToAddress(CustomerDataPage.AddressJson address)
        {
            return new AddressModel
            {
                StreetAddress = address.StreetAddress,
                ExtendedAddress = address.ExtendedAddress,
                PostalCode = address.PostalCode,
                Locality = address.Locality,
                Region = address.Region,
                CountryName = address.CountryName,
                CountryCodeNumeric = address.CountryCodeNumeric,
                CountryCodeAlpha2 = address.CountryCodeAlpha2,
                CountryCodeAlpha3 = address.CountryCodeAlpha3,
            };
        }

        private CustomerModel MappingDataToCustomer(CustomerDataPage.CustomerJson customer)
        {
            return new CustomerModel
            {
                CustomerId = "",
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Fax = customer.Fax,
                Phone = customer.Phone,
                Website = string.Empty
            };
        }

        private CreditCardModel MappingDataToCreditCard(CustomerDataPage.CreditCardJson creditCard)
        {
            return new CreditCardModel
            {
                CardNumber = creditCard.CardNumber,
                ExpiryMonth = creditCard.ExpiryMonth,
                ExpiryYear = creditCard.ExpiryYear,
                SecurityNumber = creditCard.SecurityNumber
            };
        }

        private PaymentModel MappingDataToCreditCard(CustomerDataPage payment)
        {
            return new PaymentModel
            {
                Amount = payment.Amount
            };
        }

        private CompanyModel MappingDataToCompany(CustomerDataPage.CompanyJson company)
        {
            return new CompanyModel
            {
                CompanyName = company.CompanyName
            };
        }

        #endregion


        #region TODO

        private bool ValidAddressModel(AddressModel address)
        {
            //TODO VALID DATA

            return true;
        }

        private bool ValidCustomerModel(CustomerModel customer)
        {
            //TODO VALID DATA

            return true;
        }

        private bool ValidCreditCardModel(CreditCardModel creditCard)
        {
            //TODO VALID DATA

            return true;
        }

        private bool ValidPaymentModel(PaymentModel payment)
        {
            //TODO VALID DATA

            return true;
        }

        #endregion
    }
}