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
        public void RegisterLauncher()
        {
            Handle.GET("/payment/app-name", () =>
            {
                return new AppName();
            });

            Handle.GET("/payment/app-icon", () =>
            {
                Page p = new Page()
                {
                    Html = "/payment/ViewModels/AppIconPage.html"
                };
                return p;
            });
        }
    }
}
