using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Mappers
{
    public interface IVmMapper<TIn,TOut>
    {
        TOut Map(TIn entity);
    }
}
