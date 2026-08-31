namespace Builder;

// Builder contract: defines each construction step independently of a final configuration.
public interface IComputerBuilder
{
    void Reset();

    void SetProcessor(string processor);

    void SetMemory(int memoryInGb);

    void SetStorage(int storageInGb);

    void SetGraphicsCard(string graphicsCard);

    Computer Build();
}
