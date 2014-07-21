using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCApp3.Web.Startup))]
namespace MVCApp3.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
