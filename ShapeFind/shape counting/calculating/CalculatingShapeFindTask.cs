using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShapeFind.calculating
{
    class CalculatingShapeFindTask : ShapeFindTask
    {
        public CalculatingShapeFindTask(ShapeFindParameters parameters)
            : base(FindShapes, parameters)
        {
        }

        private static ShapeFindTaskResult FindShapes(object state)
        {
            DateTime startTime = DateTime.Now;
            ShapeFindParameters parameters = (ShapeFindParameters)state;

            /* single thread:
            int total = parameters.ShapeList.Count(
                s => s.OccupiesPoint(parameters.Point));
            */

            long total = 0;
            Parallel.ForEach(parameters.ShapeList,
                () => 0, // initialize subtotal
                (s, loopState, subtotal) =>
                {
                    if (s.OccupiesPoint(parameters.Point))
                        return subtotal + 1;
                    return subtotal;
                },
                finalResult => Interlocked.Add(ref total, finalResult));

            return new ShapeFindTaskResult((uint)total, DateTime.Now - startTime);
        }
    }
}
