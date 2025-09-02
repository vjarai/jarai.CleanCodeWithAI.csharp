namespace jarai.tdd7.MarsRoverKata;

public class WestDirection : Direction
{
    private WestDirection() : base("W")
    {
    }

    public static WestDirection Instance { get; } = new();

    public override Position MoveForward(Position currentPosition)
    {
        return new Position(currentPosition.X, currentPosition.Y - 1);
    }

    public override Direction TurnLeft()
    {
        return SouthDirection.Instance;
    }

    public override Direction TurnRight()
    {
        return NorthDirection.Instance;
    }
}