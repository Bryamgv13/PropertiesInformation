using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using PropertiesInformation.Domain.Services;

namespace PropertiesInformation.Infrastructure
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection svc)
        {
            var _services = AppDomain.CurrentDomain.GetAssemblies()
                .Where(assembly =>
                {
                    return !(assembly.FullName is null) && assembly.FullName.Contains("PropertiesInformation.Domain", StringComparison.InvariantCulture);
                })
                .SelectMany(s => s.GetTypes())
                .Where(p => p.CustomAttributes.Any(x => x.AttributeType == typeof(DomainServiceAttribute)));

            foreach (var _service in _services)
            {
                svc.AddTransient(_service);
            }

            return svc;
        }
    }
}
