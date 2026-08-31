namespace SOLID;

// Entry point: runs one independent demonstration for each letter in SOLID.
class Program
{
    static void Main()
    {
        SingleResponsibilityDemo.Run();
        OpenClosedDemo.Run();
        LiskovSubstitutionDemo.Run();
        InterfaceSegregationDemo.Run();
        DependencyInversionDemo.Run();
    }
}
