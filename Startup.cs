using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MWightPorfolio.Startup))]
namespace MWightPorfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
