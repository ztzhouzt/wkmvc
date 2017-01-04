using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wkmvc.Startup))]
namespace wkmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
