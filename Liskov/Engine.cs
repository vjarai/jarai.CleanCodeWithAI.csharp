namespace Liskov;

public class Engine
{
    private int _horsePower;
    private bool _isRunning;

    public Engine(int horsePower)
    {
        _horsePower = horsePower;
        _isRunning = false;
    }

    public virtual void Start()
    {
        _isRunning = true;
        Console.WriteLine("Engine started.");
    }

    public virtual void Stop()
    {
        _isRunning = false;
        Console.WriteLine("Engine stopped.");
    }
}