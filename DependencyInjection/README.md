# Dependency Injection sample

This .NET console project demonstrates constructor injection with Microsoft's built-in dependency-injection container.

## Structure

- `IOrderRepository` and `INotificationService` define service contracts.
- `InMemoryOrderRepository` and `EmailNotificationService` provide concrete implementations.
- `OrderProcessor` declares its dependencies through its constructor and does not create them itself.
- `Program` acts as the composition root: it registers services, builds the container, and resolves the application service.

The repository is registered as a singleton, while the notification service and order processor are transient.

Run the sample:

```powershell
dotnet run
```
