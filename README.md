# Dock

[![CI](https://github.com/dmirmilshteyn/EmberDock/actions/workflows/build.yml/badge.svg)](https://github.com/dmirmilshteyn/EmberDock/actions/workflows/publish-nightly.yml)

[![NuGet](https://img.shields.io/nuget/v/Dock.Model.svg)](https://www.nuget.org/packages/EmberDock)
[![NuGet](https://img.shields.io/nuget/dt/Dock.Model.svg)](https://www.nuget.org/packages/EmberDock)

A docking layout system.

## About

**Dock** is a docking layout system for [Avalonia](https://github.com/AvaloniaUI/Avalonia) applications. Use of Dock is governed by the MIT License.

[![Dock](images/Dock.png)](images/Dock.png)

## Building Dock

First, clone the repository or download the latest zip.
```
git clone https://github.com/dmirmilshteyn/EmberDock.git
```

### Build using .NET Core

Open up a terminal prompt and execute the commands.

Target framework `netstandard2.0`:
```bash
dotnet build src/Dock.Avalonia/Dock.Avalonia.csproj -c Release -f netstandard2.0
```

## NuGet

Dock is delivered as a NuGet package.

You can find the packages here [NuGet](https://www.nuget.org/packages/EmberDock.Avalonia/) and install the package like this:

```powershell
Install-Package EmberDock.Avalonia
Install-Package EmberDock.Model.Mvvm
```

## Resources

* [GitHub source code repository.](https://github.com/dmirmilshteyn/EmberDock)

## License

Dock is licensed under the [MIT license](LICENSE.TXT).
