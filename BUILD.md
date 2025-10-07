# Build Instructions

## Prerequisites

1. Visual Studio 2019 or later (or Visual Studio 2022 recommended)
2. .NET Framework 4.8 SDK installed
3. SimHub installed (for reference DLLs)

## Building the Plugin

### Option 1: Visual Studio

1. Open `Halcyon.WLED.sln` in Visual Studio
2. Ensure all SimHub DLL references are correctly pointing to your SimHub installation
   - Default path: `C:\Program Files (x86)\SimHub\`
   - Required DLLs:
     - GameReaderCommon.dll
     - SimHub.Plugins.dll
     - SimHub.Logging.dll
     - MahApps.Metro.dll
     - log4net.dll
3. Build the solution (Ctrl+Shift+B or Build → Build Solution)
4. The output DLL will be in the configured output path (default: `..\..\` for Debug builds)

### Option 2: MSBuild Command Line

```bash
# From the project directory
msbuild Halcyon.WLED.sln /p:Configuration=Release
```

## Installation

1. Copy `Halcyon.WLED.dll` to your SimHub installation folder
   - Default: `C:\Program Files (x86)\SimHub\`
2. Start SimHub
3. The plugin should appear in the plugin list
4. Enable the plugin and check "Show in left menu"

## Configuration

The plugin settings are accessible from the SimHub left menu under "WLED":

- **Strip URL**: The hostname or IP address of your WLED device (default: `wled-table.local`)
- **Strip Port**: The UDP port for WLED WARLS protocol (default: `21324`)
- **LED Amount**: Number of LEDs in your strip (default: `60`)
- **LED Offset**: Starting LED index offset (default: `0`)
- **Mirror**: Mirror the RPM display from both ends
- **Center**: Center the RPM display

## Troubleshooting

### Missing DLL References

If you get build errors about missing references:

1. Right-click the project in Solution Explorer
2. Select "Properties"
3. Go to "Reference Paths"
4. Add the path to your SimHub installation

Alternatively, update the `HintPath` in the `.csproj` file to match your SimHub installation location.

### WLED Connection Issues

- Ensure your WLED device is on the same network
- Verify the hostname/IP is correct
- Check that UDP port 21324 is not blocked by firewall
- Test connectivity using ping to your WLED device

## Development

### Testing

1. Build in Debug configuration
2. Copy the DLL to SimHub folder
3. Start SimHub
4. Launch a racing game
5. Monitor RPM display on your WLED strip

### Debugging

To debug the plugin:

1. Build in Debug configuration
2. In Visual Studio, go to Debug → Attach to Process
3. Find and attach to `SimHub.exe`
4. Set breakpoints in your code
5. The debugger will break when the code is executed

## WLED Configuration

On your WLED device:

1. Ensure WLED is running latest firmware (v0.14.0 or later recommended)
2. The plugin uses WARLS protocol (WLED Addressable Realtime Lighting System)
3. Default UDP port is 21324
4. No additional WLED configuration needed - the plugin sends direct LED commands

## References

- [SimHub Official Site](https://www.simhubdash.com/)
- [WLED Official Site](https://kno.wled.ge/)
- [WLED WARLS Protocol Documentation](https://github.com/Aircoookie/WLED/wiki/UDP-Realtime-Control)

