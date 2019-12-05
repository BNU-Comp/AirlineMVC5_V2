using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AirlineMVC5.Startup))]
namespace AirlineMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
