using BraintreeWrapper.Api;

namespace BraintreeWrapper
{
    class Program
    {
        static void Main()
        {
            var mainHandlers = new MainHandlers();
            mainHandlers.Register();

            var hooks = new CommitHooks();
            hooks.Register();
        }
    }
}