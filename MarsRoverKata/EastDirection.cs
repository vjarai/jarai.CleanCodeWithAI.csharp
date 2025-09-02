namespace jarai.tdd7.MarsRoverKata;

public class EastDirection : Direction
{
    private EastDirection() : base("E")
    {
    }

    public static EastDirection Instance { get; } = new();

    public override Position MoveForward(Position currentPosition)
    {
        return new Position(currentPosition.X + 1, currentPosition.Y);
    }

    public override Direction TurnLeft()
    {
        return NorthDirection.Instance;
    }

    public override Direction TurnRight()
    {
        return SouthDirection.Instance;
    }
}