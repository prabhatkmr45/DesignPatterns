# Abstract Factory pattern sample

This .NET console project demonstrates the Abstract Factory pattern by creating families of related UI controls without coupling client code to concrete classes.

## Structure

- `IButton` and `ICheckbox` define the abstract products.
- Windows and macOS controls are two concrete product families.
- `IUiFactory` defines how a complete family is created.
- `WindowsUiFactory` and `MacUiFactory` create matching controls for their platforms.
- `Program` renders controls through abstractions and can switch the entire family by receiving a different factory.

Run the sample:

```powershell
dotnet run
```
