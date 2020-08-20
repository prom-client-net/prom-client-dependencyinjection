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
            services.AddMetricFactory(new CollectorRegistry());
        }

        public static void AddMetricFactory(this IServiceCollection services, ICollectorRegistry collectorRegistry)
        {
            services.AddSingleton(collectorRegistry);
            services.AddSingleton<IMetricFactory, MetricFactory>();
        }
    }
}
