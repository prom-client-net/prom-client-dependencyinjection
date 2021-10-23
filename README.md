# Prometheus.Client.DependencyInjection

[![NuGet](https://img.shields.io/nuget/v/Prometheus.Client.DependencyInjection.svg)](https://www.nuget.org/packages/Prometheus.Client.DependencyInjection)
[![NuGet](https://img.shields.io/nuget/dt/Prometheus.Client.DependencyInjection.svg)](https://www.nuget.org/packages/Prometheus.Client.DependencyInjection)
[![CI](https://img.shields.io/github/workflow/status/prom-client-net/prom-client-dependencyinjection/%F0%9F%92%BF%20CI%20Master?label=CI&logo=github)](https://github.com/prom-client-net/prom-client-dependencyinjection/actions/workflows/master.yml)
[![codecov](https://codecov.io/gh/prom-client-net/prom-client-dependencyinjection/branch/master/graph/badge.svg?token=ZZZOB10DXK)](https://codecov.io/gh/prom-client-net/prom-client-dependencyinjection)
[![License MIT](https://img.shields.io/badge/license-MIT-green.svg)](https://opensource.org/licenses/MIT)

## Installation

```shell
dotnet add package Prometheus.Client.DependencyInjection
```

## Use

```c#
public IServiceProvider ConfigureServices(IServiceCollection services)
{
    services.AddMetricFactory();
}
```

or compatible with old static code:

```c#
public IServiceProvider ConfigureServices(IServiceCollection services)
{
    services.AddMetricFactory(Metrics.DefaultCollectorRegistry);
}
```

## Contribute

Contributions to the package are always welcome!

* Report any bugs or issues you find on the [issue tracker](https://github.com/prom-client-net/prom-client-dependencyinjection/issues).
* You can grab the source code at the package's [git repository](https://github.com/prom-client-net/prom-client-dependencyinjection).

## License

All contents of this package are licensed under the [MIT license](https://opensource.org/licenses/MIT).
