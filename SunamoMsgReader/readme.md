# SunamoMsgReader

A wrapper around the [MsgReader](https://www.nuget.org/packages/MsgReader) NuGet package, providing helper utilities for extracting content from Outlook `.msg` files.

## Features

- Extract HTML body from `.msg` files and write to `.html` files
- Async support via `ASYNC` compilation symbol
- Singleton pattern for easy usage

## Usage

```csharp
MsgExtHelper.CreateInstance();
await MsgExtHelper.Instance.WriteBodyToHtmlFile("input.msg", "output.html");
```

## Links

Part of PlatformIndependentNuGetPackages:

- [nuget.org](https://www.nuget.org/profiles/sunamo)
- [GitHub](https://github.com/sunamo/PlatformIndependentNuGetPackages)
- [Developer site](https://sunamo.cz)

Request for new features / bug report / etc: [Mail](mailto:radek.jancik@sunamo.cz) or on GitHub

## Target Frameworks

**TargetFrameworks:** `net10.0;net9.0;net8.0`
