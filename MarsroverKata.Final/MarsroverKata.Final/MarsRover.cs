using System;

namespace CodingDojo3
{
    public class MarsRover
    {
        private readonly Grid _grid;
        private int _x;
        private int _y;
        private Direction _direction;
        private bool _obstacleEncountered;
        private int _lastX;
        private int _lastY;

        public MarsRover(Grid grid)
        {
            _grid = grid;
            _x = 0;
            _y = 0;
            _direction = Direction.N;
            _obstacleEncountered = false;
            _lastX = 0;
            _lastY = 0;
        }

        public string ExecuteCommands(string command)
        {
            foreach (char c in command)
            {
                if (_obstacleEncountered)
                    break;

                switch (c)
                {
                    case 'M':
                        Move();
                        break;
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                }
            }
            var result = _obstacleEncountered
                ? $"O:{_lastX}:{_lastY}:{_direction}"
                : $"{_x}:{_y}:{_direction}";
            return result;
        }

        private void Move()
        {
            int nextX = _x, nextY = _y;
            switch (_direction)
            {
                case Direction.N:
                    nextY = (_y + 1) % _grid.Height;
                    break;
                case Direction.E:
                    nextX = (_x + 1) % _grid.Width;
                    break;
                case Direction.S:
                    nextY = (_y - 1);
                    if (nextY < 0) nextY = _grid.Height - 1;
                    break;
                case Direction.W:
                    nextX = (_x - 1);
                    if (nextX < 0) nextX = _grid.Width - 1;
                    break;
            }

            if (_grid.HasObstacle(nextX, nextY))
            {
                _obstacleEncountered = true;
                _lastX = _x;
                _lastY = _y;
                return;
            }

            _x = nextX;
            _y = nextY;
        }

        private void TurnLeft()
        {
            _direction = (Direction)(((int)_direction + 3) % 4);
        }

        private void TurnRight()
        {
            _direction = (Direction)(((int)_direction + 1) % 4);
        }

        private enum Direction
        {
            N = 0,
            E = 1,
            S = 2,
            W = 3
        }
    }
}