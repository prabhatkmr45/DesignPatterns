namespace Builder;

// Director: defines reusable construction recipes without knowing product internals.
public sealed class ComputerDirector(IComputerBuilder builder)
{
    public Computer BuildOfficeComputer()
    {
        builder.Reset();
        builder.SetProcessor("Intel Core i5");
        builder.SetMemory(16);
        builder.SetStorage(512);
        return builder.Build();
    }

    public Computer BuildGamingComputer()
    {
        builder.Reset();
        builder.SetProcessor("AMD Ryzen 9");
        builder.SetMemory(32);
        builder.SetStorage(2000);
        builder.SetGraphicsCard("NVIDIA GeForce RTX 4080");
        return builder.Build();
    }
}
