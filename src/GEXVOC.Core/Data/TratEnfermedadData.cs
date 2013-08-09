using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TratEnfermedadData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TratEnfermedad">TratEnfermedad a insertar.</param>
        public static void Insertar(TratEnfermedad TratEnfermedad)
        {
            BDController.BDOperaciones.TratsEnfermedades.InsertOnSubmit(TratEnfermedad);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TratEnfermedad">TratEnfermedad a actualizar.</param>
        public static void Actualizar(TratEnfermedad TratEnfermedad)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TratEnfermedad">TratEnfermedad a eliminar.</param>
        public static void Eliminar(TratEnfermedad TratEnfermedad)
        {
            TratEnfermedad ObjBorrar = GetTratEnfermedadOP(TratEnfermedad.Id);
            BDController.BDOperaciones.TratsEnfermedades.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TratEnfermedad GetTratEnfermedadOP(int id)
        {
            TratEnfermedad rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TratsEnfermedades.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TratEnfermedad a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TratEnfermedad GetTratEnfermedad(int id)
        {
            TratEnfermedad Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TratsEnfermedades.Single(E => E.Id == id);
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
        /// Obtiene los/las TratEnfermedad que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TratEnfermedad> GetTratEnfermedades(int? idAnimal,int? idDiagnostico, string detalle, int? duracion, decimal? supresionLeche, decimal? supresionCarne, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual, int? idVeterinario)
        {
            List<TratEnfermedad> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TratEnfermedad> Consulta = BD.TratsEnfermedades;


                Consulta = Consulta.Where(E => E.DiagAnimal.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.DiagAnimal.IdAnimal == idAnimal);
                if (idDiagnostico != null)
                    Consulta = Consulta.Where(E => E.IdDiagnostico == idDiagnostico);  
                if (!string.IsNullOrEmpty(detalle))
                    Consulta = Consulta.Where(E => E.Detalle.Contains(detalle));
                if (duracion != null)
                    Consulta = Consulta.Where(E => E.Duracion == duracion);
                if (supresionLeche != null)
                    Consulta = Consulta.Where(E => E.SupresionLeche == supresionLeche);
                if (supresionCarne != null)
                    Consulta = Consulta.Where(E => E.SupresionCarne == supresionCarne);
                if (fechaMayorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaMayorIgual);
                if (fechaMenorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);
                if (idVeterinario != null)
                    Consulta = Consulta.Where(E => E.IdVeterinario==idVeterinario);
              
                
                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial
                Funciones.DescubrirPropiedades(Consulta);//Ejecuta las propiedades del objeto que empiezan por Desc 
                //Funciones.DescubrirPropiedades(Consulta, "IdAnimal");
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
      

        public static List<TratEnfermedad> TratamientosConSupresion(DateTime fecha) 
        {
         

                
            List<TratEnfermedad> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
            

                IQueryable<TratEnfermedad> Consulta = BD.TratsEnfermedades;
                Consulta = Consulta.Where(E => E.DiagAnimal.Animal.IdExplotacion == Configuracion.Explotacion.Id);
                Consulta = Consulta.Where(E => E.SupresionCarne.HasValue |  E.SupresionLeche.HasValue );
                Consulta = Consulta.Where(E => E.Fecha.AddDays(Convert.ToInt32(E.SupresionCarne.HasValue?E.SupresionCarne.Value:0))>=fecha & E.Fecha<=fecha |
                                               E.Fecha.AddDays(Convert.ToInt32(E.SupresionLeche.HasValue?E.SupresionLeche.Value:0)) >= fecha & E.Fecha <= fecha);
                
                Consulta = Consulta.OrderBy(E => E.Fecha);
                Funciones.DescubrirPropiedades(Consulta);//Ejecuta las propiedades del objeto que empiezan por Desc 
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
        //public static List<TratEnfermedad> TratamientosConSupresionLeche(DateTime fecha)
        //{

        //    List<TratEnfermedad> lista = null;
        //    GEXVOCDataContext BD = BDController.NuevoContexto;
        //    try
        //    {
        //        IQueryable<TratEnfermedad> Consulta = BD.TratsEnfermedades;
        //        Consulta = Consulta.Where(E => E.DiagAnimal.Animal.IdExplotacion == Configuracion.Explotacion.Id);
        //        Consulta = Consulta.Where(E => E.SupresionLeche.HasValue);
        //        Consulta = Consulta.Where(E => E.Fecha.AddDays(Convert.ToInt32(E.SupresionLeche.Value)) >= fecha & E.Fecha <= fecha);

        //    }
        //    catch (Exception)
        //    { throw; }
        //    finally
        //    {
        //        if (!BDController.TransaccionActiva)
        //            BD.Dispose();
        //    }
        //    return lista;



        //}
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.
        
        #endregion

    }
}