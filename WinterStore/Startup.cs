using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WinterStore.Startup))]
namespace WinterStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
