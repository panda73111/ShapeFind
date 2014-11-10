using System.Drawing;

namespace ShapeFind.lookup
{
    public class ShapeLookupTable
    {
        private readonly uint[,] _table;
        private readonly int _width;
        private readonly int _height;

        public uint this[int x, int y]
        {
            get
            {
                if (x >= 0 && x < _width && y >= 0 && y < _height)
                    return _table[x, y];
                return 0;
            }
            set
            {
                if (x >= 0 && x < _width && y >= 0 && y < _height)
                    _table[x, y] = value;
            }
        }

        public uint this[Point p]
        {
            get { return this[p.X, p.Y]; }
            set { this[p.X, p.Y] = value; }
        }

        public ShapeLookupTable(Size imageSize)
        {
            _width = imageSize.Width;
            _height = imageSize.Height;
            _table = new uint[imageSize.Width, imageSize.Height];
        }
    }
}
