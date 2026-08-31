using System.Collections;

namespace Iterator;

// Iterator sample: Playlist owns the collection, while PlaylistIterator tracks traversal state.
// IEnumerable support lets clients traverse with foreach without accessing the internal list.
public sealed class Playlist : IEnumerable<string>
{
    private readonly List<string> _songs = [];
    public void Add(string song) => _songs.Add(song);
    public IEnumerator<string> GetEnumerator() => new PlaylistIterator(_songs);
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public sealed class PlaylistIterator(IReadOnlyList<string> songs) : IEnumerator<string>
{
    private int _index = -1;
    public string Current => songs[_index];
    object IEnumerator.Current => Current;
    public bool MoveNext() => ++_index < songs.Count;
    public void Reset() => _index = -1;
    public void Dispose() { }
}

internal static class Program
{
    private static void Main()
    {
        Playlist playlist = new();
        playlist.Add("First song");
        playlist.Add("Second song");
        foreach (string song in playlist) Console.WriteLine(song);
    }
}
