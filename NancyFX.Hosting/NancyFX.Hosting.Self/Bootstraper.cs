using System.IO;
using Nancy;
using Nancy.Hosting.Self;

namespace NancyFX.Hosting.Self
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
