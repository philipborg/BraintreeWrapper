using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Braintree;
using BrainTree;
using Transaction = Braintree.Transaction;

namespace BrainTreePaymentMethod
{
    public class MainHandlers
    {
        public void Register()
        {
            this.RegisterLauncherHooks();
            this.RegisterBrainTreeHandlers();
            this.RegisterMapperHandlers();
        }

        private void RegisterLauncherHooks()
        {
            Handle.GET("/braintree/app-name", () =>
            {
                return new AppName();
            });

            Handle.GET("/braintree/menu", () =>
            {
                Page p = new Page()
                {
                    Html = "/braintree/AppMenuPage.html"
                };
                return p;
            });
        }
        private void RegisterBrainTreeHandlers()
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

            Handle.GET("/braintree/settings", () =>
            {
                return Db.Scope(() =>
                {
                    RootPage master = (RootPage)Self.GET("/braintree/rootpage");

                    var page = new AppSettingsPage();

                    var settings = Db.SQL<BrainTreeSettings>("SELECT i FROM BrainTreeSettings i").First;

                    page.Settings.Enviroment.Items.Add(
                        new AppSettingsPage.SettingsJson.EnviromentJson.ItemsElementJson
                        {
                            Value = "Sandbox",
                            Text = "Sandbox"
                        });

                    page.Settings.Enviroment.Items.Add(
                        new AppSettingsPage.SettingsJson.EnviromentJson.ItemsElementJson
                        {
                            Value = "Production",
                            Text = "Production"
                        });

                    if (settings != null)
                    {
                        page.Settings.Enviroment.Selected = settings.Enviroment;
                        page.Settings.MerchantId = settings.MerchantId;
                        page.Settings.PrivateKey = settings.PrivateKey;
                        page.Settings.PublicKey = settings.PublicKey;
                    }

                    master.CurrentPage = page;

                    return master;
                });
            }, new HandlerOptions { SelfOnly = true });
        }
        private void RegisterMapperHandlers()
        {
            UriMapping.Map("/braintree/settings", UriMapping.MappingUriPrefix + "/settings");
            UriMapping.Map("/braintree/menu", UriMapping.MappingUriPrefix + "/menu");
            UriMapping.Map("/braintree/app-name", UriMapping.MappingUriPrefix + "/app-name");
        }
    }
}
