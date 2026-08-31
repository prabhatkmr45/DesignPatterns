# SOLID principles sample

This .NET console project contains a focused example of each SOLID object-oriented design principle.

## Principles demonstrated

- **Single Responsibility Principle:** invoice calculation and persistence are handled by separate classes.
- **Open/Closed Principle:** new discount policies can be added without modifying `PriceCalculator`.
- **Liskov Substitution Principle:** standard and express shipping can both replace the `ShippingMethod` abstraction without breaking checkout.
- **Interface Segregation Principle:** printing and scanning use small, capability-specific interfaces.
- **Dependency Inversion Principle:** `NotificationService` depends on `IMessageSender`, not a concrete email implementation.

Run all five examples:

```powershell
dotnet run
```
