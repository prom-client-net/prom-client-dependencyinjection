using Microsoft.Extensions.DependencyInjection;
using Prometheus.Client.Collectors;
using Xunit;

namespace Prometheus.Client.DependencyInjection.Tests
{
    public class ServiceCollectionExtensionsTests
    {
        [Fact]
        public void Check_AddMetricFactory()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddMetricFactory();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var metrricFactory = serviceProvider.GetService<IMetricFactory>();
            Assert.NotNull(metrricFactory);
        }

        [Fact]
        public void Check_AddMetricFactory_Custom_CollectorRegistry()
        {
            var collectorRegistry = new CollectorRegistry();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddMetricFactory(collectorRegistry);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var metrricFactory = serviceProvider.GetService<IMetricFactory>();

            Assert.NotNull(metrricFactory);

            var actualCollectorRegistry = serviceProvider.GetService<ICollectorRegistry>();
            Assert.Equal(collectorRegistry, actualCollectorRegistry);
            Assert.NotEqual(Metrics.DefaultCollectorRegistry, actualCollectorRegistry);
        }

        [Fact]
        public void Check_AddMetricFactory_Default_CollectorRegistry()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddMetricFactory(Metrics.DefaultCollectorRegistry);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var metrricFactory = serviceProvider.GetService<IMetricFactory>();

            Assert.NotNull(metrricFactory);

            Assert.Equal(Metrics.DefaultCollectorRegistry, serviceProvider.GetService<ICollectorRegistry>());
        }
    }
}
