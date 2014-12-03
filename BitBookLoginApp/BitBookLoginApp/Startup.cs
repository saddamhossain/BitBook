using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BitBookLoginApp.Startup))]
namespace BitBookLoginApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
