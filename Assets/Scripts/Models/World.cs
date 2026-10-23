using UnityEngine;

namespace Models
{
    public class World
    {
        private Tile[,] _tiles;
        private int _width;
        private int _height;

        public World(int width = 100, int height = 100)
        {
            _width = width;
            _height = height;
            
            _tiles = new Tile[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    _tiles[x, y] = new Tile(this, x, y);
                }
            }
            
            Debug.Log("World initialized with size: " + width + "x" + height);
        }

        public Tile GetTileAt(int x, int y)
        {
            if (x >= _width || x < 0 || y >= _height || y < 0)
            {
                Debug.LogError($"瓦片坐标({x},{y})超出范围，数组索引越界");
                return null;
            }
            return _tiles[x, y];
        }
    }
}
