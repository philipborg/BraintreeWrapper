using Braintree;
namespace BrainTreeApi.Common
{
    public sealed class BrainTreeSerivce
    {
        static readonly BrainTreeSerivce _instance = new BrainTreeSerivce();

        //static BraintreeGateway = new 

        public static BrainTreeSerivce Instance
        {
            get
            {
                return _instance;
            }
        }

        private BrainTreeSerivce()
        {
            //var _gateway = new BraintreeGateway
            //{
            //    Environment = Braintree.Environment.SANDBOX,
            //    MerchantId = "",
            //    PublicKey = "",
            //    PrivateKey = ""
            //};
        }
    }
}
// placeholder="testing card is 4111111111111111"
// ( month - 02 / year - 2017)