using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Braintree;
using BrainTreeApi.Models;
using BrainTreeApi.Models.Customer;
using BrainTreeApi.Models.Address;
using BrainTreeApi.Models.Company;

namespace BrainTreeApi.Service.CustomerServices
{
    public static class Customer
    {
        public static Tuple<bool, string> CreateCustomer(CustomerModel customer)
        {
            var request = new CustomerRequest
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Phone = customer.Phone
            };

            var _gateway = new BraintreeGateway {
                Environment = Braintree.Environment.SANDBOX,
                MerchantId = "3t7txmqspfhwygry",
                PublicKey = "xgdnqmpn4qjdvfns",
                PrivateKey = "e288172b64376e5c9e56d2f5b91e0283"
            };

            var result = _gateway.Customer.Create(request);
            
            

            if(result.IsSuccess())
            {
                return new Tuple<bool, string>(result.IsSuccess(), result.Target.Id);
            }
            else
            {
                return new Tuple<bool, string>(result.IsSuccess(), result.Message);
            }
        }

        public static Tuple<bool, string> CreateAddress(CustomerModel customer, AddressModel address, CompanyModel company)
        {
            var request = new AddressRequest
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Company = company == null? string.Empty : company.CompanyName,
                StreetAddress = address.StreetAddress,
                Locality = address.Locality,
                Region = address.Region,
                PostalCode = address.PostalCode,
                CountryCodeAlpha2 = address.CountryCodeAlpha2
            };

            var _gateway = new BraintreeGateway {
                Environment = Braintree.Environment.SANDBOX,
                MerchantId = "3t7txmqspfhwygry",
                PublicKey = "xgdnqmpn4qjdvfns",
                PrivateKey = "e288172b64376e5c9e56d2f5b91e0283"
            };

            var result = _gateway.Address.Create(customer.CustomerId, request);

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
