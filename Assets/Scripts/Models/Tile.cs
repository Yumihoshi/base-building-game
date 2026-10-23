namespace Models
{
    public class Tile
    {
        /// <summary>
        /// 瓦片类型
        /// </summary>
        public enum  TileType
        {
            Empty,
            Floor
        }

        private TileType _type = TileType.Empty;

        private LooseObject _looseObject;
        private InstalledObject _installedObject;

        private World _world;
        private int _x;
        private int _y;
        
        public Tile(World world, int x, int y)
        {
            _world = world;
            _x = x;
            _y = y;
        }
    }
}
