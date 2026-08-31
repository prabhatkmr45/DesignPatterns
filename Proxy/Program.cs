namespace Proxy;

public interface IImage
{
    void Display();
}

public sealed class HighResolutionImage : IImage
{
    public HighResolutionImage(string fileName)
    {
        FileName = fileName;
        Console.WriteLine($"Loading {fileName} from disk...");
    }

    private string FileName { get; } = string.Empty;
    public void Display() => Console.WriteLine($"Displaying {FileName}.");
}

public sealed class ImageProxy(string fileName) : IImage
{
    private HighResolutionImage? _image;
    public void Display()
    {
        _image ??= new HighResolutionImage(fileName);
        _image.Display();
    }
}

internal static class Program
{
    private static void Main()
    {
        IImage image = new ImageProxy("landscape.png");
        Console.WriteLine("Proxy created; image is not loaded yet.");
        image.Display();
        image.Display();
    }
}
