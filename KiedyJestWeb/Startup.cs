using Microsoft.Owin;

[assembly: OwinStartup(typeof(KiedyJestWeb.Startup))]
namespace KiedyJestWeb
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Add whatever you want to do with the OWIN app builder here.
            // Typically the whole authentication layer is added here. Not used in this app at all.
        }
    }
}
