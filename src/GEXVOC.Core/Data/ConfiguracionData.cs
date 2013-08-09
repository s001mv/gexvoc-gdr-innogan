using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;
using System.Collections;

namespace GEXVOC.Core.Data
{
    public class ConfiguracionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Configuracion">Configuracion a insertar.</param>
        public static void Insertar(Configuracion Configuracion)
        {
            BDController.BDOperaciones.Configuraciones.InsertOnSubmit(Configuracion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Configuracion">Configuracion a actualizar.</param>
        public static void Actualizar(Configuracion Configuracion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Configuracion">Configuracion a eliminar.</param>
        public static void Eliminar(Configuracion Configuracion)
        {
            Configuracion ObjBorrar = GetConfiguracionOP(Configuracion.Clave);
            BDController.BDOperaciones.Configuraciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Configuracion GetConfiguracionOP(string clave)
        {
            Configuracion rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Configuraciones.Single(E => E.Clave == clave);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Configuracion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Configuracion GetConfiguracion(string clave)
        {
            Configuracion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Configuraciones.Single(E => E.Clave == clave);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            { }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }
        //public static IEnumerable GetConfiguracion()
        //{
        //    GEXVOCDataContext BD = BDController.NuevoContexto;
        //    IEnumerable Obj = null;
        //    try
        //    {
        //        Obj = BD.Configuraciones;

        //    }
        //    catch (Exception)
        //    { }
        //    finally
        //    {
        //        if (!BDController.TransaccionActiva)
        //            BD.Dispose();
        //    }
        //    return Obj;

        //    //return from C in BDController.BD.Configuraciones
        //    //       select C;
        //}

        /// <summary>
        /// Obtiene los/las Configuracion que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Configuracion> GetConfiguraciones(string clave,string valor)
        {
            List<Configuracion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Configuracion> Consulta = BD.Configuraciones;

                if (clave != string.Empty)
                    Consulta = Consulta.Where(E => E.Clave.Contains(clave));
                if (valor != string.Empty)
                    Consulta = Consulta.Where(E => E.Valor.Contains(valor));


                Consulta = Consulta.OrderBy(E => E.Clave);//Ordenacion Inicial
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