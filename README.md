# Prometheus.Client.DependencyInjection

[![ci](https://img.shields.io/github/actions/workflow/status/prom-client-net/prom-client-dependencyinjection/ci.yml?branch=main&label=ci&logo=github&style=flat-square)](https://github.com/prom-client-net/prom-client-dependencyinjection/actions/workflows/ci.yml)
[![nuget](https://img.shields.io/nuget/v/Prometheus.Client.DependencyInjection?logo=nuget&style=flat-square)](https://www.nuget.org/packages/Prometheus.Client.DependencyInjection)
[![nuget](https://img.shields.io/nuget/dt/Prometheus.Client.DependencyInjection?logo=nuget&style=flat-square)](https://www.nuget.org/packages/Prometheus.Client.DependencyInjection)
[![codecov](https://img.shields.io/codecov/c/github/prom-client-net/prom-client-dependencyinjection?logo=codecov&style=flat-square)](https://app.codecov.io/gh/prom-client-net/prom-client-dependencyinjection)
[![license](https://img.shields.io/github/license/prom-client-net/prom-client-dependencyinjection?style=flat-square)](https://github.com/prom-client-net/prom-client-dependencyinjection/blob/main/LICENSE)

## Install

```sh
dotnet add package Prometheus.Client.DependencyInjection
```

## Use

```c#
public IServiceProvider ConfigureServices(IServiceCollection services)
{
    services.AddMetricFactory();
}
```

or compatible with static `Metrics.DefaultCollectorRegistry`:

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
