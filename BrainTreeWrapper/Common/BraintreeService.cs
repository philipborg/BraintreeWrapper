using Braintree;

namespace BraintreeWrapper.Common
{
    public sealed class BraintreeService
    {
        static BraintreeService _instance;

        public static BraintreeService Instance
        {
            get { return _instance ?? (_instance = new BraintreeService()); }
        }

        private BraintreeService() { }

        public BraintreeGateway GetBrainTreeGateway(BraintreeSettings config)
        {
            return new BraintreeGateway
            {
                Environment = BraintreeConfig.GetEnum(config.Environment),
                MerchantId = config.MerchantId,
                PublicKey = config.PublicKey,
                PrivateKey = config.PrivateKey
            };
        }
    }
}