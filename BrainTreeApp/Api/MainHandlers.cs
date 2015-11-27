using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainTreePaymentMethod
{
    public class MainHandlers
    {
        public void RegisterLauncher(string appName, string description)
        {
            Handle.GET("/braintree/app-name", () =>
            {
                return new AppName
                {
                    name = appName,
                    description = description
                };
            });

            Handle.GET("/braintree/app-icon", () =>
            {
                Page p = new Page()
                {
                    Html = "/braintree/AppIconPage.html"
                };
                return p;
            });
        }
    }
}
