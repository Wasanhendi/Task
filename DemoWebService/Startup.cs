using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoWebService.Startup))]
namespace DemoWebService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
