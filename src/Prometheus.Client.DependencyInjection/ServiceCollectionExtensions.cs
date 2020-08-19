using Microsoft.Extensions.DependencyInjection;
using Prometheus.Client.Abstractions;
using Prometheus.Client.Collectors.Abstractions;

namespace Prometheus.Client.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMetricFactory(this IServiceCollection services)
        {
            AddMetricFactory(services, Metrics.DefaultCollectorRegistry);
        }

        public static void AddMetricFactory(this IServiceCollection services, ICollectorRegistry collectorRegistry)
        {
            services.AddSingleton(collectorRegistry);
            services.AddSingleton<IMetricFactory, MetricFactory>();
        }
    }
}
