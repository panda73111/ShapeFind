using System;

namespace ShapeFind.lookup
{
    class ShapeLookupGenerationResult
    {
        public ShapeLookupTable LookupTable { get; set; }
        public TimeSpan Runtime { get; set; }

        public ShapeLookupGenerationResult(ShapeLookupTable lookupTable, TimeSpan runtime)
        {
            LookupTable = lookupTable;
            Runtime = runtime;
        }
    }
}
