using BraintreeWrapper.Api;
using Starcounter;

namespace BraintreeWrapper
{
    class Program
    {
        static void Main()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            var mainHandlers = new MainHandlers();
            mainHandlers.Register();

            var hooks = new CommitHooks();
            hooks.Register();
        }
    }
}