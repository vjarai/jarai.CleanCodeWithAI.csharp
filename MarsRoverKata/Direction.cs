namespace jarai.tdd7.MarsRoverKata;

public abstract class Direction
{
    private readonly string _name;


    protected Direction(string name)
    {
        _name = name;
    }


    public override string ToString()
    {
        return _name;
    }

    public abstract Position MoveForward(Position currentPosition);

    public abstract Direction TurnLeft();

    public abstract Direction TurnRight();
}