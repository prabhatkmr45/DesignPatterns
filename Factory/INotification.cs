namespace Factory;

// Product contract: client code can use every notification type uniformly.
public interface INotification
{
    void Send(string message);
}
