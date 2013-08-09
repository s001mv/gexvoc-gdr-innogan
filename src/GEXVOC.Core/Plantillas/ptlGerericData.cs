using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ptlGerericData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

            /// <summary>
            /// Inserta un registro.
            /// </summary>
            /// <param name="ptlGeneric">ptlGeneric a insertar.</param>
            public static void Insertar(IClaseBase ptlGeneric)
            {
                //BDController.BDOperaciones.ptlGenerics.InsertOnSubmit(ptlGeneric);
                BDController.BDOperaciones.SubmitChanges();
            }

            /// <summary>
            /// Actualiza un registro.
            /// </summary>
            /// <param name="ptlGeneric">ptlGeneric a actualizar.</param>
            public static void Actualizar(IClaseBase ptlGeneric)
            {
                BDController.BDOperaciones.SubmitChanges();
            }

            /// <summary>
            /// Elimina un registro.
            /// </summary>
            /// <param name="ptlGeneric">ptlGeneric a eliminar.</param>
            public static void Eliminar(IClaseBase ptlGeneric)
            {
                //BDController.BDOperaciones.ptlGenerics.DeleteOnSubmit(ptlGeneric);
                BDController.BDOperaciones.SubmitChanges();
            }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

            //public static IClaseBase GetptlGenericOP(int id)
            //{
            //  return BDController.BD.ptlGenerics.Single(E => E.Id == id);
            //     
            //}

            /// <summary>
            /// Obtiene un/una ptlGeneric a partir de su id.
            /// </summary>
            /// <param name="id">Identificador principal.</param>
            //  public static ptlGeneric GetptlGeneric(int id)
            //  {
            //     ptlGeneric Obj = null;
            //     using (GEXVOCDataContext BD = BDController.NuevoContexto)
            //     {
            //          Obj = BD.ptlGeneric.Single(E => E.Id == id);
            //     }
            //     return Obj;   
            //  }

            /// <summary>
            /// Obtiene los/las ptlGeneric que coinciden con los criterios de búsqueda.
            /// </summary>
            //  public static List<ptlGeneric> GetptlGenerics(string nombre,int provincia)
            //  {
            //    List<ptlGeneric> lista = null;
            //    using (GEXVOCDataContext BD = BDController.NuevoContexto)
            //    {
            //          IQueryable<ptlGeneric> Consulta = BD.ptlGenerics;
            //         
            //          if (nombre != String.Empty)
            //              Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));

            //          if (provincia != 0)
            //              Consulta = Consulta.Where(E => E.Municipio.IdProvincia == provincia);
            //
            //          Consulta = Consulta.OrderBy(E => E.CEA);//Ordenacion Inicial
            //          lista=Consulta.ToList();
            //    }
            //    return lista;
            //  }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion
        
    }
}
