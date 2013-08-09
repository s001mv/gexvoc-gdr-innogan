using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class MorfologiaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Morfologia">Morfologia a insertar.</param>
        public static void Insertar(Morfologia Morfologia)
        {
            BDController.BDOperaciones.Morfologias.InsertOnSubmit(Morfologia);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Morfologia">Morfologia a actualizar.</param>
        public static void Actualizar(Morfologia Morfologia)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Morfologia">Morfologia a eliminar.</param>
        public static void Eliminar(Morfologia Morfologia)
        {
            Morfologia ObjBorrar = GetMorfologiaOP(Morfologia.Id);
            BDController.BDOperaciones.Morfologias.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Morfologia GetMorfologiaOP(int id)
        {
            return BDController.BDOperaciones.Morfologias.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una Morfologia a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Morfologia GetMorfologia(int id)
        {
            Morfologia Obj = null;
            using (GEXVOCDataContext BD = BDController.NuevoContexto)
            {
                Obj = BD.Morfologias.Single(E => E.Id == id);
            }
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las Morfologia que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Morfologia> GetMorfologias(int? id,int? idAnimal)
        {
            List<Morfologia> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            //using (GEXVOCDataContext BD = BDController.NuevoContexto)
            //{
                IQueryable<Morfologia> Consulta = BD.Morfologias;

                if (id != null)
                    Consulta = Consulta.Where(E => E.Id==id);
                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);


                Consulta = Consulta.OrderBy(E => E.Id);//Ordenacion Inicial

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)

                lista = Consulta.ToList();
          //  }
            return lista;
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}