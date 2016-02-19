using System;

namespace BrainTreeWrapper
{
    public static class BrainTreeConfig
    {
        public static Braintree.Environment GetEnum(string name)
        {
            switch(name)
            {
                case "Development":
                    return Braintree.Environment.DEVELOPMENT;
                case "Sandbox":
                    return Braintree.Environment.SANDBOX;
                case "Production":
                    return Braintree.Environment.PRODUCTION;
                case "Qa":
                    return Braintree.Environment.QA;
                default:
                    return Braintree.Environment.DEVELOPMENT;
            }
        }
    }
}
