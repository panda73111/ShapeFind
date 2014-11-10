using System.Collections.Generic;
using System.Drawing;
using ShapeFind.lookup;
using ShapeFind.shapes;

namespace ShapeFind
{
    class ShapeFindParameters
    {
        public List<Shape> ShapeList { get; set; }
        public ShapeLookupTable LookupTable { get; set; }
        public Point Point { get; set; }

        public ShapeFindParameters(List<Shape> shapeList, ShapeLookupTable lookupTable, Point point)
        {
            ShapeList = shapeList;
            LookupTable = lookupTable;
            Point = point;
        }
    }
}
