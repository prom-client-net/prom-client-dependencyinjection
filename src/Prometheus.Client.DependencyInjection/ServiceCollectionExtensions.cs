using Microsoft.Extensions.DependencyInjection;
using Prometheus.Client.Abstractions;
using Prometheus.Client.Collectors;
using Prometheus.Client.Collectors.Abstractions;

namespace Prometheus.Client.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMetricFactory(this IServiceCollection services)
        {
            services.AddSingleton<ICollectorRegistry, CollectorRegistry>();
            services.AddSingleton<IMetricFactory, MetricFactory>();
        }
    }
}
