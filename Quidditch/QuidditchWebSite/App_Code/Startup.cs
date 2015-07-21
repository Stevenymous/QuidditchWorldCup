using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuidditchWebSite.Startup))]
namespace QuidditchWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
