using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Hosting.Wcf;

namespace NancyFX.Hosting.Wcf
{
    public class Bootstraper : DefaultNancyBootstrapper
    {
        protected override IRootPathProvider RootPathProvider
        {
            get { return new ServiceRootProvider(); }
        }
    }

    public class ServiceRootProvider : IRootPathProvider
    {
        private IRootPathProvider provider = new FileSystemRootPathProvider();

        public string GetRootPath()
        {
            return Path.GetFullPath(Path.Combine(provider.GetRootPath(), "..", ".."));
        }
    }
}
