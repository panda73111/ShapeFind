using System;

namespace ShapeFind
{
    class ShapeFindTaskResult
    {
        public uint ShapeCount { get; set; }
        public TimeSpan Runtime { get; set; }

        public ShapeFindTaskResult(uint shapeCount, TimeSpan runtime)
        {
            ShapeCount = shapeCount;
            Runtime = runtime;
        }
    }
}
