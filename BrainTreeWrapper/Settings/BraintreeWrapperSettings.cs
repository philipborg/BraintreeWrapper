using Simplified.Ring1;

namespace BraintreeWrapper
{
    public class BrainTreeSettings : Something
    {
        public string Enviroment { get; set; }

        public string MerchantId { get; set; }

        public string PublicKey { get; set; }

        public string PrivateKey { get; set; }
    }
}