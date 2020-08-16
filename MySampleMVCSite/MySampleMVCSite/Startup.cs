using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySampleMVCSite.Startup))]
namespace MySampleMVCSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
