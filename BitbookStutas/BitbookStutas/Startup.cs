using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BitbookStutas.Startup))]
namespace BitbookStutas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
