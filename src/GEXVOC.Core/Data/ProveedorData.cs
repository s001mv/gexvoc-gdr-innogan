using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ProveedorData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Proveedor">Proveedor a insertar.</param>
        public static void Insertar(Proveedor Proveedor)
        {
            BDController.BDOperaciones.Proveedores.InsertOnSubmit(Proveedor);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Proveedor">Proveedor a actualizar.</param>
        public static void Actualizar(Proveedor Proveedor)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Proveedor">Proveedor a eliminar.</param>
        public static void Eliminar(Proveedor Proveedor)
        {
            Proveedor ObjBorrar = GetProveedorOP(Proveedor.Id);
            BDController.BDOperaciones.Proveedores.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Proveedor GetProveedorOP(int id)
        {
            Proveedor rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Proveedores.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Proveedor a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Proveedor GetProveedor(int id)
        {
            Proveedor Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Proveedores.Single(E => E.Id == id);
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
        /// Obtiene los/las Proveedor que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Proveedor> GetProveedores(string nombre,string direccion, string cp, string dni, string telefono, DateTime? fechaAlta, DateTime? fechaBaja)
        {
            List<Proveedor> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Proveedor> Consulta = BD.Proveedores;

                if (nombre != string.Empty)
                    Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));
                if (direccion != string.Empty)
                    Consulta = Consulta.Where(E => E.Direccion.Contains(direccion));
                if (cp != string.Empty)
                    Consulta = Consulta.Where(E => E.CP.Contains(cp));
                if (dni != string.Empty)
                    Consulta = Consulta.Where(E => E.DNI.Contains(dni));
                if (telefono != string.Empty)
                    Consulta = Consulta.Where(E => E.Telefono.Contains(telefono));
                if (fechaAlta != null)
                    Consulta = Consulta.Where(E => E.FechaAlta == fechaAlta);
                if (fechaBaja != null)
                    Consulta = Consulta.Where(E => E.FechaBaja == fechaBaja);



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