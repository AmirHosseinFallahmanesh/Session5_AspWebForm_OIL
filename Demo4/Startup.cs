using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo4.Startup))]
namespace Demo4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
