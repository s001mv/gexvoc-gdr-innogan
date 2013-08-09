﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class NaturalezaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Naturaleza">Naturaleza a insertar.</param>
        public static void Insertar(Naturaleza Naturaleza)
        {
            BDController.BDOperaciones.Naturalezas.InsertOnSubmit(Naturaleza);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Naturaleza">Naturaleza a actualizar.</param>
        public static void Actualizar(Naturaleza Naturaleza)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Naturaleza">Naturaleza a eliminar.</param>
        public static void Eliminar(Naturaleza Naturaleza)
        {
            Naturaleza ObjBorrar = GetNaturalezaOP(Naturaleza.Id);
            BDController.BDOperaciones.Naturalezas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Naturaleza GetNaturalezaOP(int id)
        {
            Naturaleza rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Naturalezas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Naturaleza a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Naturaleza GetNaturaleza(int id)
        {
            Naturaleza Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Naturalezas.Single(E => E.Id == id);
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
        /// Obtiene los/las Naturaleza que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Naturaleza> GetNaturalezas(string descripcion,bool? sistema)
        {
            List<Naturaleza> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Naturaleza> Consulta = BD.Naturalezas;

                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (sistema != null)
                    Consulta = Consulta.Where(E => E.Sistema == sistema);


                Consulta = Consulta.OrderBy(E => E.Descripcion);//Ordenacion Inicial
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