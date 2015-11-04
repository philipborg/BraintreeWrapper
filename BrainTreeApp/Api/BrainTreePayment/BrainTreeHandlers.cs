using BrainTreePaymentMethod;
using Starcounter;

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

            Handle.GET("/payment/customer-data", () =>
            {
                RootPage master = Self.GET<RootPage>("/payment");

                master.CurrentPage = Db.Scope<CustomerDataPage>(() =>
                {
                    var page = new CustomerDataPage()
                    {
                        Html = "/CustomerData/CustomerDataPage.html"
                    };
                    
                    return page;
                });

                //GETTING DATA FROM PAYABLE SIMPLYFY DATA MODEl

                master.Amount = 696969.69M;
                master.TotalPayableItems = 12;

                return master;
            });

        }
    }
}

//CustomerDataPage customerDataPage;

//if (Session.Current != null && Session.Current.Data != null)
//{
//    customerDataPage = (CustomerDataPage)Session.Current.Data;
//}
//else
//{
//    customerDataPage = new CustomerDataPage();

//    if (Session.Current != null)
//    {
//        customerDataPage.Session = Session.Current;
//    }
//    else
//    {
//        customerDataPage.Session = new Session(SessionOptions.PatchVersioning);
//    }
//}

//customerDataPage.Html = "/CustomerData/CustomerDataPage.html";

//return customerDataPage;


////decimal totalAmount

//CustomerDataPage customerDataPage;

//if (Session.Current != null && Session.Current.Data != null)
//{
//    customerDataPage = (CustomerDataPage)Session.Current.Data;
//}
//else
//{
//    customerDataPage = new CustomerDataPage();

//    if (Session.Current != null)
//    {
//        //customerDataPage.Html = "/LauncherWrapperPage.html";
//        customerDataPage.Session = Session.Current;
//    }
//    else
//    {
//        customerDataPage.Html = "/CustomerData/CustomerDataPage.html";
//        customerDataPage.Session = new Session(SessionOptions.PatchVersioning);
//    }
//}

//var basketViewPage = new BasketViewPage() {
//    Html = "/Basket/BasketViewPage.html"
//};
//basketViewPage.Items = BindSimpleData(basketViewPage);

////show when allready is done
//rootPage.BasketView = basketViewPage;

//var customerDataPage = new CustomerDataPage() {
//    Html = "CustomerData/CustomerDataPage.html"
//};

//return customerDataPage;
