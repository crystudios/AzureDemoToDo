using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(crystudiosService.Startup))]

namespace crystudiosService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}