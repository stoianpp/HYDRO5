using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HydroAsp.Startup))]
namespace HydroAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
