using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class MovimientoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Movimiento">Movimiento a insertar.</param>
        public static void Insertar(Movimiento Movimiento)
        {
            BDController.BDOperaciones.Movimiento.InsertOnSubmit(Movimiento);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Movimiento">Movimiento a actualizar.</param>
        public static void Actualizar(Movimiento Movimiento)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Movimiento">Movimiento a eliminar.</param>
        public static void Eliminar(Movimiento Movimiento)
        {
            Movimiento ObjBorrar = GetMovimientoOP(Movimiento.Id);
            BDController.BDOperaciones.Movimiento.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Movimiento GetMovimientoOP(int id)
        {
            Movimiento rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Movimiento.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Movimiento a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Movimiento GetMovimiento(int id)
        {
            Movimiento Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Movimiento.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las Movimiento que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Movimiento> GetMovimiento(int? idExplotacion,int? idProducto,int? idMacho,string origen,string identificacion,
            DateTime? fecha,decimal? cantidad,decimal? precio)
        {
            List<Movimiento> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Movimiento> Consulta = BD.Movimiento;

                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion==idExplotacion);
                else
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
                if (idProducto != null)
                    Consulta = Consulta.Where(E => E.IdProducto == idProducto);
                if (idMacho != null)
                    Consulta = Consulta.Where(E => E.IdMacho == idMacho);
                if (!string.IsNullOrEmpty(origen))
                    Consulta = Consulta.Where(E => E.Origen == origen);
                if (!string.IsNullOrEmpty(identificacion))
                    Consulta = Consulta.Where(E => E.Identificacion == identificacion);
                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);
                if (cantidad != null)
                    Consulta = Consulta.Where(E => E.Cantidad == cantidad);
                if (precio != null)
                    Consulta = Consulta.Where(E => E.Precio == precio);


                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial
                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)
                lista = Consulta.ToList();//Convierte la consulta en una lista
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return lista;
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}