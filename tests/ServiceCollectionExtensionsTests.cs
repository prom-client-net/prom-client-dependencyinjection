using System;
using Microsoft.Extensions.DependencyInjection;
using Prometheus.Client.Collectors;
using Xunit;

namespace Prometheus.Client.DependencyInjection.Tests;

public class ServiceCollectionExtensionsTests
{
    [Fact]
    public void AddMetricFactory_Default()
    {
        var sp = new ServiceCollection()
            .AddMetricFactory()
            .BuildServiceProvider();

        var metricFactory = sp.GetService<IMetricFactory>();
        Assert.NotNull(metricFactory);
    }

    [Fact]
    public void AddMetricFactory_With_Custom_CollectorRegistry()
    {
        var collectorRegistry = new CollectorRegistry();

        var sp = new ServiceCollection()
            .AddMetricFactory(collectorRegistry)
            .BuildServiceProvider();

        var metricFactory = sp.GetService<IMetricFactory>();
        Assert.NotNull(metricFactory);

        var actualCollectorRegistry = sp.GetService<ICollectorRegistry>();
        Assert.Equal(collectorRegistry, actualCollectorRegistry);
        Assert.NotEqual(Metrics.DefaultCollectorRegistry, actualCollectorRegistry);
    }

    [Fact]
    public void AddMetricFactory_With_Default_CollectorRegistry()
    {
        var sp = new ServiceCollection()
            .AddMetricFactory(Metrics.DefaultCollectorRegistry)
            .BuildServiceProvider();

        var metricFactory = sp.GetService<IMetricFactory>();
        Assert.NotNull(metricFactory);
        Assert.Equal(Metrics.DefaultCollectorRegistry, sp.GetService<ICollectorRegistry>());
    }

    [Fact]
    public void AddMetricFactory_Default_With_Null_ServiceCollection()
    {
        Assert.Throws<ArgumentNullException>(() => ((ServiceCollection)null).AddMetricFactory());
    }

    [Fact]
    public void AddMetricFactory_With_Null_ServiceCollection()
    {
        Assert.Throws<ArgumentNullException>(() => ((ServiceCollection)null).AddMetricFactory(Metrics.DefaultCollectorRegistry));
    }

    [Fact]
    public void AddMetricFactory_With_Null_CollectorRegistry()
    {
        var sc = new ServiceCollection();
        Assert.Throws<ArgumentNullException>(() => sc.AddMetricFactory(null));
    }
}
