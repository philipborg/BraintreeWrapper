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
                return new AppMenuPage();
            });
        }
        private void RegisterBrainTreeHandlers()
        {
            Handle.GET("/braintreewrapper", () =>
            {
                return Self.GET("/braintreewrapper/settings");
            });

            Handle.GET("/braintreewrapper/rootpage", () =>
            {
                if (Session.Current != null && Session.Current.Data != null)
                    return Session.Current.Data;

                var standalone = new RootPage();

                if (Session.Current == null)
                {
                    Session.Current = new Session(SessionOptions.PatchVersioning);
                }

                standalone.Session = Session.Current;
                return standalone;
            });

            Handle.GET("/braintreewrapper/settings", () =>
            {
                return Db.Scope(() =>
                {
                    RootPage master = (RootPage)Self.GET("/braintreewrapper/rootpage");

                    var page = new AppSettingsPage();

                    var settings = Db.SQL<BraintreeSettings>("SELECT i FROM BrainTreeWrapper.BrainTreeSettings i").First;

                    page.Settings.Environment.Items.Add(
                        new AppSettingsPage.SettingsJson.EnvironmentJson.ItemsElementJson
                        {
                            Value = "Sandbox",
                            Text = "Sandbox"
                        });
                    page.Settings.Environment.Items.Add(
                        new AppSettingsPage.SettingsJson.EnvironmentJson.ItemsElementJson
                        {
                            Value = "Development",
                            Text = "Development"
                        });
                    /* NO DOCUMENTATION FOUND FOR QA environment
                    page.Settings.Environment.Items.Add(
                        new AppSettingsPage.SettingsJson.EnvironmentJson.ItemsElementJson
                        {
                            Value = "Qa",
                            Text = "Qa"
                        });
                        */
                    page.Settings.Environment.Items.Add(
                        new AppSettingsPage.SettingsJson.EnvironmentJson.ItemsElementJson
                        {
                            Value = "Production",
                            Text = "Production"
                        });

                    if (settings != null)
                    {
                        page.Settings.Environment.Selected = settings.Environment;
                        page.Settings.MerchantId = settings.MerchantId;
                        page.Settings.PrivateKey = settings.PrivateKey;
                        page.Settings.PublicKey = settings.PublicKey;
                    }

                    master.CurrentPage = page;

                    return master;
                });
            });
        }
        private void RegisterMapperHandlers()
        {
            Blender.MapUri("/braintreewrapper/settings", "settings");
            Blender.MapUri("/braintreewrapper/menu", "menu");
            Blender.MapUri("/braintreewrapper/app-name", "app-name");
        }
    }
}
