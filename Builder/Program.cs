namespace Builder;

// Client: asks the director for predefined builds and consumes the resulting products.
class Program
{
    static void Main()
    {
        ComputerBuilder builder = new();
        ComputerDirector director = new(builder);

        Computer officeComputer = director.BuildOfficeComputer();
        Computer gamingComputer = director.BuildGamingComputer();

        Console.WriteLine("Office computer:");
        Console.WriteLine(officeComputer);

        Console.WriteLine("\nGaming computer:");
        Console.WriteLine(gamingComputer);
    }
}
