using BraintreeWrapper.ViewModels;
using Starcounter;

namespace BraintreeWrapper.Api
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
            Handle.GET("/braintreewrapper/app-name", () =>
            {
                return new AppName();
            });

            Handle.GET("/braintreewrapper/menu", () =>
            {
                Page p = new Page()
                {
                    Html = "/braintreewrapper/AppMenuPage.html"
                };
                return p;
            });
        }
        private void RegisterBrainTreeHandlers()
        {
            Handle.GET("/braintreewrapper", () =>
            {
                RootPage master = (RootPage)Self.GET("/braintreewrapper/rootpage");
                return master;
            });

            Handle.GET("/braintreewrapper/rootpage", () =>
            {
                Session session = Session.Current;

                if (session != null && session.Data != null)
                    return session.Data;

                var standalone = new RootPage();

                if (session == null)
                {
                    session = new Session(SessionOptions.PatchVersioning);
                    standalone.Html = "/braintreewrapper/RootPage.html";
                }

                standalone.Session = session;
                return standalone;
            });

            Handle.GET("/braintreewrapper/settings", () =>
            {
                return Db.Scope(() =>
                {
                    RootPage master = (RootPage)Self.GET("/braintreewrapper/rootpage");

                    var page = new AppSettingsPage();

                    var settings = Db.SQL<BraintreeSettings>("SELECT i FROM BrainTreeSettings i").First;

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
            UriMapping.Map("/braintreewrapper/settings", UriMapping.MappingUriPrefix + "/settings");
            UriMapping.Map("/braintreewrapper/menu", UriMapping.MappingUriPrefix + "/menu");
            UriMapping.Map("/braintreewrapper/app-name", UriMapping.MappingUriPrefix + "/app-name");
        }
    }
}
