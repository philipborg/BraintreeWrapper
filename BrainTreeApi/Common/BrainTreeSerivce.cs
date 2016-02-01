using Braintree;
using BrainTreeApi.Enums;
using System;
namespace BrainTreeApi.Common
{
    public sealed class BrainTreeSerivce
    {
        //static BrainTreeSerivce _instance;

        //public static BrainTreeSerivce Instance
        //{
        //    get { return _instance ?? (_instance = new BrainTreeSerivce()); }
        //}

        //private BrainTreeSerivce() { }

        //public BraintreeGateway GetBrainTreeGateway()
        //{
        //    var config = BrainTreeConfig.ReadConfig();

        //    return new BraintreeGateway
        //    {
        //        Environment = BrainTreeConfig.GetEnum(config.Enviroment),
        //        MerchantId = config.MerchantId,
        //        PublicKey = config.PublicKey,
        //        PrivateKey = config.PrivateKey
        //    };
        //}
    }
}