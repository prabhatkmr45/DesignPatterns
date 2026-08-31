namespace Memento;

// Memento sample: EditorMemento captures originator state and History is its caretaker.
// TextEditor creates and restores snapshots without exposing restoration logic to the client.
public sealed record EditorMemento(string Text);

public sealed class TextEditor
{
    public string Text { get; set; } = string.Empty;
    public EditorMemento Save() => new(Text);
    public void Restore(EditorMemento memento) => Text = memento.Text;
}

public sealed class History
{
    private readonly Stack<EditorMemento> _states = [];
    public void Push(EditorMemento state) => _states.Push(state);
    public EditorMemento Undo() => _states.Pop();
}

internal static class Program
{
    private static void Main()
    {
        TextEditor editor = new() { Text = "Version 1" };
        History history = new();
        history.Push(editor.Save());
        editor.Text = "Version 2";
        Console.WriteLine(editor.Text);
        editor.Restore(history.Undo());
        Console.WriteLine($"After undo: {editor.Text}");
    }
}
