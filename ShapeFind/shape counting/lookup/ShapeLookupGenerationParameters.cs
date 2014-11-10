using System.Collections.Generic;
using System.Drawing;
using ShapeFind.shapes;

namespace ShapeFind.lookup
{
    class ShapeLookupGenerationParameters
    {
        public List<Shape> ShapeList { get; set; }
        public Size ImageSize { get; set; }

        public ShapeLookupGenerationParameters(List<Shape> shapeList, Size imageSize)
        {
            ShapeList = shapeList;
            ImageSize = imageSize;
        }
    }
}
