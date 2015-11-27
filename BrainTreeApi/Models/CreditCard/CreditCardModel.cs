using System.Xml.Serialization;

namespace BrainTreeApi.Models.CreditCard
{
    public class CreditCardModel
    {
        public string CardNumber { get; set; }

        public int ExpiryMonth { get; set; }

        public int ExpiryYear { get; set; }

        [XmlIgnoreAttribute]
        public string SecurityNumber { get; set; }
    }
}
