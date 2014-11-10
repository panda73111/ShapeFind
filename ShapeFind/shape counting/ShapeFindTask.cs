using System;
using System.Threading.Tasks;

namespace ShapeFind
{
    abstract class ShapeFindTask : Task<ShapeFindTaskResult>
    {
        protected ShapeFindTask(Func<object, ShapeFindTaskResult> function, object state)
            : base(function, state)
        {
        }
    }
}
