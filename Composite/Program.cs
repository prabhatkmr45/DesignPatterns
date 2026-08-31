namespace Composite;

public interface IFileSystemItem
{
    int GetSize();
    void Display(string indent = "");
}

public sealed class FileItem(string name, int size) : IFileSystemItem
{
    public int GetSize() => size;
    public void Display(string indent = "") => Console.WriteLine($"{indent}{name} ({size} KB)");
}

public sealed class Folder(string name) : IFileSystemItem
{
    private readonly List<IFileSystemItem> _children = [];
    public void Add(IFileSystemItem item) => _children.Add(item);
    public int GetSize() => _children.Sum(child => child.GetSize());

    public void Display(string indent = "")
    {
        Console.WriteLine($"{indent}{name}/ ({GetSize()} KB)");
        foreach (IFileSystemItem child in _children) child.Display(indent + "  ");
    }
}

internal static class Program
{
    private static void Main()
    {
        Folder root = new("project");
        Folder source = new("src");
        source.Add(new FileItem("Program.cs", 4));
        source.Add(new FileItem("Service.cs", 7));
        root.Add(source);
        root.Add(new FileItem("README.md", 2));
        root.Display();
    }
}
