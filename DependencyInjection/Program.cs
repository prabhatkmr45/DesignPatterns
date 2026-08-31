namespace DependencyInjection;

// Composition root: registers mappings and lifetimes, builds the container, and resolves the application service.
class Program
{
    static void Main()
    {
        ServiceCollection services = new();

        services.AddSingleton<IOrderRepository, InMemoryOrderRepository>();
        services.AddTransient<INotificationService, EmailNotificationService>();
        services.AddTransient<OrderProcessor>();

        using ServiceProvider serviceProvider = services.BuildServiceProvider();

        OrderProcessor processor = serviceProvider.GetRequiredService<OrderProcessor>();
        processor.PlaceOrder("ORD-1001", "Mechanical keyboard");
    }
}
