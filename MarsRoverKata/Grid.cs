namespace jarai.tdd7.MarsRoverKata;

public class Grid
{
    private readonly List<Position> _obstaclePositions = new();

    public void AddObstacle(Position obstaclePosition)
    {
        _obstaclePositions.Add(obstaclePosition);
    }

    public bool HasObstacle(Position position)
    {
        return _obstaclePositions.Any(p => p.Equals(position));
    }
}