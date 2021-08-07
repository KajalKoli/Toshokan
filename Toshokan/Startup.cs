using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Toshokan.Startup))]
namespace Toshokan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
