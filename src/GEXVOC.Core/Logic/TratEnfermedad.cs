using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TratEnfermedad : IClaseBase
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
            TratEnfermedadData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            TratEnfermedadData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            TratEnfermedadData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;          
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new TratEnfermedad();
                    break;
                case TipoContexto.Modificacion:
                    rtno = TratEnfermedadData.GetTratEnfermedadOP(this.Id);
                    break;
            }
            return rtno;


        }


        /// <summary>
        /// Obtiene un/una TratEnfermedad a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TratEnfermedad con el id especificado.</returns>
        public static TratEnfermedad Buscar(int id)
        {
            return TratEnfermedadData.GetTratEnfermedad(id);
        }
       
        /// <summary>
        /// Obtiene los/las TratEnfermedad que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TratEnfermedad> Buscar(int?idAnimal,int? idDiagnostico,  string detalle,  int? duracion, decimal? supresionLeche, decimal? supresionCarne, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual, int? idveterinario)
        {
            return TratEnfermedadData.GetTratEnfermedades(idAnimal,idDiagnostico,detalle,duracion,supresionLeche,supresionCarne,fechaMayorIgual,fechaMenorIgual,idveterinario);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TratEnfermedad
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TratEnfermedad> Buscar()
        {
            return TratEnfermedadData.GetTratEnfermedades(null,null,string.Empty,null,null,null,null,null,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

        public string DescAnimal
        {
            get
            {
                
                string rtno = string.Empty;
                if (this != null && this.DiagAnimal.Animal != null)
                    rtno = this.DiagAnimal.Animal.Nombre;
                return rtno;
            }
        }

        public int? DescIdAnimal
        {
            get
            {
                int? rtno = null;
                if (this != null && this.DiagAnimal != null && this.DiagAnimal.Animal != null)
                    rtno = this.DiagAnimal.IdAnimal;
                return rtno;
            }
        }
        public int? DescIdEnfermedad
        {
            get
            {
                int? rtno = null;
                if (this != null && this.DiagAnimal != null)
                    rtno = this.DiagAnimal.IdEnfermedad;
                return rtno;
            }
        }
        public string DescEnfermedad
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.DiagAnimal != null && this.DiagAnimal.Enfermedad!=null)
                    rtno = this.DiagAnimal.Enfermedad.Descripcion;
                return rtno;
            }
        
        }
        public int? IdNaturaleza
        {
            get
            {
                int? rtno = null;
                Naturaleza naturalezaGasto = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.DIAGNOSTICO_ENFERMEDAD_ANIMAL);
                if (naturalezaGasto != null)
                    rtno = naturalezaGasto.Id;
                return rtno;
            }
        
        }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Personal al que pertenece el elemento
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
        ///// Propiedad que devuelve la fecha hasta la cual el tratamiento tiene supresion de leche (por tanto el animal)
        ///// </summary>
        public DateTime? DescFSupresionLeche
        {
            get
            {
                DateTime? rtno = null;
                if (this.Fecha != null && this.SupresionLeche != null && this.SupresionLeche.Value>0)
                    rtno = this.Fecha.AddDays((double)SupresionLeche).Date;

                return rtno;
            }
        }
        ///// <summary>
        ///// Propiedad que devuelve la fecha hasta la cual el tratamiento tiene supresion de Carne (por tanto el animal)
        ///// </summary>
        public DateTime? DescFSupresionCarne
        {
            get
            {
                DateTime? rtno = null;
                if (this.Fecha != null && this.SupresionCarne != null && this.SupresionCarne.Value>0)
                    rtno = this.Fecha.AddDays((double)SupresionCarne).Date;

                return rtno;
            }
        }


        public string Descripcion         
        {
            get
            {
                string rtno = string.Empty;
                
                if (this != null)
                    rtno = this.Fecha.ToShortDateString();

                return rtno;
            }
        
        }
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.
        /// <summary>
        /// Devuelve los gastos de un determinado animal.
        /// </summary>
        public List<Gasto> lstGastos
        {
            get { return Logic.Gasto.Buscar(null, null, null, this.Id, null, null, null, null, null, null, string.Empty, null, null, null,null,null); }
        }

        public List<Receta> lstRecetas
        {
            get { return Logic.Receta.Buscar(this.Id, null, string.Empty, null,null,null); }
        }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion == TipoOperacion.Borrado)
            {
                List<Receta> lsrecetas = lstRecetas;
                if (lsrecetas!=null && lsrecetas.Count>0)                
                    throw new LogicException("No es posible eliminar el tratamiento: "+ Descripcion + " porque tiene recetas asociadas.");

                List<Gasto> lstgasto= lstGastos;
                if (lstgasto != null && lstgasto.Count > 0)
                    throw new LogicException("No es posible eliminar el tratamiento: " + Descripcion + "  porque tiene gastos asociados.");

            }


        }

        partial void OnDetalleChanged()
        {
            
            //throw new NotImplementedException();
        }

        partial void OnDuracionChanged()
        {
            List<Receta> lstrecetas = lstRecetas;
            if (lstrecetas!=null && lstrecetas.Count>0 )
            {
                foreach (Receta item in lstrecetas)                
                    if (this.Duracion<item.Duracion)                  
                        throw new LogicException("En un tratamiento no es posible especificar una duración inferior a cualquiera de las duraciones de sus recetas.");                       
            }
        }

        #endregion


    }
}