using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;
using System.Linq.Expressions;

namespace GEXVOC.Core.Data
{
    public class ClienteData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Cliente">Cliente a insertar.</param>
        public static void Insertar(Cliente Cliente)
        {
            BDController.BDOperaciones.Clientes.InsertOnSubmit(Cliente);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Cliente">Cliente a actualizar.</param>
        public static void Actualizar(Cliente Cliente)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Cliente">Cliente a eliminar.</param>
        public static void Eliminar(Cliente Cliente)
        {
            Cliente ObjBorrar = GetClienteOP(Cliente.Id);
            BDController.BDOperaciones.Clientes.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Cliente GetClienteOP(int id)
        {
            Cliente rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Clientes.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Cliente a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Cliente GetCliente(int id)
        {
            Cliente Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Clientes.Single(E => E.Id == id);
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
        /// Obtiene los/las Cliente que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Cliente> GetClientes(string nombre, string direccion, string cp, string dni,string telefono,DateTime? fechaAlta, DateTime? fechaBaja)
        {
            List<Cliente> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Cliente> Consulta = BD.Clientes;

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

        public static List<Expression<Func<Cliente, bool>>> lstWhere = new List<Expression<Func<Cliente, bool>>>();
        public static void   AgregarCondicion(Expression<Func<Cliente, bool>> where)
        {
            lstWhere.Add(where);    
        }
        
        public static List<Cliente> GetClientes(Expression<Func<Cliente, DateTime>> Orden)
        {
            List<Cliente> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                 IQueryable<Cliente> Consulta = BD.Clientes;
                
                //Expression<Func<Cliente, string>> que;
                //que=E=>E.Direccion;

                 foreach (Expression<Func<Cliente, bool>> item in lstWhere)                 
                     Consulta = Consulta.Where(item);
                 
               //Consulta= Consulta.Where("Nombre==\"C\"");
                 Consulta = Consulta.OrderBy(Orden);
                //lista=BD.GetTable<Cliente>().Where(query).ToList();

                //Consulta = Consulta.OrderBy(E => E.Nombre);//Ordenacion Inicial
                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                ////(estas propiedades se utilizan habitualmente en los grids)
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
        public static List<Cliente> GetWhere()
        {
            List<Cliente> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Cliente> Consulta = BD.Clientes;

                
                foreach (Expression<Func<Cliente, bool>> item in lstWhere)
                    Consulta = Consulta.Where(item);
                                
                Consulta = Consulta.OrderBy(E => E.Nombre);//Ordenacion Inicial
                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                ////(estas propiedades se utilizan habitualmente en los grids)
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
