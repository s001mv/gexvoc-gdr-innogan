using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEXVOC.Core.Logic
{
    public class MovimientoDefinicion
    {
        //### Declaración de variables que serán utilizadas para llamar a los procesos de Creación de Movimientos
        public string Identificacion { get; set; }//Será el identificador de la clase en cuestión (si es múltiple se separa por un '-')
        public DateTime? FechaEfecto { get; set; }//=null
        public DateTime? FechaEfectoAnterior { get; set; }//=null
        public TiposMovimientos Tipo { get; set; }// = TiposMovimientos.NO_DEFINIDO;//Será la descripción que se establezca en el campo 'Movimiento.Origen'
        public int IdProducto { get; set; }//=0
        public int IdProductoAnterior { get; set; }//=0
        public int? IdMacho { get; set; }//=null
        public int? IdMachoAnterior { get; set; }//=null
        public decimal Cantidad { get; set; }//=0
        public decimal CantidadAnterior { get; set; }//=0
        public decimal? Precio { get; set; }//=null
        public decimal? PrecioAnterior { get; set; }//=null

        public TipoOperacion Operacion { get; set; }

        public MovimientoDefinicion()
        {
            Tipo = TiposMovimientos.NO_DEFINIDO;
            Operacion = TipoOperacion.NoDefinida;
        }

      

    }
}
