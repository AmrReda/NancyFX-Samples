using Nancy;

namespace NancyFX.Hosting.Wcf
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
