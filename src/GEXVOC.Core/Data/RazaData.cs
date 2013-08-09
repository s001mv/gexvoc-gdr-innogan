using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class RazaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Raza">Raza a insertar.</param>
        public static void Insertar(Raza Raza)
        {
            BDController.BDOperaciones.Razas.InsertOnSubmit(Raza);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Raza">Raza a actualizar.</param>
        public static void Actualizar(Raza Raza)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Raza">Raza a eliminar.</param>
        public static void Eliminar(Raza Raza)
        {
            Raza ObjBorrar = GetRazaOP(Raza.Id);
            BDController.BDOperaciones.Razas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Raza GetRazaOP(int id)
        {
            return BDController.BDOperaciones.Razas.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una Raza a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Raza GetRaza(int id)
        {
            Raza Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = Obj = BD.Razas.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception) { }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }
   

        /// <summary>
        /// Obtiene los/las Raza que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Raza> GetRazas(string descripcion, int? idEspecie)
        {
            List<Raza> lista = null;

            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Raza> Consulta = BD.Razas;

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (idEspecie != null)
                    Consulta = Consulta.Where(E => E.IdEspecie == idEspecie);

               

                Consulta = Consulta.OrderBy(E => E.Especie.Descripcion).ThenBy(E => E.Descripcion);//Ordenacion Inicial


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