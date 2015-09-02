using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(NancyFX.Hosting.Owin.Web.Startup))]

namespace NancyFX.Hosting.Owin.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();

        }
    }
}
