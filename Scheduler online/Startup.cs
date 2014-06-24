using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scheduler_online.Startup))]
namespace Scheduler_online
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
