using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class RecetaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Receta">Receta a insertar.</param>
        public static void Insertar(Receta Receta)
        {
            BDController.BDOperaciones.Receta.InsertOnSubmit(Receta);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Receta">Receta a actualizar.</param>
        public static void Actualizar(Receta Receta)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Receta">Receta a eliminar.</param>
        public static void Eliminar(Receta Receta)
        {
            Receta ObjBorrar = GetRecetaOP(Receta.Id);
            BDController.BDOperaciones.Receta.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Receta GetRecetaOP(int id)
        {
            Receta rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Receta.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Receta a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Receta GetReceta(int id)
        {
            Receta Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Receta.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            {  }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las Receta que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Receta> GetRecetas(int? idTratamiento, int? idMedicamento,string dosis,int? duracion,decimal? importe,DateTime? fecha)
        {
            List<Receta> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Receta> Consulta = BD.Receta;

                if (idTratamiento != null)
                    Consulta = Consulta.Where(E => E.IdTratamiento==idTratamiento);
                if (idMedicamento != null)
                    Consulta = Consulta.Where(E => E.IdMedicamento == idMedicamento);
                if (dosis != string.Empty)
                    Consulta = Consulta.Where(E => E.Dosis.Contains(dosis));
                if (duracion != null)
                    Consulta = Consulta.Where(E => E.Duracion == duracion);
                if (importe != null)
                    Consulta = Consulta.Where(E => E.Importe == importe);
                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);


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


        /// <summary>
        /// Nos indica si un producto ha sido utilizado en Recetas alguna vez o no.
        /// Lo podemos utilizar para saber si un determinado producto tiene alguna fila en Recetas por ejemplo para los borrados del producto.
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns></returns>
        public static bool ProductoExistenteEnRecetas(int idProducto)
        {
            bool rtno = false;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                rtno = !(BD.Receta.Where(E => E.IdMedicamento == idProducto).Count() == 0);
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return rtno;

        }

        #endregion

    }
}