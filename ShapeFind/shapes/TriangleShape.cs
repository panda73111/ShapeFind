using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using ShapeFind.lookup;

namespace ShapeFind.shapes
{
    public class TriangleShape : Shape
    {
        private readonly Point[] _points;

        public TriangleShape(Point location, Size size)
            : base(location, size)
        {
            _points = new[]
            {
                new Point(location.X, location.Y),
                new Point(location.X + size.Width, location.Y),
                new Point(location.X + size.Width/2, location.Y + size.Height)
            };
        }

        public TriangleShape(Rectangle area)
            : this(area.Location, area.Size)
        { }

        public override void DrawOn(Graphics graphics)
        {
            graphics.FillPolygon(DrawingPen.Brush, _points);
        }

        private bool OccupiesPoint(int x, int y)
        {
            // innerPercX: [0:1] from X=0 to X=ShapeSize.Width within shape area
            // innerPercY: [0:1] from Y=0 to Y=ShapeSize.Height within shape area
            float innerPercX = (float)(x - ShapeLocation.X) / ShapeSize.Width;
            float innerPercY = (float)(y - ShapeLocation.Y) / ShapeSize.Height;
            return
                innerPercY >= 0 &&                 // above bottom line (y=0)
                innerPercY <= 2 * innerPercX &&    // right-side of left line (y=2x)
                innerPercY <= -2 * innerPercX + 2; // left-side of right line (y=-2x+2)
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
