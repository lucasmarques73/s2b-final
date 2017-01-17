using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S2B_Final.Startup))]
namespace S2B_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
