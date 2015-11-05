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

            Handle.GET("/payment/{?}/customer-data", (int payableNo) =>
            {
                RootPage master = Self.GET<RootPage>("/payment");

                //GETTING DATA FROM PAYABLE SIMPLIFIED DATA MODEL
                var payable = Db.SQL<Payable>("SELECT i FROM Payable i WHERE PayableNo = ?", payableNo).First;

                master.CurrentPage = Db.Scope<CustomerDataPage>(() =>
                {
                    var page = new CustomerDataPage()
                    {
                        Html = "/CustomerData/CustomerDataPage.html"
                    };

                    page.Amount = payable.TotalGrossPrice;
                    page.TotalPayableItems = payable.Items.Count();

                    return page;
                });

                return master;
            });

        }
    }
}