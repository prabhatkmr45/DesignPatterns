namespace DependencyInjection;

public interface IOrderRepository
{
    void Save(string orderId, string product);
}
