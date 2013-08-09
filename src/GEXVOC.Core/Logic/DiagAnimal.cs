using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;
using System.Reflection;

namespace GEXVOC.Core.Logic
{
    public partial class DiagAnimal : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ValidarLogica(TipoOperacion.Insercion);
            DiagAnimalData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            DiagAnimalData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            DiagAnimalData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
          
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new DiagAnimal();//Es una insercion
                    break;
                case TipoContexto.Modificacion:
                    rtno = DiagAnimalData.GetDiagAnimalOP(this.Id);//Es una modificacion
                    break;
                default:
                    rtno = null;
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una DiagAnimal a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>DiagAnimal con el id especificado.</returns>
        public static DiagAnimal Buscar(int id)
        {
            return DiagAnimalData.GetDiagAnimal(id);
        }

        /// <summary>
        /// Obtiene los/las DiagAnimal que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<DiagAnimal> Buscar(int? idAnimal, int? idVeterinario,DateTime? fechaMayorIgual, DateTime? fechaMenorIgual,int? idEnfermedad)
        {
            return DiagAnimalData.GetDiagAnimales(idAnimal, idVeterinario, fechaMayorIgual, fechaMenorIgual, idEnfermedad);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo DiagAnimal
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<DiagAnimal> Buscar()
        {
            return DiagAnimalData.GetDiagAnimales(null,null,null,null,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID
        /// <summary>
        /// Propiedad que devuelve el nombre del animal.
        /// </summary>
        public string DescAnimal
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Animal != null)
                    rtno = this.Animal.Nombre;
                return rtno;
            }
        }

        public int? IdTipo
        {
            get
            {
                int? rtno = null;
                if (this != null && this.Enfermedad != null && this.Enfermedad.Tipo != null)
                    rtno = this.Enfermedad.Tipo.Id;
                return rtno;
            }
        }


        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Veterinario a la que pertenece el elemento
        ///// </summary>
        public string DescPersonal
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Veterinario != null)
                    rtno = this.Veterinario.NombreCompleto;

                return rtno;
            }
        }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Diagnostico a la que pertenece el elemento
        ///// </summary>
        public string DescDiagnostico
        {
            get
            {
                string rtno = string.Empty;
                if (this != null)
                    rtno = this.Fecha.ToShortDateString() + " - " +  DescAnimal;

                return rtno;
            }
        }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Enfermedad a la que pertenece el elemento
        ///// </summary>
        public string DescEnfermedad
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Enfermedad != null)
                    rtno = this.Enfermedad.Descripcion;

                return rtno;
            }
        }
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.
        /// <summary>
        /// Devuelve los tratamientos de en un determinado diagnóstico.
        /// </summary>
        public List<TratEnfermedad> lstTratEnfermedad
        {
            get { return TratEnfermedadData.GetTratEnfermedades(null,this.Id, string.Empty, null, null, null, null,null, null); }
        }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        private void ValidarLogica(TipoOperacion operacion)
        {
            //this.buscar();
            if (operacion == TipoOperacion.Borrado)
            {
                List<TratEnfermedad> lstTratamientos = lstTratEnfermedad;
                if (lstTratamientos != null && lstTratamientos.Count > 0)
                    throw new LogicException("No es posible eliminar el Diagnóstico: " + DescDiagnostico + " porque tiene tratamientos asociados.");
                
            }        
        }

        //public string buscar() 
        //{
        //    string attrib = "hola";
        //    foreach (MemberInfo mi in Fecha.GetType().GetMembers())
        //    {
                
        //        try
        //        {
        //             attrib = ((System.Data.Linq.Mapping.ColumnAttribute)(mi.GetCustomAttributes(false)[0])).DbType;
        //             break;
        //        }
        //        catch (Exception)
        //        {
                    
        //            //throw;
        //        }
                
        //    }
        //    return attrib;
        
        //}



        #endregion


    }
}
