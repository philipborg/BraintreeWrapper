using BrainTreeApi.Models.Address;

namespace BrainTreeApi.Models.Customer
{
    public class CustomerModel
    {
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
    }
}
