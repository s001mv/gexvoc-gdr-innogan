using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Cliente : IClaseBase
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

            Boolean TransacionPropia = false;

            try
            {
                TransacionPropia = BDController.IniciarTransaccion();

                ClienteData.Insertar(this);

                if (!ExplotacionAsignada)
                    new ExpCli() { IdExplotacion = Configuracion.Explotacion.Id, IdCliente = this.Id, FechaInicio = DateTime.Today }.Insertar();

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

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            ClienteData.Actualizar(this);
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
                TransacionPropia = BDController.IniciarTransaccion();

                //Elimiar los datos relacionados con el cliente que vamos a borrar
                foreach (ExpCli EC in GEXVOC.Core.Logic.ExpCli.Buscar(null, this.Id, null, null))
                    EC.Eliminar();

                ClienteData.Eliminar(this);

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
                    rtno = new Cliente();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ClienteData.GetClienteOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Cliente a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Cliente con el id especificado.</returns>
        public static Cliente Buscar(int id)
        {
            return ClienteData.GetCliente(id);
        }

        /// <summary>
        /// Obtiene los/las Cliente que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Cliente> Buscar(string nombre, string direccion, string cp, string dni,string telefono,DateTime? fechaAlta, DateTime? fechaBaja)
        {
            return ClienteData.GetClientes(nombre,direccion,cp,dni,telefono,fechaAlta,fechaBaja);
        }
       

        /// <summary>
        /// Obtiene todos los registros del tipo Cliente
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Cliente> Buscar()
        {
            return ClienteData.GetClientes(string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,null,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS

            public bool ExplotacionAsignada { get; set; }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
            /// <summary>
            /// Valida la lógica de negocio, concluye si la operacion es admitida
            /// </summary>
            /// <param name="eliminar"></param>
            private void ValidarLogica(TipoOperacion operacion)
            {             
                if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
                {
                    if (this.FechaBaja.HasValue && this.FechaBaja.Value < this.FechaAlta)
                        throw new LogicException("La fecha de baja del cliente debe ser posterior a la fecha de alta");

                }
            }
        #endregion
    }
}
