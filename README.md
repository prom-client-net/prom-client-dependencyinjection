# Prometheus.Client.DependencyInjection

[![NuGet](https://img.shields.io/nuget/v/Prometheus.Client.DependencyInjection.svg)](https://www.nuget.org/packages/Prometheus.Client.DependencyInjection)
[![NuGet](https://img.shields.io/nuget/dt/Prometheus.Client.DependencyInjection.svg)](https://www.nuget.org/packages/Prometheus.Client.DependencyInjection)
[![Gitter](https://img.shields.io/gitter/room/PrometheusClientNet/community.svg)](https://gitter.im/PrometheusClientNet/community)
[![CI](https://github.com/PrometheusClientNet/Prometheus.Client.DependencyInjection/workflows/CI/badge.svg)](https://github.com/PrometheusClientNet/Prometheus.Client.DependencyInjection/actions?query=workflow%3ACI)
[![License MIT](https://img.shields.io/badge/license-MIT-green.svg)](https://opensource.org/licenses/MIT) 

## Installation

```shell script
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

* Report any bugs or issues you find on the [issue tracker](https://github.com/PrometheusClientNet/Prometheus.Client.DependencyInjection/issues).
* You can grab the source code at the package's [git repository](https://github.com/PrometheusClientNet/Prometheus.Client.DependencyInjection).

## Support

I would also very much appreciate your support:

<a href="https://www.buymeacoffee.com/phnx47"><img width="32px" src="https://raw.githubusercontent.com/phnx47/files/master/button-sponsors/bmac0.png" alt="Buy Me A Coffee"></a>
<a href="https://ko-fi.com/phnx47"><img width="32px" src="https://raw.githubusercontent.com/phnx47/files/master/button-sponsors/kofi0.png" alt="Support me on ko-fi"></a>
<a href="https://www.patreon.com/phnx47"><img width="32px" src="https://raw.githubusercontent.com/phnx47/files/master/button-sponsors/patreon0.png" alt="Support me on Patreon"></a>

## License

All contents of this package are licensed under the [MIT license](https://opensource.org/licenses/MIT).
