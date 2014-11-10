using System;
using System.Collections.Generic;
using System.Drawing;
using ShapeFind.lookup;

namespace ShapeFind.shapes
{
    interface IDrawable
    {
        void DrawOn(Graphics graphics);
    }

    abstract public class Shape : IDrawable
    {
        protected readonly Point ShapeLocation;
        protected readonly Size ShapeSize;
        protected readonly Pen DrawingPen;

        private static readonly Random Rand = new Random(DateTime.Now.Millisecond);

        protected Shape(Point location, Size size)
        {
            ShapeLocation = location;
            ShapeSize = size;
            Color randomColor = Color.FromArgb(
                Rand.Next(255),
                Rand.Next(255),
                Rand.Next(255));
            DrawingPen = new Pen(randomColor, 1.0f);
        }

        protected Shape(Rectangle area)
            : this(area.Location, area.Size)
        {
        }

        public static Shape FromType(Type type, Point location, Size size)
        {
            if (type == typeof(RectangleShape))
                return new RectangleShape(location, size);
            if (type == typeof(TriangleShape))
                return new TriangleShape(location, size);
            if (type == typeof(EllipticShape))
                return new EllipticShape(location, size);
            throw new NotSupportedException();
        }

        public static Shape FromType(Type type, Rectangle area)
        {
            return FromType(type, area.Location, area.Size);
        }

        public static Type[] GetTypeList(bool rectangles, bool triangles, bool ellipses)
        {
            // a little bit cleaner than creating the shape list dynamicly
            if (rectangles && triangles && ellipses)
                return new[] { typeof(RectangleShape), typeof(TriangleShape), typeof(EllipticShape) };
            if (rectangles && triangles)
                return new[] { typeof(RectangleShape), typeof(TriangleShape) };
            if (rectangles && ellipses)
                return new[] { typeof(RectangleShape), typeof(EllipticShape) };
            if (triangles && ellipses)
                return new[] { typeof(TriangleShape), typeof(EllipticShape) };
            if (rectangles)
                return new[] { typeof(RectangleShape) };
            if (triangles)
                return new[] { typeof(TriangleShape) };
            if (ellipses)
                return new[] { typeof(EllipticShape) };
            return null;
        }

        public static Rectangle GetRandomArea(ShapeAreaBounds bounds)
        {
            int x = Rand.Next(bounds.ImageSize.Width);
            int y = Rand.Next(bounds.ImageSize.Height);
            int w = Rand.Next(bounds.MinSize.Width, bounds.MaxSize.Width);
            int h = Rand.Next(bounds.MinSize.Height, bounds.MaxSize.Height);

            return new Rectangle(x, y, w, h);
        }

        public static Shape GetRandomShape(ShapeAreaBounds bounds, Type[] possibleShapes)
        {
            return GetRandomShape(GetRandomArea(bounds), possibleShapes);
        }

        public static Shape GetRandomShape(Point location,
            Size size, Type[] possibleShapes)
        {
            int shapeIndex = Rand.Next(possibleShapes.Length);
            return FromType(possibleShapes[shapeIndex],
                location, size);
        }

        public static Shape GetRandomShape(Rectangle area, Type[] possibleShapes)
        {
            return GetRandomShape(area.Location, area.Size, possibleShapes);
        }

        public abstract void DrawOn(Graphics graphics);

        public abstract bool OccupiesPoint(Point point);

        public abstract void AddToLookupTable(ShapeLookupTable table);
    }
}
