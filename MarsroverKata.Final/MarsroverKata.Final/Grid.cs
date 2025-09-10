using System.Collections.Generic;

namespace CodingDojo3
{
    public class Grid
    {
        public int Width { get; }
        public int Height { get; }
        private readonly HashSet<(int x, int y)> _obstacles;

        public Grid(int width, int height, IEnumerable<(int x, int y)> obstacles = null)
        {
            Width = width;
            Height = height;
            _obstacles = obstacles != null
                ? new HashSet<(int x, int y)>(obstacles)
                : new HashSet<(int x, int y)>();
        }

        public bool HasObstacle(int x, int y) => _obstacles.Contains((x, y));
    }
}