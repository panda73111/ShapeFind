using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ShapeFind.shapes;

namespace ShapeFind.lookup
{
    class GenerateShapeLookupTask : Task<ShapeLookupGenerationResult>
    {
        public GenerateShapeLookupTask(ShapeLookupGenerationParameters parameters)
            : base(GenerateLookup, parameters)
        {
        }

        private static ShapeLookupGenerationResult GenerateLookup(object state)
        {
            DateTime startTime = DateTime.Now;
            ShapeLookupGenerationParameters parameters = (ShapeLookupGenerationParameters)state;
            List<Shape> shapeList = parameters.ShapeList;
            ShapeLookupTable table = new ShapeLookupTable(parameters.ImageSize);

            foreach (Shape s in shapeList)
            {
                s.AddToLookupTable(table);
            }

            return new ShapeLookupGenerationResult(table, DateTime.Now - startTime);
        }
    }
}
