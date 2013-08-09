using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Marcador : IClaseBase
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
            MarcadorData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            MarcadorData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            MarcadorData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Marcador();
                    break;
                case TipoContexto.Modificacion:
                    rtno = MarcadorData.GetMarcadorOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Marcador a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Marcador con el id especificado.</returns>
        public static Marcador Buscar(int id)
        {
            return MarcadorData.GetMarcador(id);
        }

        /// <summary>
        /// Obtiene los/las Marcador que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Marcador> Buscar(int? idTipoAnalisis, int? idEspecie, string marcador)
        {
            return MarcadorData.GetMarcadores(idTipoAnalisis,idEspecie,marcador);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Marcador
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Marcador> Buscar()
        {
            return MarcadorData.GetMarcadores(null,null,string.Empty);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        public string DescTipoAnalisis
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Tipo != null)
                    rtno = this.Tipo.Descripcion;
                return rtno;
            }
        }

        public string DescEspecie
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Especie != null)
                    rtno = this.Especie.Descripcion;
                return rtno;
            }
        
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.
        public List<Combinacion> lstCombinacion1
        { get{return Combinacion.Buscar(this.Id,null,string.Empty,string.Empty);}
        }
        public List<Combinacion> lstCombinacion2
        {
            get { return Combinacion.Buscar(null, this.Id, string.Empty, string.Empty); }
        }
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion == TipoOperacion.Borrado)
            {
                if (this.lstCombinacion1 != null && this.lstCombinacion1.Count>0)
                    throw new LogicException("No se puede eliminar este Marcador ya que se está utilizando en algun registro.");
                if (this.lstCombinacion2 != null && this.lstCombinacion2.Count>0)
                    throw new LogicException("No se puede eliminar este Marcador ya que se está utilizando en algun registro.");

            }
        }

        #endregion


    }
}
