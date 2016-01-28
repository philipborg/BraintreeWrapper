using BrainTree;
using BrainTreeApp;
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
            Handle.GET("/braintree", () =>
            {
                RootPage master = (RootPage)Self.GET("/braintree/rootpage");
                return master;
            });

            Handle.GET("/braintree/rootpage", () =>
            {
                Session session = Session.Current;

                if (session != null && session.Data != null)
                    return session.Data;

                var standalone = new RootPage();

                if (session == null)
                {
                    session = new Session(SessionOptions.PatchVersioning);
                    standalone.Html = "/BrainTree/RootPage.html";
                }

                standalone.Session = session;
                return standalone;
            });

            Handle.GET("/braintree/app-settings", () =>
            {
                return Db.Scope<Json>(() => {
                    RootPage master = (RootPage)Self.GET("/braintree/rootpage");

                    var page = new AppSettingsPage();

                    master.CurrentPage = page;

                    return master;
                });
            });

            Handle.GET("/braintree/partials/credit-card/{?}", (string basketId) =>
            {
                return Db.Scope<Json>(() =>
                {
                    var page = new CreditCardPage()
                    {
                        Data = Db.SQL<Payable>("SELECT i FROM Payable i WHERE PayableId = ?", basketId).First,
                        Html = "/BrainTree/CreditCard/CreditCardPage.html"
                    };

                    var currentYear = DateTime.Now.Year;
                    
                    for (var n = 0; n < 10; n++)
                    {
                        page.Years.Add(new CreditCardPage.YearsElementJson {
                            Text = (currentYear+n).ToString(),
                            Value = (currentYear+n).ToString(),
                        });
                    }

                    for (var n = 1; n <= 12; n++ )
                    {
                        page.Months.Add(new CreditCardPage.MonthsElementJson {
                            Text = String.Format("{0:00}", n),
                            Value = String.Format("{0:00}", n)
                        });
                    }

                    return page;
                });
            });
        }
    }
}