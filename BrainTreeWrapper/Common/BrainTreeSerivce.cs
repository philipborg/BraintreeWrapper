using Braintree;

namespace BraintreeWrapper.Common
{
    public sealed class BrainTreeSerivce
    {
        static BrainTreeSerivce _instance;

        public static BrainTreeSerivce Instance
        {
            get { return _instance ?? (_instance = new BrainTreeSerivce()); }
        }

        private BrainTreeSerivce() { }

        public BraintreeGateway GetBrainTreeGateway(BrainTreeSettings config)
        {
            return new BraintreeGateway
            {
                Environment = BrainTreeConfig.GetEnum(config.Enviroment),
                MerchantId = config.MerchantId,
                PublicKey = config.PublicKey,
                PrivateKey = config.PrivateKey
            };
        }
    }
}