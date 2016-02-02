using Braintree;
using System;
namespace BrainTreeApi.Common
{
    public sealed class BrainTreeSerivce
    {
        static BrainTreeSerivce _instance;

        public static BrainTreeSerivce Instance
        {
            get { return _instance ?? (_instance = new BrainTreeSerivce()); }
        }

        private BrainTreeSerivce() { }

        public BraintreeGateway GetBrainTreeGateway(string enviroment, string merchantId, string publicKey, string privateKey)
        {
            return new BraintreeGateway {
                Environment = BrainTreeConfig.GetEnum(enviroment),
                MerchantId = merchantId,
                PublicKey = publicKey,
                PrivateKey = privateKey
            };
        }
    }
}