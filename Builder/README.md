# Builder pattern sample

This .NET console project demonstrates the Builder pattern by assembling `Computer` objects one part at a time.

## Structure

- `Computer` is the complex product being constructed.
- `IComputerBuilder` defines the individual construction steps.
- `ComputerBuilder` implements those steps and returns the completed product.
- `ComputerDirector` reuses the steps to create predefined office and gaming configurations.
- `Program` requests configurations without knowing their construction details.

Run the sample:

```powershell
dotnet run
```
