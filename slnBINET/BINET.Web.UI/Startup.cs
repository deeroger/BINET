using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BINET.Web.UI.Startup))]
namespace BINET.Web.UI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
