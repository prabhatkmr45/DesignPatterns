namespace Builder;

// Concrete builder: stores work in progress and returns a finished Computer.
public sealed class ComputerBuilder : IComputerBuilder
{
    private Computer _computer = new();

    public void Reset()
    {
        _computer = new Computer();
    }

    public void SetProcessor(string processor)
    {
        _computer.Processor = processor;
    }

    public void SetMemory(int memoryInGb)
    {
        _computer.MemoryInGb = memoryInGb;
    }

    public void SetStorage(int storageInGb)
    {
        _computer.StorageInGb = storageInGb;
    }

    public void SetGraphicsCard(string graphicsCard)
    {
        _computer.GraphicsCard = graphicsCard;
    }

    public Computer Build()
    {
        Computer result = _computer;
        Reset();
        return result;
    }
}
