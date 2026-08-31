namespace Builder;

public sealed class Computer
{
    public string Processor { get; internal set; } = string.Empty;

    public int MemoryInGb { get; internal set; }

    public int StorageInGb { get; internal set; }

    public string? GraphicsCard { get; internal set; }

    public override string ToString()
    {
        string graphics = GraphicsCard ?? "Integrated graphics";
        return $"CPU: {Processor}, RAM: {MemoryInGb} GB, Storage: {StorageInGb} GB, GPU: {graphics}";
    }
}
