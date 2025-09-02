namespace jarai.tdd7.MarsRoverKata;

public class MarsRover
{
    private readonly Grid _grid;

    private Direction _currentDirection;

    private Position _currentPosition;
    private bool _obstacleDetected;

    public MarsRover()
        : this(new Grid(), new Position(0, 0), NorthDirection.Instance)
    {
    }

    public MarsRover(Grid grid, Position startPosition, Direction startDirection)
    {
        _grid = grid;
        _currentPosition = startPosition;
        _currentDirection = startDirection;
    }

    public Action<string> Logger { get; init; } = _ => { };

    public string ExecuteCommands(string commands)
    {
        var result = "";

        foreach (char command in commands)
        {
            _obstacleDetected = false;

            switch (command)
            {
                case 'M':
                    // MoveForward one Step
                    MoveForward();
                    break;

                case 'L':
                    // Turn Left
                    TurnLeft();
                    break;

                case 'R':
                    // Turn Right
                    TurnRight();
                    break;

                default:
                    throw new ArgumentException($"Unknown command: {command}");
            }

            result = $"{(_obstacleDetected ? "O:" : "")}{_currentPosition}:{_currentDirection}";
            Logger($"{command} => {result}");
        }

        return result;
    }

    internal string TurnRight()
    {
        _currentDirection = _currentDirection.TurnRight();
        return _currentDirection.ToString();
    }

    internal string TurnLeft()
    {
        _currentDirection = _currentDirection.TurnLeft();
        return _currentDirection.ToString();
    }

    internal Position MoveForward()
    {
        var nextPosition = _currentDirection.MoveForward(_currentPosition);

        _obstacleDetected = _grid.HasObstacle(nextPosition);

        if (!_obstacleDetected)
            _currentPosition = nextPosition;

        return _currentPosition;
    }
}