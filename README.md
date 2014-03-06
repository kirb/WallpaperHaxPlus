# WallpaperHaxPlus
Stupid little C# program that "overrides" stupid group policies by displaying a window with the user's set wallpaper on top of the desktop. Stupid little hack. Stupid all the things. More like WallpaperHaxMinus, really. Tested on Windows 7 and 8.1.

[Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0.html)

## Setup
You need to use some ninja skills to set `HKCU\Control Panel\Desktop!Wallpaper` and `HKCU\Control Panel\Desktop!WallpaperStyle`.

I know what you're thinking, and what's probably now in your face: none other than regedit telling you it's been disabled. Group policy's restrictions are actually pretty stupidly simple, and in fact, you probably have PowerShell hiding in your start menu somewhere, not even disabled. You can use that to set those keys. (I won't go into detail there, google for details on PowerShell registry editing.)

But... huh? A dll? Why not an exe? Easy: because in any sane Windows network, executables would be blocked by our best friend group policy, unless they're in `%ProgramFiles%` or `%WinDir%`. The workaround is once again stupidly simple. You can load .NET dlls into PowerShell and run code in them.

```powershell
Add-Type -Path path\to\WallpaperHaxPlus.dll
$hax = New-Object WallpaperHaxPlus.WallpaperForm
$hax.ShowDialog()
```

Can you tell I'm a big fan?

## What's not so cool
* Redraws every time it comes into focus. Blame WinForms.
* Icons are hidden behind the hax window. Along with that devil of a wallpaper you were trying to get rid of in the first place.
* Sometimes decides to be weird when the desktop is redrawn. Like changing your _actual_ wallpaper to solid white.
* Seems to disappear when clicking the show desktop button on 8.1.
* Over all just a really stupid hack.
* Did I mention it's stupid?
* Most importantly, it's a **work in progress.**

## When not to use this
If the machine is running Windows 7 (and probably older versions) and has a program such as IrfanView which can set your wallpaper, by all means, use that instead of this. There's a bug in Windows 7's version of Explorer that allows custom wallpapers to be set via a call to `SystemParametersInfo(SPI_SETDESKWALLPAPER, ...)`. Use it. Cherish it. Before your machine is upgraded.
