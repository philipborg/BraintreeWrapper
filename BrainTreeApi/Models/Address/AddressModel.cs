using BrainTreeApi.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainTreeApi.Models.Address
{
    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string ExtendedAddress { get; set; }
        public string Locality { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string CountryName { get; set; }
        public string CountryCodeAlpha2 { get; set; }
        public string CountryCodeAlpha3 { get; set; }
        public string CountryCodeNumeric { get; set; }
    }
}
