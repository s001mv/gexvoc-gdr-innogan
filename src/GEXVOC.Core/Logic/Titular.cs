using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Titular : IClaseBase
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
            TitularData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);

            TitularData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);

            Boolean TransacionPropia = false;
            try
            {
                
                TransacionPropia=BDController.IniciarTransaccion();
                               
                //Elimiar los datos relacionados con el titular que vamos a borrar (Tabla ExpTit)
                List<ExpTit> lstExpTit = GEXVOC.Core.Logic.ExpTit.Buscar(null, this.Id, null, null);
                foreach (ExpTit exptit in lstExpTit)
                    exptit.Eliminar();
                

                TitularData.Eliminar(this);
                if (TransacionPropia)
                   BDController.FinalizarTransaccion(true);

            }
            catch (Exception ex)
            { 
                if (TransacionPropia)
                    BDController.FinalizarTransaccion(false);
                Traza.RegistrarError(ex);
                throw new LogicException(ex.Message);
            }
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;       

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Titular();
                    break;
                case TipoContexto.Modificacion:
                    rtno = TitularData.GetTitularOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Titular a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Titular con el id especificado.</returns>
        public static Titular Buscar(int id)
        {
            return TitularData.GetTitular(id);
        }

        /// <summary>
        /// Obtiene los/las Titular que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Titular> Buscar(string nombre,string apellidos,string direccion,string CP, string DNI, string telefono,DateTime? fechaNacimiento,DateTime? fechaAlta,DateTime? fechaBaja)
        {
            return TitularData.GetTitulares(nombre,apellidos,direccion,CP,DNI,telefono,fechaNacimiento,fechaAlta,fechaBaja);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Titular
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Titular> Buscar()
        {
            return TitularData.GetTitulares(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,null,null,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

        public string NombreCompleto
        {
            get { return this.Nombre + " " + this.Apellidos; }
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        public List<Explotacion> lstExplotaciones
        {
            get {return TitularData.GetExplotaciones(this.Id); }

        }
        public List<Cuenta> lstCuentas
        {
            get { return Logic.Cuenta.Buscar(this.Id, string.Empty, string.Empty, string.Empty); }

        }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        partial void OnDNIChanging(string value)
        {
            if (value.Length != 9)
                throw new LogicException("Formato de DNI incorrecto");
            //throw new NotImplementedException();
        }
        

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida
        /// </summary>
        /// <param name="eliminar"></param>
        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion == TipoOperacion.Borrado)
            {
                //Obtengo una lista con las cuentas asociadas de ese titular
                List<Cuenta> lstCuentas = Logic.Cuenta.Buscar(this.Id, string.Empty, string.Empty, string.Empty);
                if (lstCuentas!=null && lstCuentas.Count>0)
                    throw new LogicException("No se puede eliminar el titular: " + NombreCompleto + " porque tiene cuentas bancarias relacionadas.");
                List<Parcela> lstParcelas = Logic.Parcela.Buscar(null, this.Id, string.Empty, string.Empty, null);
                if (lstParcelas != null && lstParcelas.Count > 0)
                    throw new LogicException("No se puede eliminar el titular: " + NombreCompleto + " porque tiene parcelas relacionadas.");
               

            }
            if (operacion==TipoOperacion.Insercion || operacion== TipoOperacion.Actualizacion)
            {
                if (this.FechaBaja.HasValue && this.FechaBaja.Value<this.FechaAlta)                
                    throw new LogicException ("La fecha de baja del titular debe ser posterior a la fecha de alta");
                
            }
        }

        #endregion


    }
}
