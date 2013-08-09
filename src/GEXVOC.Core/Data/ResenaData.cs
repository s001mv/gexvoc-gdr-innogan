using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ResenaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Resena">Resena a insertar.</param>
        public static void Insertar(Resena Resena)
        {
            BDController.BDOperaciones.Resenas.InsertOnSubmit(Resena);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Resena">Resena a actualizar.</param>
        public static void Actualizar(Resena Resena)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Resena">Resena a eliminar.</param>
        public static void Eliminar(Resena Resena)
        {
            Resena ObjBorrar = GetResenaOP(Resena.Id);
            BDController.BDOperaciones.Resenas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Resena GetResenaOP(int id)
        {
            Resena rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Resenas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Resena a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Resena GetResena(int id)
        {
            Resena Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Resenas.Single(E => E.Id == id);
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
        /// Obtiene los/las Resena que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Resena> GetResenas(int? idAnimal, int? idVeterinario,string lugar,DateTime?fecha)
        {
            List<Resena> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Resena> Consulta = BD.Resenas;
                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal==idAnimal);
                if (idVeterinario != null)
                    Consulta = Consulta.Where(E => E.IdVeterinario == idVeterinario);
                if (lugar != string.Empty)
                    Consulta = Consulta.Where(E => E.Lugar.Contains(lugar));
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


        #endregion

    }
}
