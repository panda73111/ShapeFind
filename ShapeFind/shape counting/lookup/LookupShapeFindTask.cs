using System;

namespace ShapeFind.lookup
{
    class LookupShapeFindTask : ShapeFindTask
    {
        public LookupShapeFindTask(ShapeFindParameters parameters)
            : base(FindShapes, parameters)
        {
        }

        private static ShapeFindTaskResult FindShapes(object state)
        {
            DateTime startTime = DateTime.Now;
            ShapeFindParameters parameters = (ShapeFindParameters)state;

            uint shapeCount = parameters.LookupTable[parameters.Point];

            return new ShapeFindTaskResult(shapeCount, DateTime.Now - startTime);
        }
    }
}
