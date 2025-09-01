namespace Liskov;

public class Car
{
    private readonly Engine _engine;
    private readonly string _make;
    private readonly string _model;

    public Car(string make, string model, Engine engine)
    {
        _make = make;
        _model = model;
        _engine = engine;
    }


    public virtual void Drive(int distance)
    {
        _engine.Start();
        Console.WriteLine($"{_make} {_model} is driving for {distance} km.");
        _engine.Stop();
    }
}