using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhysicLeaner.Startup))]
namespace PhysicLeaner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
