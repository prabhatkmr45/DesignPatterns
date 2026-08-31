namespace Builder;

public interface IComputerBuilder
{
    void Reset();

    void SetProcessor(string processor);

    void SetMemory(int memoryInGb);

    void SetStorage(int storageInGb);

    void SetGraphicsCard(string graphicsCard);

    Computer Build();
}
