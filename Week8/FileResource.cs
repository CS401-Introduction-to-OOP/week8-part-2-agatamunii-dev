namespace Variant1;
public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"Opening {Name}");
    }
    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"Closing {Name}");
    }
    public void Dispose()
    {
        Close();
        Console.WriteLine($"Disposed {Name}");
    }
}
