using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using ShapeFind.lookup;

namespace ShapeFind.shapes
{
    public class RectangleShape : Shape
    {
        public RectangleShape(Point location, Size size)
            : base(location, size)
        { }

        public RectangleShape(Rectangle area)
            : this(area.Location, area.Size)
        { }

        public override void DrawOn(Graphics graphics)
        {
            graphics.FillRectangle(DrawingPen.Brush,
                ShapeLocation.X, ShapeLocation.Y,
                ShapeSize.Width, ShapeSize.Height);
        }

        public override bool OccupiesPoint(Point point)
        {
            return point.X >= ShapeLocation.X && point.X <= ShapeLocation.X + ShapeSize.Width &&
                   point.Y >= ShapeLocation.Y && point.Y <= ShapeLocation.Y + ShapeSize.Height;
        }

        public override void AddToLookupTable(ShapeLookupTable table)
        {
            foreach (var p in
                from y in Enumerable.Range(ShapeLocation.Y, ShapeSize.Height)
                from x in Enumerable.Range(ShapeLocation.X, ShapeSize.Width)
                select new { x, y })
            {
                table[p.x, p.y]++;
            }
        }
    }
}
