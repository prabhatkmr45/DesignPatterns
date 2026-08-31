# Factory pattern sample

This .NET console project uses a factory to create different notification objects without exposing their construction to the client code.

## Structure

- `INotification` defines the common product interface.
- `EmailNotification`, `SmsNotification`, and `PushNotification` are concrete products.
- `NotificationFactory` selects and creates the requested concrete product.
- `Program` works only with `INotification`, so it is decoupled from object construction.

Run the sample:

```powershell
dotnet run
```
