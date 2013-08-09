using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEXVOC.Core.Logic
{
    public class GastoDefinicion
    {
        public int IdNaturaleza = 0;
        public int? IdAnimal = null;

        public int? IdTratamiento = null;
        public int? IdReceta = null;
        public int? IdParcela = null;
        public int? IdAsignacion = null;
        public int? IdSiembra = null;
        public int? IdAbonado = null;
        public int? IdTratParcela = null;
        public int? IdInseminacion = null;
        public int? IdTratProfilaxis = null;
        public int? IdProductoTratamientos = null;
        public int? IdTratHigiene = null;        
        public string Detalle = string.Empty;
        public DateTime Fecha = DateTime.Today;
        public decimal Importe = decimal.Zero;
        public decimal Total = decimal.Zero;
        
        public List<Gasto> lstGastos = null;
        public Gasto GastoActual = null;

        //Variables para el calculo del importe y total (GENERAL)
        public decimal Extension = 1;//Si no ha sido valorada vale 1 para que al multiplicar no haga nada.
        public decimal? ExtensionAnterior = null;
        public int IdProducto = 0;
        public int? IdProductoAnterior = null;
        public decimal Cantidad = decimal.Zero;
        public decimal? CantidadAnterior = null;
        public decimal? ImporteAnterior = null;
        public int? IdMacho = null;
        public int? IdMachoAnterior = null;
        public int? IdAnimalAnterior = null;

        /// <summary>
        /// Nos indica que no hagamos el cáculo del precio en la funcio Gasto.GenerarGasto
        /// </summary>
        public bool OmitirCalculPrecio = false;

    }
}
