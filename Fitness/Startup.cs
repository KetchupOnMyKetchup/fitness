using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fitness.Startup))]
namespace Fitness
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
