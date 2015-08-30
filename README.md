# HEREMapsMVC

*Use at your own risk, work in progress.*

More of the maps REST API's will be supported as I add them.

## Synopsis

Fluent HTML Helpers for MVC .NET for use with the HERE Maps REST API.

## Code Example

Static Map Url (in code): 

```c#
var staticMapUrl = new MapImageBuilder()
  .Zoom(5)
  .AddMarker(new PoiField(64.0000, 150.0000, "custom text"))
  .NoDot(true)
  .ToString();
```

Static map url (in a view):

```html
<img src="@Html.MapImage()
  .Zoom(5)
  .AddMarker(new PoiField(64.0000, 150.0000, "custom text"))
  .NoDot(true)">
```

## Motivation

This library was created to make working with the HERE Maps REST API easier.

## Installation

Add a reference to the DLL in your project and ddd your AppId and AppCode (https://developer.here.com/rest-apis/documentation/enterprise-map-image/common/credentials.html) to your .config file

```xml
<configuration>
  <appSettings>
    <add key="HereMaps.AppCode" value="[YOUR AppCode]"/>
    <add key="HereMaps.AppId" value="[YOUR AppId]"/>
  </appSettings>
  ...
</configuration>
```

## API Reference

HERE Maps API: https://developer.here.com/documentation

Work in progress

## Tests

Work in progress

## Contributors

Work in progress

## License

Use as you see fit.
