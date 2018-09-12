using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EngApplication.Startup))]
namespace EngApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
