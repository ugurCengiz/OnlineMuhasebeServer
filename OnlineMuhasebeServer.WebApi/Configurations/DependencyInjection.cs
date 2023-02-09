﻿using System.Reflection;

namespace OnlineMuhasebeServer.WebApi.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection InstallServices(this IServiceCollection services, IConfiguration configuration, params Assembly[] assemblies)
        {
            IEnumerable<IServiceInstaller> serviceInstallers = assemblies
                .SelectMany(x => x.DefinedTypes)
                .Where(IsAssignableToType<IServiceInstaller>)
                .Select(Activator.CreateInstance)
                .Cast<IServiceInstaller>();

            foreach (IServiceInstaller serviceInstaller in serviceInstallers)
            {
                serviceInstaller.Installer(services, configuration);
            }

            return services;

            static bool IsAssignableToType<T>(TypeInfo typeInfo) =>
                typeof(T).IsAssignableFrom(typeInfo) &&
                !typeInfo.IsInterface &&
                !typeInfo.IsAbstract;
        }
    }
}
