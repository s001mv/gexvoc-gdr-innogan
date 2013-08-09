using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class CuentaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Cuenta">Cuenta a insertar.</param>
        public static void Insertar(Cuenta Cuenta)
        {
            BDController.BDOperaciones.Cuentas.InsertOnSubmit(Cuenta);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Cuenta">Cuenta a actualizar.</param>
        public static void Actualizar(Cuenta Cuenta)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Cuenta">Cuenta a eliminar.</param>
        public static void Eliminar(Cuenta Cuenta)
        {
            Cuenta ObjBorrar = GetCuentaOP(Cuenta.Id);
            BDController.BDOperaciones.Cuentas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Cuenta GetCuentaOP(int id)
        {
            Cuenta rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Cuentas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Cuenta a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Cuenta GetCuenta(int id)
        {
            Cuenta Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Cuentas.Single(E => E.Id == id);
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
        /// Obtiene los/las Cuenta que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Cuenta> GetCuentas(int? idTitular,string banco,string sucursal,string numero)
        {
            List<Cuenta> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Cuenta> Consulta = BD.Cuentas;
                if (idTitular != null)
                    Consulta = Consulta.Where(E => E.IdTitular == idTitular);
                if (banco != string.Empty)
                    Consulta = Consulta.Where(E => E.Banco.Contains(banco));
                if (sucursal != string.Empty)
                    Consulta = Consulta.Where(E => E.Sucursal.Contains(sucursal));
                if (numero != string.Empty)
                    Consulta = Consulta.Where(E => E.Numero.Contains(numero));


                Consulta = Consulta.OrderBy(E => E.Numero);//Ordenacion Inicial
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