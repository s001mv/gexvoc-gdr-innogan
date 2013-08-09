using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class MunicipioData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Municipio">Municipio a insertar.</param>
        public static void Insertar(Municipio Municipio)
        {
            BDController.BDOperaciones.Municipios.InsertOnSubmit(Municipio);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Municipio">Municipio a actualizar.</param>
        public static void Actualizar(Municipio Municipio)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Municipio">Municipio a eliminar.</param>
        public static void Eliminar(Municipio Municipio)
        {
            Municipio ObjBorrar = GetMunicipioOP(Municipio.Id);
            BDController.BDOperaciones.Municipios.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Municipio GetMunicipioOP(int id)
        {
            Municipio rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Municipios.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Municipio a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Municipio GetMunicipio(int id)
        {
            Municipio Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Municipios.Single(E => E.Id == id);
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
        /// Obtiene los/las Municipio que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Municipio> GetMunicipios(string codigo, string descripcion, int? idProvincia)
        {
            List<Municipio> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                 IQueryable<Municipio> Consulta = BD.Municipios;

                if (codigo != string.Empty)
                    Consulta = Consulta.Where(E => E.Codigo.Contains(codigo));
                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (idProvincia != null)
                    Consulta = Consulta.Where(E => E.IdProvincia == idProvincia);

                Consulta = Consulta.OrderBy(E => E.Descripcion);//Ordenacion Inicial

               	Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                      									  //(estas propiedades se utilizan habitualmente en los grids)
                lista = Consulta.ToList();
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