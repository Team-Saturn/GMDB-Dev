using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GMKB_Dev.Startup))]
namespace GMKB_Dev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
