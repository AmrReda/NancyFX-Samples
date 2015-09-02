using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace NancyFX.Hosting.Self
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = "http://locahost:1235";
            var host = new NancyHost(new Uri(uri));


            host.Start();

            Console.ReadKey();

            host.Stop();
        }
    }
}
