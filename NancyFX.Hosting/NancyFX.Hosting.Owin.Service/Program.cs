using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace NancyFX.Hosting.Owin.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = "http://+:8820";
            using (WebApp.Start<Startup>(uri))
            {
                Console.ReadLine();
            }
        }
    }
}
