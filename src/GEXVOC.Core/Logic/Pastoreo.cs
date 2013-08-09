using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;
using System.Reflection;

namespace GEXVOC.Core.Logic
{
    public partial class Pastoreo : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            PastoreoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {                      
            PastoreoData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            PastoreoData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Pastoreo();
                    break;
                case TipoContexto.Modificacion:
                    rtno = PastoreoData.GetPastoreoOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Pastoreo a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Pastoreo con el id especificado.</returns>
        public static Pastoreo Buscar(int id)
        {
            return PastoreoData.GetPastoreo(id);
        }

        /// <summary>
        /// Obtiene los/las Pastoreo que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idParcela">idParcela.</param>  
        /// <param name="idLote">idLoteAnimales.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>       
        public static List<Pastoreo> Buscar(int? idParcela, int? idLote, DateTime? fechaInicio, DateTime? fechaFin)
        {
            return PastoreoData.GetPastoreos(idParcela,idLote,fechaInicio,fechaFin);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Pastoreo
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Pastoreo> Buscar()
        {
            return PastoreoData.GetPastoreos(null,null,null,null);
        }

        /// <summary>
        /// Obtiene los/las Pastoreo que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idParcela">idParcela.</param>  
        /// <param name="idLote">idLoteAnimales.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>       
        public static List<Pastoreo> BuscarXIntervalo(int? idParcela, int? idLote, DateTime? fechaInicio, DateTime? fechaFin)
        {
            return PastoreoData.GetPastoreosXIntervalo(idParcela, idLote, fechaInicio, fechaFin);
        }

        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID
        /// <summary>
        /// Nos da el nombre de la parcela asociada al pastoreo.
        /// </summary>
        public string DescParcela
        {
            get 
            {
                string rtno=string.Empty;
                if(this!=null && this.Parcela!=null)
                rtno=this.Parcela.Nombre;
                return rtno;
            }           
        }
        /// <summary>
        /// Nos da la descripción del Lote de animales.
        /// </summary>
        public string DescLote
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.LoteAnimal != null)
                    rtno = this.LoteAnimal.Descripcion;
                return rtno;
            }
        
        
        }
        
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        partial void OnFechaFinChanged()
        {

            if (FechaFin != null)
            {
                if (FechaInicio > FechaFin)
                    throw new LogicException("La fecha fin debe ser mayor o igual a la fecha inicio");
                
            }
          
           
        }
        partial void OnFechaInicioChanged()
        {
            if (FechaFin != null)
                if (FechaInicio > FechaFin)
                    throw new LogicException("La fecha inicio debe ser anterior o igual a la fecha fin");            

            if (Configuracion.Explotacion!=null)
            {
                if (Configuracion.Explotacion.FechaAlta>this.FechaInicio)
                    throw new LogicException("La fecha inicio debe ser mayor o igual a la fecha de alta de la explotación activa, que se corresponde con: " + Configuracion.Explotacion.FechaAlta.ToShortDateString());            
                
            }

            //throw new NotImplementedException();
        }

        partial void OnTotalChanged()
        {
            if (FechaFin==null && !(Total??false))            
                throw new LogicException("Ha indicado que la cantidad se refiere a una cantidad diaria, en este caso la fecha fin es obligatoria\n" + 
                    "Otra posibilidad es indicar que la cantidad se refiere al total de kg de alimento, de esta manera no será necesario especificar fecha fin.");
            
        }

        #endregion


    }
}
