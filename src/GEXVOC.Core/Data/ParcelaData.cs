using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ParcelaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Parcela">Parcela a insertar.</param>
        public static void Insertar(Parcela Parcela)
        {
            BDController.BDOperaciones.Parcelas.InsertOnSubmit(Parcela);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Parcela">Parcela a actualizar.</param>
        public static void Actualizar(Parcela Parcela)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Parcela">Parcela a eliminar.</param>
        public static void Eliminar(Parcela Parcela)
        {
            Parcela ObjBorrar = GetParcelaOP(Parcela.Id);
            BDController.BDOperaciones.Parcelas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Parcela GetParcelaOP(int id)
        {
            Parcela rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Parcelas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Parcela a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Parcela GetParcela(int id)
        {
            Parcela Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Parcelas.Single(E => E.Id == id);
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
        /// Obtiene los/las Parcela que coinciden con los criterios de búsqueda.
        /// </summary>
        ///    /// <summary>
        /// Obtiene los/las Parcela que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Parcela> GetParcelas(int? id, int? idTitular, string nombre, string poligono, decimal? extension)
        {
            List<Parcela> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Parcela> Consulta = BD.Parcelas;
                if (id != null)
                    Consulta = Consulta.Where(E => E.Id == id);
                if (idTitular != null)
                    Consulta = Consulta.Where(E => E.IdTitular == idTitular);
                if (nombre != string.Empty)
                    Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));
                if (poligono != string.Empty)
                    Consulta = Consulta.Where(E => E.Poligono.Contains(poligono));
                if (extension != null)
                    Consulta = Consulta.Where(E => E.Extension == extension);


                Consulta = Consulta.OrderBy(E => E.Nombre);//Ordenacion Inicial
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