using System;
using System.IO;
using System.Reflection;
using Nancy;

namespace NancyFX.Hosting.Owin.Service
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
        public string GetRootPath()
        {
            var assembly = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();

            var assemblyPath = Path.GetDirectoryName(assembly.Location) ?? Environment.CurrentDirectory;


            //We Want to move two directories up (to the project root).
            //Nancy doesn't allow relative paths for static content,
            //so we make sure we have an  absolute path using GetFullPath(). 
            return Path.GetFullPath(Path.Combine(assemblyPath, "..", ".."));
        }
    }
}
