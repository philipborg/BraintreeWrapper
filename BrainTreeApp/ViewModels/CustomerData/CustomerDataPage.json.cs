using Starcounter;
using System;
using BrainTreeApi.Models.Payment;
using BrainTreeApi.Service.TransactionService;
using BrainTreeApi.Models.CreditCard;
using BrainTreeApi.Models.Customer;
using System.Linq;
using System.Collections.Generic;
using FluentValidation.Results;
using BrainTreeApi.Validators.Customer;
using BrainTreeApi.Validators.CreditCard;
using BrainTreeApi.Validators.Payment;

namespace BrainTreePaymentMethod
{
    public partial class CustomerDataPage : Page
    {
        public void BindData(string basketId)
        {
            //var data = Db.SQL<Payable>("SELECT i FROM Payable i WHERE PayableNo = ?", basketId).First;

            //this.Data = default(this.Data);

            //this.Amount = data.TotalGrossPrice;

            //this.TotalPayableItems = data.Items.Count();
        }
        
        void Handle(Input.Pay action)
        {
            //var page = (CustomerDataPage)this;

            //this.Errors.Clear();

            //var formValid = new List<bool>();

            //var addressModel = MappingDataToAddress(page.Address);
            //formValid.Add(ValidAddressModel(addressModel));

            //var customerModel = MappingDataToCustomer(page.Customer);
            //formValid.Add(ValidCustomerModel(customerModel));

            //var companyModel = MappingDataToCompany(page.Company);
            //formValid.Add(ValidCompanyModel(companyModel));

            ////var creditCardModel = MappingDataToCreditCard(page.CreditCard);
            ////formValid.Add(ValidCreditCardModel(creditCardModel));

            //var paymentModel = MappingDataToCreditCard(this);
            //formValid.Add(ValidPaymentModel(paymentModel));

            //var isFormValid = formValid.TrueForAll(jk => { return jk; }) || formValid.TrueForAll(jk => { return !jk; });

            //if(!isFormValid)
            //{
            //    ShowHideDialog();
            //    return;
            //}
            
            //var customer = BrainTreeApi.Service.CustomerServices.Customer.CreateCustomer(customerModel);
            //var customerId = string.Empty;
            //if (!customer.Item1)
            //{
            //    this.Errors.Add(new ErrorsElementJson
            //    {
            //        Error = customer.Item2
            //    });

            //    ShowHideDialog();
            //    return;
            //}

            //customerModel.CustomerId = customer.Item2;

            //var billingAddress = BrainTreeApi.Service.CustomerServices.Customer.CreateAddress(customerModel, addressModel, companyModel);
            //var billingAddressId = string.Empty;

            //if (!billingAddress.Item1)
            //{
            //    this.Errors.Add(new ErrorsElementJson
            //    {
            //        Error = billingAddress.Item2
            //    });

            //    ShowHideDialog();
            //    return;
            //}

            //billingAddressId = billingAddress.Item2;
            //var result = CreateTransaction(customerModel.CustomerId, billingAddressId, creditCardModel, paymentModel);

            //if (!result.Item1)
            //{
            //    this.Errors.Add(new ErrorsElementJson
            //    {
            //        Error = result.Item2
            //    });

            //    ShowHideDialog();
            //    return;
            //}

            //ShowHideDialog();
            //this.RedirectUrl = "/payment/finished";
        }

        //private Tuple<bool, string> CreateTransaction(string customerId, string billingAddressId, CreditCardModel creditCard, PaymentModel payment)
        //{
        //    return BrainTreeApi.Service.TransactionService.Transaction.CreateTransactionWithBillingAddress(customerId, billingAddressId, creditCard, payment);
        //}

        //#region DialogShowHide
        
        //protected void ShowHideDialog(string message = "", bool isProcess = false)
        //{
        //    this.Dialog.IsProcess = isProcess;
        //    this.Dialog.Message = message;
        //}

        //#endregion

        //#region Mapping JSON TO MODEL

        //private AddressModel MappingDataToAddress(CustomerDataPage.AddressJson address)
        //{
        //    return new AddressModel
        //    {
        //        StreetAddress = address.StreetAddress,
        //        ExtendedAddress = address.ExtendedAddress,
        //        PostalCode = address.PostalCode,
        //        Locality = address.Locality,
        //        Region = address.Region,
        //        CountryName = address.CountryName,
        //        CountryCodeNumeric = address.CountryCodeNumeric,
        //        CountryCodeAlpha2 = address.CountryCodeAlpha2,
        //        CountryCodeAlpha3 = address.CountryCodeAlpha3,
        //    };
        //}



        //private CompanyModel MappingDataToCompany(CustomerDataPage.CompanyJson company)
        //{
        //    return new CompanyModel
        //    {
        //        CompanyName = company.CompanyName
        //    };
        //}

        //#endregion
        
        //#region CustomValidators

        //private bool ValidCustomerModel(CustomerModel customer)
        //{
        //    this.CustomerErrors = new CustomerErrorsJson();

        //    var isValidCustomer = new CustomerValidator().Validate(customer);

        //    if (isValidCustomer.Errors.Count > 0)
        //    {
        //        foreach (var inValidFields in isValidCustomer.Errors)
        //        {
        //            this.CustomerErrors[inValidFields.PropertyName] = "has-error has-feedbac";
        //        }
        //    }

        //    return isValidCustomer.IsValid;
        //}

        //private bool ValidAddressModel(AddressModel address)
        //{
        //    this.AddressErrors = new AddressErrorsJson();

        //    var isValidAddress = new AddressValidator().Validate(address);

        //    if(isValidAddress.Errors.Count > 0)
        //    {
        //        foreach (var inValidFields in isValidAddress.Errors)
        //        {
        //            this.AddressErrors[inValidFields.PropertyName] = "has-error has-feedbac";
        //        }
        //    }

        //    return isValidAddress.IsValid;
        //}

        //private bool ValidCompanyModel(CompanyModel company)
        //{
        //    this.CompanyErrors = new CompanyErrorsJson();

        //    var isValidCompany = new CompanyValidator().Validate(company);

        //    if (isValidCompany.Errors.Count > 0)
        //    {
        //        foreach (var inValidFields in isValidCompany.Errors)
        //        {
        //            this.CompanyErrors[inValidFields.PropertyName] = "has-error has-feedbac";
        //        }
        //    }

        //    return isValidCompany.IsValid;
        //}

        //private bool ValidCreditCardModel(CreditCardModel creditCard)
        //{
        //    this.CreditCardErrors = new CreditCardErrorsJson();

        //    var isValidCreditCard = new CreditCardValidator().Validate(creditCard);

        //    if(isValidCreditCard.Errors.Count > 0)
        //    { 
        //        foreach (var inValidFields in isValidCreditCard.Errors)
        //        {
        //            this.CreditCardErrors[inValidFields.PropertyName] = "has-error has-feedbac";
        //        }

        //    }
            
        //    return isValidCreditCard.IsValid;
        //}

        //private bool ValidPaymentModel(PaymentModel payment)
        //{
        //    var isValidPayment = new PaymentValidator().Validate(payment);

        //    if (isValidPayment.Errors.Count > 0)
        //    {
        //        foreach (var error in isValidPayment.Errors)
        //        {
        //            this.Errors.Add(new ErrorsElementJson
        //            {
        //                Error = error.ErrorMessage
        //            });
        //        }
        //    }

        //    return isValidPayment.IsValid;
        //}

        //#endregion
    }
}