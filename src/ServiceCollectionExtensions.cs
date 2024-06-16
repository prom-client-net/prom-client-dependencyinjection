using System;
using Microsoft.Extensions.DependencyInjection;
using Prometheus.Client.Collectors;

namespace Prometheus.Client.DependencyInjection;

public static class ServiceCollectionExtensions
{
    /// <summary>
    ///     Add IMetricFactory and ICollectorRegistry into service collection
    /// </summary>
    /// <param name="services">Service collection</param>
    public static IServiceCollection AddMetricFactory(this IServiceCollection services)
    {
        if (services == null)
            throw new ArgumentNullException(nameof(services));

        services.AddSingleton<ICollectorRegistry, CollectorRegistry>();
        services.AddSingleton<IMetricFactory, MetricFactory>();
        return services;
    }

    /// <summary>
    ///     Add IMetricFactory and ICollectorRegistry into service collection
    /// </summary>
    /// <param name="services">Service collection</param>
    /// <param name="collectorRegistry">Explicit collector registry to use</param>
    public static IServiceCollection AddMetricFactory(this IServiceCollection services, ICollectorRegistry collectorRegistry)
    {
        if (services == null)
            throw new ArgumentNullException(nameof(services));
        if (collectorRegistry == null)
            throw new ArgumentNullException(nameof(collectorRegistry));

        services.AddSingleton(collectorRegistry);
        services.AddSingleton<IMetricFactory, MetricFactory>();
        return services;
    }
}
