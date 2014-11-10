using System;
using System.Collections.Generic;
using System.Drawing;
using ShapeFind.shapes;

namespace ShapeFind
{
    class ShapeGenerationResult
    {
        public List<Shape> ShapeList { get; set; }
        public Image DrawingImage { get; set; }
        public TimeSpan Runtime { get; set; }

        public ShapeGenerationResult(List<Shape> shapeList, Image drawingImage, TimeSpan runtime)
        {
            ShapeList = shapeList;
            DrawingImage = drawingImage;
            Runtime = runtime;
        }
    }
}
