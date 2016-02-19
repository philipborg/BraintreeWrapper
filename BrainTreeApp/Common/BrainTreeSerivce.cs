using System;
using Starcounter;
using Braintree;

namespace BrainTreeWrapper
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