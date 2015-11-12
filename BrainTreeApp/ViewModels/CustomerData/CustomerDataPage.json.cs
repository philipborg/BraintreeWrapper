using Starcounter;
using System;
using BrainTreeApi.Models.Payment;
using BrainTreeApi.Service.TransactionService;
using BrainTreeApi.Service.CustomerServices;
using BrainTreeApi.Models.Company;
using BrainTreeApi.Models.CreditCard;
using BrainTreeApi.Models.Address;
using BrainTreeApi.Models.Customer;
using System.Linq;
using BrainTreeApi.Validators.Company;
using System.Collections.Generic;
using FluentValidation.Results;
using BrainTreeApi.Validators.Customer;
using BrainTreeApi.Validators.CreditCard;
using BrainTreeApi.Validators.Payment;
using BrainTreeApi.Validators.Address;

namespace BrainTreePaymentMethod
{
    public partial class CustomerDataPage : Page
    {
        public void BindData(int basketNo)
        {
            var data = Db.SQL<Payable>("SELECT i FROM Payable i WHERE PayableNo = ?", basketNo).First;

            this.Data = data;

            this.Amount = data.TotalGrossPrice;

            this.TotalPayableItems = data.Items.Count();
        }
        
        void Handle(Input.Pay action)
        {
            var page = (CustomerDataPage)this;

            this.Errors.Clear();

            bool formIsValid = false;

            var addressModel = MappingDataToAddress(page.Address);
            var isValidAddress = ValidAddressModel(addressModel);
            if(isValidAddress.Count > 0)
            {
                var field = this.AddressErrors as AddressErrorsJson;
                if (field != null)
                {
                    field.StreetAddress = "";
                    field.ExtendedAddress = "";
                    field.Locality = "";
                    field.Region = "";
                    field.PostalCode = "";
                    field.CountryName = "";
                    field.CountryCodeAlpha2 = "";
                    field.CountryCodeAlpha3 = "";
                    field.CountryCodeNumeric = "";
                }

                foreach (var inValidFields in isValidAddress)
                {
                    this.AddressErrors[inValidFields.PropertyName] = "has-error has-feedbac";
                }

                formIsValid = false;
            }

            var customerModel = MappingDataToCustomer(page.Customer);
            var isValidCustomer = ValidCustomerModel(customerModel);
            if(isValidCustomer.Count > 0)
            {
                var field = this.CustomerErrors as CustomerErrorsJson;
                if(field != null)
                {
                    field.FirstName = "";
                    field.LastName = "";
                    field.Phone = "";
                    field.Email = "";
                    field.Fax = "";
                }

                foreach (var inValidFields in isValidCustomer)
                {
                    this.CustomerErrors[inValidFields.PropertyName] = "has-error has-feedbac";
                }

                formIsValid = false;
            }

            var creditCardModel = MappingDataToCreditCard(page.CreditCard);
            var isValidCreditCard = ValidCreditCardModel(creditCardModel);
            if(isValidCreditCard.Count > 0)
            {
                var field = this.CreditCardErrors as CreditCardErrorsJson;
                if (field != null)
                {
                    field.CardNumber = "";
                    field.ExpiryMonth = "";
                    field.ExpiryYear = "";
                    field.SecurityNumber = "";
                }

                foreach (var inValidFields in isValidCreditCard)
                {
                    this.CreditCardErrors[inValidFields.PropertyName] = "has-error has-feedbac";
                }

                formIsValid = false;
            }

            var paymentModel = MappingDataToCreditCard(this);
            var isValidPayment = ValidPaymentModel(paymentModel);

            var company = MappingDataToCompany(page.Company);
            var isValidCompany = ValidCompanyModel(company);
            if(isValidCompany.Count > 0)
            {
                var field = this.CompanyErrors as CompanyErrorsJson;
                if (field != null)
                {
                    field.CompanyName = "";
                }

                foreach (var inValidFields in isValidCompany)
                {
                    this.CompanyErrors[inValidFields.PropertyName] = "has-error has-feedbac";
                }

                formIsValid = false;
            }

            if (!formIsValid) return;

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
                ExpiryMonth = Int32.Parse(creditCard.ExpiryMonth),
                ExpiryYear = Int32.Parse(creditCard.ExpiryYear),
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
        
        #region CustomValidators

        private IList<ValidationFailure> ValidCustomerModel(CustomerModel customer)
        {
            return new CustomerValidator().Validate(customer).Errors;
        }

        private IList<ValidationFailure> ValidAddressModel(AddressModel address)
        {
            return new AddressValidator().Validate(address).Errors;
        }

        private IList<ValidationFailure> ValidCompanyModel(CompanyModel company)
        {
            return new CompanyValidator().Validate(company).Errors;
        }

        private IList<ValidationFailure> ValidCreditCardModel(CreditCardModel creditCard)
        {
            return new CreditCardValidator().Validate(creditCard).Errors;
        }

        private IList<ValidationFailure> ValidPaymentModel(PaymentModel payment)
        {
            return new PaymentValidator().Validate(payment).Errors;
        }

        #endregion
    }
}