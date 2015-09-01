using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Wcf;

namespace NancyFX.Hosting.Wcf
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Get uri from configuration
            var uri = "http://localhost:1234";
            var host = new WebServiceHost(typeof (NancyWcfGenericService), new Uri(uri));

            host.AddServiceEndpoint(typeof (NancyWcfGenericService), new WebHttpBinding(), "");

            host.Open();

            Console.ReadKey();

            host.Close();
        }
    }
}
