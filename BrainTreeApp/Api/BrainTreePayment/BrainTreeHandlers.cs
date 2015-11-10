using BrainTreePaymentMethod;
using Starcounter;
using System;
using System.Linq;

namespace BrainTreePaymentMethod
{
    public class BrainTreeHandlers
    {
        public void RegisterBrainTreeHandlers()
        {
            Handle.GET("/payment", () =>
            {
                RootPage master = (RootPage)Self.GET("/payment/rootpage");
                return master;
            });

            Handle.GET("/payment/rootpage", () =>
            {
                Session session = Session.Current;

                if (session != null && session.Data != null)
                    return session.Data;

                var standalone = new RootPage();

                if (session == null)
                {
                    session = new Session(SessionOptions.PatchVersioning);
                    standalone.Html = "/RootPage.html";
                }

                standalone.Session = session;
                return standalone;
            });

            Handle.GET("/payment/{?}/customer-data", (int basketNo) =>
            {
                RootPage master = Self.GET<RootPage>("/payment");

                master.CurrentPage = Db.Scope<CustomerDataPage>(() => {
                    var page = new CustomerDataPage();
                    
                    page.BindData(basketNo);

                    return page;
                });

                return master;
            });
        }
    }
}