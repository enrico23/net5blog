using System;
using System.IO;
using dotenv.net;
using Microsoft.Extensions.Hosting;

namespace Blog.Web.Rest
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder ConfigureEnvironmentVariablesFromDotEnvFile(this IHostBuilder hostBuilder)
        {
            const string envLocalFileName = ".env";
            
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            
            DotEnv.Load(options: new DotEnvOptions(envFilePaths: new[] { Path.Combine(baseDirectory, envLocalFileName) }));
            return hostBuilder;
        }
    }
}