using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEXVOC.Core.Logic
{
    /// <summary>
    /// Asegura las características del control de stock en una clase.
    /// </summary>
    interface IControlStock
    {      
        /// <summary>
        /// Convierto la clase actual a partir de sus valores actuales en clases del tipo 'MovimientoDefinicion'
        /// susceptibles de crear stock.
        /// Esta conversión se lleva a cabo en Movimiento.GenerarMovimiento(TipoOperacion operacion,object clase) 
        /// que es llamada cada vez que se confirma una operación en clase que implementa la interface IControlStock.
        /// Nota: NO se debe llamar esplicitamente a este método.
        /// </summary>
        /// <param name="operacion"></param>
        /// <returns></returns>
        List<MovimientoDefinicion> ToMovimiento(TipoOperacion operacion);

    }
}
