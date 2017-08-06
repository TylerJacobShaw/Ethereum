using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ethereum.web.Startup))]
namespace Ethereum.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
