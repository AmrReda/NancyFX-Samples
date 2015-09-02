using Microsoft.Owin;
using NancyFX.Hosting.Owin.Service;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace NancyFX.Hosting.Owin.Service
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();

        }
    }
}
