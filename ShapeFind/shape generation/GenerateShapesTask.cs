using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using ShapeFind.shapes;

namespace ShapeFind
{
    class GenerateShapesTask : Task<ShapeGenerationResult>
    {
        public GenerateShapesTask(ShapeGenerationParameters parameters)
            : base(GenerateShapes, parameters)
        { }

        private static ShapeGenerationResult GenerateShapes(Object state)
        {
            DateTime startTime = DateTime.Now;
            ShapeGenerationParameters parameters = (ShapeGenerationParameters)state;
            Image img = new Bitmap(parameters.ImageSize.Width, parameters.ImageSize.Height);
            List<Shape> shapeList = new List<Shape>(parameters.ShapeCount);

            if (parameters.PossibleShapes == null ||
                parameters.PossibleShapes.Length == 0)
            {
                return new ShapeGenerationResult(shapeList, img, DateTime.Now - startTime);
            }

            using (Graphics g = Graphics.FromImage(img))
            {
                g.TranslateTransform(0, img.Height);
                g.ScaleTransform(1, -1);
                for (int i = parameters.ShapeCount; i > 0; i--)
                {
                    Shape s = Shape.GetRandomShape(
                        parameters.Bounds,
                        parameters.PossibleShapes);
                    s.DrawOn(g);
                    shapeList.Add(s);
                }
            }
            return new ShapeGenerationResult(shapeList, img, DateTime.Now - startTime);
        }
    }
}
