using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainTreeApi.Models.CreditCard
{
    public class CreditCardModel
    {
        public string CardNumber { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
        public string SecurityNumber { get; set; }
    }
}
