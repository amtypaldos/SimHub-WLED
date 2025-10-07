# Changelog

## Version 2.0.0 (2025-10-07)

### Updated for Latest SimHub Compatibility

This release updates the plugin to work with the latest version of SimHub with improved code quality and best practices.

#### Breaking Changes
- None - backward compatible with existing configurations

#### Improvements

1. **WLEDSettings.cs**
   - Converted public fields to properties with getters/setters
   - Ensures proper JSON serialization/deserialization
   - All settings now use modern C# property syntax with default values

2. **WLEDHelper.cs**
   - Implemented `IDisposable` pattern for proper resource management
   - Added proper disposal of `UdpClient` to prevent resource leaks
   - Removed unnecessary using statements that could cause conflicts
   - Added finalizer for safety

3. **WLED.cs**
   - Updated `End()` method to properly dispose of `LedHelper`
   - Ensures clean shutdown and resource cleanup

4. **Project Configuration**
   - Updated `.csproj` to use latest C# language features (`LangVersion: latest`)
   - Maintains .NET Framework 4.8 target for SimHub compatibility
   - Optimized build configuration

5. **Assembly Information**
   - Updated copyright year to 2025
   - Bumped version to 2.0.0
   - Added proper assembly description

#### Technical Details

- Target Framework: .NET Framework 4.8
- C# Language Version: Latest
- SimHub Plugin API: Compatible with latest version
- WLED Protocol: WARLS (WLED Address Realttime Protocol)

#### How to Update

1. Download the new `Halcyon.WLED.dll` from releases
2. Replace the old DLL in your SimHub installation folder
3. Restart SimHub
4. Your existing settings will be preserved

#### Notes for Developers

- The plugin now follows proper dispose patterns
- All settings use properties for better serialization
- Code is cleaner with removed unused dependencies
- Ready for future SimHub updates

