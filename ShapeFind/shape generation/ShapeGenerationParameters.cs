using System;
using System.Drawing;
using ShapeFind.shapes;

namespace ShapeFind
{
    class ShapeGenerationParameters
    {
        public ShapeAreaBounds Bounds { get; set; }
        public Type[] PossibleShapes { get; set; }
        public int ShapeCount { get; set; }
        public Size ImageSize { get; set; }

        private ShapeGenerationParameters(ShapeAreaBounds bounds,
            int shapeCount, Size imageSize)
        {
            Bounds = bounds;
            ShapeCount = shapeCount;
            ImageSize = imageSize;
        }

        public ShapeGenerationParameters(ShapeAreaBounds bounds,
            bool rectangles, bool triangles, bool ellipses,
            int shapeCount, Size imageSize)
            : this(bounds, shapeCount, imageSize)
        {
            PossibleShapes = Shape.GetTypeList(rectangles, triangles, ellipses);
        }

        public ShapeGenerationParameters(ShapeAreaBounds bounds,
            Type[] possibleShapes, int shapeCount, Size imageSize)
            : this(bounds, shapeCount, imageSize)
        {
            PossibleShapes = possibleShapes;
        }
    }
}
