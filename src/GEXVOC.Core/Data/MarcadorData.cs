using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class MarcadorData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Marcador">Marcador a insertar.</param>
        public static void Insertar(Marcador Marcador)
        {
            BDController.BDOperaciones.Marcadores.InsertOnSubmit(Marcador);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Marcador">Marcador a actualizar.</param>
        public static void Actualizar(Marcador Marcador)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Marcador">Marcador a eliminar.</param>
        public static void Eliminar(Marcador Marcador)
        {
            Marcador ObjBorrar = GetMarcadorOP(Marcador.Id);
            BDController.BDOperaciones.Marcadores.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Marcador GetMarcadorOP(int id)
        {
            Marcador rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Marcadores.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Marcador a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Marcador GetMarcador(int id)
        {
            Marcador Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Marcadores.Single(E => E.Id == id);
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
        /// Obtiene los/las Marcador que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Marcador> GetMarcadores(int? idTipoAnalisis, int? idEspecie, string marcador)
        {
            List<Marcador> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Marcador> Consulta = BD.Marcadores;

                if (idTipoAnalisis != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipoAnalisis);
                if (idEspecie != null)
                    Consulta = Consulta.Where(E => E.IdEspecie == idEspecie);
                if (marcador != string.Empty)
                    Consulta = Consulta.Where(E => E.Marcador1.Contains(marcador));


                Consulta = Consulta.OrderBy(E => E.Marcador1);//Ordenacion Inicial
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
