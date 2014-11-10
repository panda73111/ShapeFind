using System.Drawing;

namespace ShapeFind.shapes
{
    public class ShapeAreaBounds
    {
        public Size ImageSize { get; set; }
        public Size MinSize { get; set; }
        public Size MaxSize { get; set; }

        public ShapeAreaBounds(Size imageSize, Size minSize, Size maxSize)
        {
            ImageSize = imageSize;
            MinSize = minSize;
            MaxSize = maxSize;
        }
    }
}
