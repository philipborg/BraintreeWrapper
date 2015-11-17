using BrainTreeApi.Models.Setting;
using BrainTreeApi.Validators.Setting;
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
        public static string FileConfigPath { get; set; }

        public static Setting ReadConfig()
        {
            try
            {
                var deserializer = new XmlSerializer(typeof(Setting));

                using (TextReader reader = new StreamReader(FileConfigPath))
                {
                    object obj = deserializer.Deserialize(reader);

                    var setting = (Setting)obj;

                    var isValidSetting = new SettingValidator().Validate(setting);

                    if (!isValidSetting.IsValid)
                        throw new Exception("BrainTree setting is not valid !");

                    return setting;
                }
            }
            catch(Exception ex)
            {
                //TODO LOG ERROR
                throw new Exception(ex.Message);
            }
        }

        public static Braintree.Environment GetEnum(string name)
        {
            switch(name)
            {
                case "Development":
                    return Braintree.Environment.DEVELOPMENT;
                    break;
                case "Sandbox":
                    return Braintree.Environment.SANDBOX;
                    break;
                case "Production":
                    return Braintree.Environment.PRODUCTION;
                    break;
                case "Qa":
                    return Braintree.Environment.QA;
                    break;
                default:
                    return Braintree.Environment.DEVELOPMENT;
            }
        }
    }
}
