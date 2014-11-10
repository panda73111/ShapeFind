using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using ShapeFind.lookup;

namespace ShapeFind.shapes
{
    public class EllipticShape : Shape
    {
        public EllipticShape(Point location, Size size)
            : base(location, size)
        { }

        public EllipticShape(Rectangle area)
            : this(area.Location, area.Size)
        { }

        public override void DrawOn(Graphics graphics)
        {
            graphics.FillEllipse(DrawingPen.Brush,
                ShapeLocation.X, ShapeLocation.Y,
                ShapeSize.Width, ShapeSize.Height);
        }

        private bool OccupiesPoint(int x, int y)
        {
            // innerPercX: [-1:1] from X=0 to X=ShapeSize.Width within shape area
            // innerPercY: [-1:1] Y=0 to Y=ShapeSize.Height within shape area
            // the circle's center is at 0|0, radius=1
            float innerPercX = (float)(x - ShapeLocation.X) / ShapeSize.Width * 2 - 1;
            float innerPercY = (float)(y - ShapeLocation.Y) / ShapeSize.Height * 2 - 1;
            // at most a distance of 1 away from the center:
            return Math.Sqrt(innerPercX * innerPercX + innerPercY * innerPercY) <= 1;
        }

        public override bool OccupiesPoint(Point point)
        {
            return OccupiesPoint(point.X, point.Y);
        }

        public override void AddToLookupTable(ShapeLookupTable table)
        {

            foreach (var p in
                from y in Enumerable.Range(ShapeLocation.Y, ShapeSize.Height)
                from x in Enumerable.Range(ShapeLocation.X, ShapeSize.Width)
                where OccupiesPoint(x, y)
                select new { x, y })
            {
                table[p.x, p.y]++;
            }
        }
    }
}
