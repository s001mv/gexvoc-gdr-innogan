using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEXVOC.Core.Logic
{
    interface IControlGasto
    {
        GastoDefinicion ToGasto(TipoOperacion operacion);
    }
}
