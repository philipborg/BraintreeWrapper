using BrainTreeApi.Models.Setting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BrainTreeApi.Common
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
