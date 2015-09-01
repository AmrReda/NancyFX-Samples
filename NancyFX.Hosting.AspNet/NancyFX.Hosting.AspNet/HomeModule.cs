using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace NancyFX.Hosting.AspNet
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Hello Nancy from Amr Reda";
            Get["/home"] = _ => View["home"];
        }
    }
}
