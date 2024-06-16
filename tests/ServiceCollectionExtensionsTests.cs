using Microsoft.Extensions.DependencyInjection;
using Prometheus.Client.Collectors;
using Xunit;

namespace Prometheus.Client.DependencyInjection.Tests;

public class ServiceCollectionExtensionsTests
{
    [Fact]
    public void Check_AddMetricFactory()
    {
        var sp = new ServiceCollection()
            .AddMetricFactory()
            .BuildServiceProvider();

        var metricFactory = sp.GetService<IMetricFactory>();
        Assert.NotNull(metricFactory);
    }

    [Fact]
    public void Check_AddMetricFactory_Custom_CollectorRegistry()
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
    public void Check_AddMetricFactory_Default_CollectorRegistry()
    {
        var sp = new ServiceCollection()
            .AddMetricFactory(Metrics.DefaultCollectorRegistry)
            .BuildServiceProvider();

        var metricFactory = sp.GetService<IMetricFactory>();
        Assert.NotNull(metricFactory);
        Assert.Equal(Metrics.DefaultCollectorRegistry, sp.GetService<ICollectorRegistry>());
    }
}
