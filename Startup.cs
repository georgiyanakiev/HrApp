using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HrApp.Startup))]
namespace HrApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
