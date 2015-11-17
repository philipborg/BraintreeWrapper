using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainTreeApi.Models.Setting
{
    public class Setting
    {
        public string Enviroment { get; set; }
        
        public string MerchantId { get; set; }
        
        public string PublicKey { get; set; }
        
        public string PrivateKey { get; set; }
    }
}