# Singleton pattern sample

This console project demonstrates a thread-safe, lazily initialized Singleton in C#.

The `Logger` class:

- is `sealed`, so it cannot be inherited;
- has a private constructor, so callers cannot create instances;
- exposes one shared instance through `Logger.Instance`;
- uses `Lazy<T>`, which provides lazy initialization and thread safety.

Run the sample:

```powershell
dotnet run
```

The final output line is `Same instance: True`, confirming that both references point to the same object.
