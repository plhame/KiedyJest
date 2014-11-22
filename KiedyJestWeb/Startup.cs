using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KiedyJestWeb.Startup))]
namespace KiedyJestWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
