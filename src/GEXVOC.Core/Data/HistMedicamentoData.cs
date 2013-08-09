using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class HistMedicamentoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="HistMedicamento">HistMedicamento a insertar.</param>
        public static void Insertar(HistMedicamento HistMedicamento)
        {
            BDController.BDOperaciones.HistMedicamentos.InsertOnSubmit(HistMedicamento);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="HistMedicamento">HistMedicamento a actualizar.</param>
        public static void Actualizar(HistMedicamento HistMedicamento)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="HistMedicamento">HistMedicamento a eliminar.</param>
        public static void Eliminar(HistMedicamento HistMedicamento)
        {
            HistMedicamento ObjBorrar = GetHistMedicamentoOP(HistMedicamento.Id);
            BDController.BDOperaciones.HistMedicamentos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static HistMedicamento GetHistMedicamentoOP(int id)
        {
            HistMedicamento rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.HistMedicamentos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una HistMedicamento a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static HistMedicamento GetHistMedicamento(int id)
        {
            HistMedicamento Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.HistMedicamentos.Single(E => E.Id == id);
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
        /// Obtiene los/las HistMedicamento que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<HistMedicamento> GetHistMedicamentos(int? idEspecie,int? idEnfermedad,int? idMedicamento)
        {
            List<HistMedicamento> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<HistMedicamento> Consulta = BD.HistMedicamentos;

                if (idEspecie != null)
                    Consulta = Consulta.Where(E => E.IdEspecie==idEspecie);
                if (idEnfermedad != null)
                    Consulta = Consulta.Where(E => E.IdEnfermedad == idEnfermedad);
                if (idMedicamento != null)
                    Consulta = Consulta.Where(E => E.IdMedicamento == idMedicamento);


                Consulta = Consulta.OrderBy(E => E.Especie.Descripcion).ThenBy(E=>E.Enfermedad.Descripcion).ThenBy(E=>E.Producto.Descripcion);//Ordenacion Inicial
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

        public static List<Producto> GetMedicamentos(int IdEnfermedad) 
        {
            List<Producto> rtno = null;
          
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                var Consulta = from p in BD.Productos
                               from o in p.Historicos
                               where (o.IdMedicamento == p.Id & o.IdEnfermedad==IdEnfermedad)
                               orderby (p.Descripcion)
                               select (p);

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

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        /// <summary>
        /// Nos indica si un producto ha sido utilizado en el Historial Medicamentos alguna vez o no.
        /// Lo podemos utilizar para saber si un determinado producto tiene alguna fila en HistMedicamentos por ejemplo para los borrados del producto.
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns></returns>
        public static bool ProductoExistenteEnHistMedicamentos(int idProducto)
        {
            bool rtno = false;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                rtno = !(BD.HistMedicamentos.Where(E => E.IdMedicamento == idProducto).Count() == 0);
            }
            catch (Exception)
            { throw; }
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