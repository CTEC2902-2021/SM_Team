using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Football.Startup))]
namespace Football
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
