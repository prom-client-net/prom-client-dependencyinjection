[bmac]: https://www.buymeacoffee.com/phnx47
[ko-fi]: https://ko-fi.com/phnx47
[patreon]: https://www.patreon.com/phnx47

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

If you like what I'm accomplishing, feel free to buy me a coffee

[<img align="left" alt="phnx47 | Buy Me a Coffe" width="32px" src="https://raw.githubusercontent.com/phnx47/files/master/button-sponsors/bmac0.png" />][bmac]
[<img align="left" alt="phnx47 | Kofi" width="32px" src="https://raw.githubusercontent.com/phnx47/files/master/button-sponsors/kofi0.png" />][ko-fi]
[<img align="left" alt="phnx47 | Patreon" width="32px" src="https://raw.githubusercontent.com/phnx47/files/master/button-sponsors/patreon0.png" />][patreon]

<br />

## License

All contents of this package are licensed under the [MIT license](https://opensource.org/licenses/MIT).
