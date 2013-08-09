using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TitularData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Titular">Titular a insertar.</param>
        public static void Insertar(Titular Titular)
        {
            BDController.BDOperaciones.Titulares.InsertOnSubmit(Titular);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Titular">Titular a actualizar.</param>
        public static void Actualizar(Titular Titular)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Titular">Titular a eliminar.</param>
        public static void Eliminar(Titular Titular)
        {
            Titular ObjBorrar = GetTitularOP(Titular.Id);
            BDController.BDOperaciones.Titulares.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Titular GetTitularOP(int id)
        {
            Titular rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Titulares.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Titular a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Titular GetTitular(int id)
        {
            Titular Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Titulares.Single(E => E.Id == id);
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
        /// Devuelve todos los titulares que coincidan con el criterio especificado, los parametros pueden contener o no valores
        /// </summary>
        /// <param name="nombre">Nombre del Titular</param>
        /// <param name="apellidos">Apellidos del Titular</param>
        /// <param name="direccion">Dirección del Titular</param>
        /// <param name="CP">Código Postal del Titular</param>
        /// <param name="DNI">DNI del Titular</param>
        /// <param name="telefono">Teléfono del Titular</param>
        /// <param name="fechaNacimiento">Fecha de Nacimiento del Titular</param>
        /// <param name="numeroCuenta">Número de Cuenta del Titular</param>
        /// <param name="fechaAlta">Fecha de Alta del Titular</param>
        /// <param name="fechaBaja">Fecha de Baja del Titular</param>
        /// <returns></returns>
        public static List<Titular> GetTitulares(string nombre, string apellidos, string direccion, string CP, string DNI, string telefono, DateTime? fechaNacimiento, DateTime? fechaAlta, DateTime? fechaBaja)
        {
            List<Titular> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Titular> Consulta = BD.Titulares;

                if (nombre != String.Empty)
                    Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));
                if (apellidos != String.Empty)
                    Consulta = Consulta.Where(E => E.Apellidos.Contains(apellidos));
                if (direccion != String.Empty)
                    Consulta = Consulta.Where(E => E.Direccion.Contains(direccion));
                if (CP != String.Empty)
                    Consulta = Consulta.Where(E => E.CP.Contains(CP));
                if (DNI != String.Empty)
                    Consulta = Consulta.Where(E => E.DNI.Contains(DNI));
                if (telefono != String.Empty)
                    Consulta = Consulta.Where(E => E.Telefono.Contains(telefono));
                if (fechaNacimiento != null)
                    Consulta = Consulta.Where(E => E.FechaNacimiento == fechaNacimiento);
                if (fechaAlta != null)
                    Consulta = Consulta.Where(E => E.FechaAlta == fechaAlta);
                if (fechaBaja != null)
                    Consulta = Consulta.Where(E => E.FechaBaja == fechaBaja);

                Consulta = Consulta.OrderBy(E => E.Nombre);//Ordenacion Inicial
                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                                                          //(estas propiedades se utilizan habitualmente en los grids)
                lista = Consulta.ToList();

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

        public static List<Explotacion> GetExplotaciones(int idTitular)
        {

            List<Explotacion> rtno = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                var Consulta = from p in BD.Explotaciones
                               from o in p.ExpTit
                               where (o.IdTitular == idTitular)
                               orderby (p.CEA)
                               select (p);


                Funciones.DescubrirPropiedades(Consulta, "IdProvincia");
                rtno = Consulta.ToList();
            }
            catch (Exception)
            { }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return rtno;
        }

        #endregion

    }
}