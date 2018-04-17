using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webbprojekt_TE15C_1.Startup))]
namespace Webbprojekt_TE15C_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
