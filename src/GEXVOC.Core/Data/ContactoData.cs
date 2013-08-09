using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ContactoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Contacto">Contacto a insertar.</param>
        public static void Insertar(Contacto Contacto)
        {
            BDController.BDOperaciones.Contactos.InsertOnSubmit(Contacto);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Contacto">Contacto a actualizar.</param>
        public static void Actualizar(Contacto Contacto)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Contacto">Contacto a eliminar.</param>
        public static void Eliminar(Contacto Contacto)
        {
            Contacto ObjBorrar = GetContactoOP(Contacto.Id);
            BDController.BDOperaciones.Contactos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Contacto GetContactoOP(int id)
        {
            Contacto rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Contactos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Contacto a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Contacto GetContacto(int id)
        {
            Contacto Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Contactos.Single(E => E.Id == id);
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
        /// Obtiene los/las Contacto que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Contacto> GetContactos(int? idExplotacion, int? idTipo ,string nombre, string direccion, string telefono,string movil, string email)
        {
            List<Contacto> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Contacto> Consulta = BD.Contactos;

                if (idExplotacion!=null)
                    Consulta = Consulta.Where(E => E.IdExplotacion==idExplotacion);
                else
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
                if (nombre != string.Empty)
                    Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));
                if (direccion != string.Empty)
                    Consulta = Consulta.Where(E => E.Direccion.Contains(direccion));
                if (telefono != string.Empty)
                    Consulta = Consulta.Where(E => E.Telefono.Contains(telefono));
                if (movil != string.Empty)
                    Consulta = Consulta.Where(E => E.Movil.Contains(movil));
                if (email != string.Empty)
                    Consulta = Consulta.Where(E => E.Email.Contains(email));


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

        /// <summary>
        /// Obtiene los/las Contacto que coinciden con los criterios de búsqueda.
        /// </summary>
        public static Dictionary<string,Contacto> GetContactosAutomaticos()
        {
            Dictionary<string,Contacto> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Contacto> Consulta = BD.Contactos;
                Consulta = Consulta.Where(E => E.IdExplotacion ==Configuracion.Explotacion.Id);
                Consulta = Consulta.Where(E => E.Automatico!=null);



                Consulta = Consulta.OrderBy(E => E.Nombre);//Ordenacion Inicial
                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)
                lista = Consulta.ToDictionary(E=>E.Automatico);//Convierte la consulta en una lista


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