using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Parcela : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ParcelaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ParcelaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ParcelaData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;    

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Parcela();//Es una insercion
                    break;
                case TipoContexto.Modificacion:
                    rtno = ParcelaData.GetParcelaOP(this.Id);//Es una modificacion
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Parcela a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Parcela con el id especificado.</returns>
        public static Parcela Buscar(int id)
        {
            return ParcelaData.GetParcela(id);
        }

        /// <summary>
        /// Obtiene los/las Parcela que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Parcela> Buscar(int? id,int? idTitular, string nombre, string poligono, decimal? extension)
        {
            return ParcelaData.GetParcelas(id,idTitular, nombre, poligono, extension);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Parcela
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Parcela> Buscar()
        {
            return ParcelaData.GetParcelas(null,null,string.Empty,string.Empty,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Titular a la que pertenece el elemento
        ///// </summary>
        public string DescTitular
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Titular != null)
                    rtno = this.Titular.Nombre + " " + this.Titular.Apellidos;

                return rtno;
            }
        }

        public string DescDNITitular
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Titular != null)
                    rtno = this.Titular.DNI;

                return rtno;
            }
        }

        double? _DescRacion = null;
        public double? DescRacion
        {
            get
            {
                double? rtno = null;
                if (!_DescRacion.HasValue)
                {
                    try
                    {
                        if (this != null && this.RacionSoportadaParcela() != null)
                            rtno = this.RacionSoportadaParcela();
                    }
                    catch (Exception) { }
                    _DescRacion = rtno;
                }
                else
                    rtno = _DescRacion;                
               
                                
                return rtno;
            }
        }


        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.
        /// <summary>
        /// Nos devuelve todos los pastoreos asociados a la parcela.
        /// </summary>
        public List<Pastoreo> lstPastoreos
        {
            get { return Logic.Pastoreo.Buscar(this.Id, null, null, null); }
        }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO


        public double? RacionSoportadaParcela()
        {
            double? racion = 0;

            int Dias = 0;
            if (this != null && this.lstPastoreos != null)

                foreach (Pastoreo pastoreo in this.lstPastoreos)

                    if (pastoreo != null && pastoreo.LoteAnimal != null)
                    {
                        if (pastoreo.FechaFin != null)
                        {
                            DateTime fechaFinPastoreo = (DateTime)pastoreo.FechaFin;
                            Dias = fechaFinPastoreo.Subtract(pastoreo.FechaInicio).Days;

                            LoteAnimal lote = LoteAnimal.Buscar(pastoreo.IdLote);
                            if (lote.HayBovino())
                            {
                                if (Dias > 720)
                                    racion += 1 * Dias;
                                else if (Dias > 180 && Dias < 720)
                                    racion += 0.6 * Dias;
                                else
                                    racion += 0;

                            }
                            if (lote.HayOvinoCaprino())
                            {
                                if (Dias > 360)
                                    racion += 0.15 * Dias;
                                if (Dias < 360)
                                    racion += 0;

                            }
                        }

                    }
            
            
            return racion;


        }

       

        #endregion


    }
}