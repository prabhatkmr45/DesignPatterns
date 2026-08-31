namespace DependencyInjection;

// Abstraction for persistence; consumers do not depend on a storage technology.
public interface IOrderRepository
{
    void Save(string orderId, string product);
}
