using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoOwin.Startup))]
namespace DemoOwin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
