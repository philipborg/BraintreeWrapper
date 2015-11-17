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
using BrainTreeApi.Common;

namespace BrainTreeApi.Service.CustomerServices
{
    public static class Customer
    {
        public static Tuple<bool, string> CreateCustomer(CustomerModel customer)
        {
            BrainTreeConfig.ReadConfig();

            var request = new CustomerRequest
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Phone = customer.Phone
            };

            var result = BrainTreeSerivce.Instance.GetBrainTreeGateway().Customer.Create(request);
            
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

            var result = BrainTreeSerivce.Instance.GetBrainTreeGateway().Address.Create(customer.CustomerId, request);

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
