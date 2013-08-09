using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class LibroGenealogicoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Libro">LibroGenealogico a insertar.</param>
        public static void Insertar(LibroGenealogico Libro)
        {
            BDController.BDOperaciones.LibrosGenealogicos.InsertOnSubmit(Libro);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Libro">LibroGenealogico a actualizar.</param>
        public static void Actualizar(LibroGenealogico Libro)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Libro">LibroGenealogico a eliminar.</param>
        public static void Eliminar(LibroGenealogico Libro)
        {
            LibroGenealogico ObjBorrar = GetLibroGenealogicoOP(Libro.Id);
            BDController.BDOperaciones.LibrosGenealogicos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static LibroGenealogico GetLibroGenealogicoOP(int id)
        {
            LibroGenealogico rtno = null;

            try
            {
                rtno = BDController.BDOperaciones.LibrosGenealogicos.Single(L => L.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        public static LibroGenealogico GetLibroAnimal(int idAnimal)
        {
            LibroGenealogico Obj = null;

            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.LibrosGenealogicos.Single(L => L.IdAnimal == idAnimal);
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
        
        #endregion

        #region FUNCIONALIDAD AÑADIDA

        #endregion
    }
}
