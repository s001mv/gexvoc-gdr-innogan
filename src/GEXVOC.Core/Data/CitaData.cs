using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class CitaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Cita">Cita a insertar.</param>
        public static void Insertar(Cita Cita)
        {
            BDController.BDOperaciones.Citas.InsertOnSubmit(Cita);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Cita">Cita a actualizar.</param>
        public static void Actualizar(Cita Cita)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Cita">Cita a eliminar.</param>
        public static void Eliminar(Cita Cita)
        {
            Cita ObjBorrar = GetCitaOP(Cita.Id);
            BDController.BDOperaciones.Citas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Cita GetCitaOP(int id)
        {
            Cita rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Citas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Cita a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Cita GetCita(int id)
        {
            Cita Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Citas.Single(E => E.Id == id);
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
        /// Obtiene los/las Cita que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Cita> GetCitas(int? idExplotacion,int? idContacto, DateTime? fechaMayorIgual,DateTime? fechaMenorIgual,string lugar, string tema)
        {
            List<Cita> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Cita> Consulta = BD.Citas;

                if (idExplotacion!=null)
                    Consulta = Consulta.Where(E => E.IdExplotacion==idExplotacion);
                else
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
                if (idContacto != null)
                    Consulta = Consulta.Where(E => E.IdContacto == idContacto);
                if (fechaMayorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha>=fechaMayorIgual );
                if (fechaMenorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);
                if (lugar != string.Empty)
                    Consulta = Consulta.Where(E => E.Lugar.Contains(lugar));
                if (tema != string.Empty)
                    Consulta = Consulta.Where(E => E.Tema.Contains(tema));


                Consulta = Consulta.OrderBy(E => E.Fecha);//Ordenacion Inicial
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
