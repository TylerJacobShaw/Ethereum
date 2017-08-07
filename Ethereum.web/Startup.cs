using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ethereum.Web.Startup))]
namespace Ethereum.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
