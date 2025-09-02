namespace jarai.tdd7.MarsRoverKata;

public class SouthDirection : Direction
{
    private SouthDirection() : base("S")
    {
    }

    public static SouthDirection Instance { get; } = new();

    public override Position MoveForward(Position currentPosition)
    {
        return new Position(currentPosition.X, currentPosition.Y - 1);
    }

    public override Direction TurnLeft()
    {
        return EastDirection.Instance;
    }

    public override Direction TurnRight()
    {
        return WestDirection.Instance;
    }
}