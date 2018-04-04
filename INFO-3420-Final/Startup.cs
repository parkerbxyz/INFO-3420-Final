using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(INFO_3420_Final.Startup))]
namespace INFO_3420_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
