using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class VeterinarioData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Veterinario">Veterinario a insertar.</param>
        public static void Insertar(Veterinario Veterinario)
        {
            BDController.BDOperaciones.Veterinarios.InsertOnSubmit(Veterinario);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Veterinario">Veterinario a actualizar.</param>
        public static void Actualizar(Veterinario Veterinario)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Veterinario">Veterinario a eliminar.</param>
        public static void Eliminar(Veterinario Veterinario)
        {
            Veterinario ObjBorrar = GetVeterinarioOP(Veterinario.Id);
            BDController.BDOperaciones.Veterinarios.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Veterinario GetVeterinarioOP(int id)
        {
            Veterinario rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Veterinarios.Single(E => E.Id == id);
            }
            catch (Exception) { }
            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Veterinario a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Veterinario GetVeterinario(int id)
        {
            Veterinario Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Veterinarios.Single(E => E.Id == id);
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
        public static Veterinario GetVeterinario(string nombreCompleto)
        {
            Veterinario Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Veterinarios.Single(E => (E.Nombre + " " +  E.Apellidos) ==nombreCompleto);
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
        /// Obtiene los/las Veterinario que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Veterinario> GetVeterinarios(int? idExplotacion,string nombre, string apellidos,string dni, string direccion, string cp, string telefono,DateTime? fechaNacimiento,int? idTipo)
        {
            List<Veterinario> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Veterinario> Consulta = BD.Veterinarios;
                if (idExplotacion.HasValue)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);
                else
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);

                if (nombre != string.Empty)
                    Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));
                if (apellidos != string.Empty)
                    Consulta = Consulta.Where(E => E.Apellidos.Contains(apellidos));
                if (dni != string.Empty)
                    Consulta = Consulta.Where(E => E.DNI.Contains(dni));
                if (direccion != string.Empty)
                    Consulta = Consulta.Where(E => E.Direccion.Contains(direccion));
                if (cp != string.Empty)
                    Consulta = Consulta.Where(E => E.CP.Contains(cp));
                if (telefono != string.Empty)
                    Consulta = Consulta.Where(E => E.Telefono.Contains(telefono));
                if (fechaNacimiento != null)
                    Consulta = Consulta.Where(E => E.FechaNacimiento == fechaNacimiento);
                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);

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


        #endregion

    }
}