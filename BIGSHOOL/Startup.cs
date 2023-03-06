using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BIGSHOOL.Startup))]
namespace BIGSHOOL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
