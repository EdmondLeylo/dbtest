using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dbtest.Startup))]
namespace dbtest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
