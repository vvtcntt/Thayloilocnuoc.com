using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Thayloilocnuoc.Startup))]
namespace Thayloilocnuoc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
