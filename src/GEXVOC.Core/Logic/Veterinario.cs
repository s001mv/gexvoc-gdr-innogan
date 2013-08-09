using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Veterinario : IClaseBase
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

            //Valor predenterminado idExplotacion
            if (this.IdExplotacion == 0)
                this.IdExplotacion = Configuracion.Explotacion.Id;


            VeterinarioData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            VeterinarioData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            VeterinarioData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
             IClaseBase rtno=null;           

                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new Veterinario();
                        break;
                    case TipoContexto.Modificacion:
                        rtno = VeterinarioData.GetVeterinarioOP(this.Id);
                        break;
                }
                return rtno;

        }


        /// <summary>
        /// Obtiene un/una Veterinario a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Veterinario con el id especificado.</returns>
        public static Veterinario Buscar(int id)
        {
            return VeterinarioData.GetVeterinario(id);
        }

        public static Veterinario Buscar(string nombrecompleto)
        {
            return VeterinarioData.GetVeterinario(nombrecompleto);
        }

        /// <summary>
        /// Obtiene los/las Veterinario que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Veterinario> Buscar(int? idExplotacion,string nombre, string apellidos, string dni, string direccion, string cp, string telefono, DateTime? fechaNacimiento,int? idTipo)
        {
            return VeterinarioData.GetVeterinarios(idExplotacion,nombre, apellidos, dni, direccion, cp, telefono, fechaNacimiento, idTipo);
        }
        public static List<Veterinario> Buscar()
        {
            return VeterinarioData.GetVeterinarios(null,string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, null, null);
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
        { get { return this.Nombre + " " + this.Apellidos; } }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Tipo a la que pertenece el elemento
        ///// </summary>
        public string DescTipo
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.TipoPersonal != null)
                    rtno = this.TipoPersonal.Descripcion;

                return rtno;
            }
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida
        /// </summary>
        /// <param name="eliminar"></param>
        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion== TipoOperacion.Borrado)
            {
                List<SincronizacionCelo> lstSincCelo = Logic.SincronizacionCelo.Buscar(null, this.Id, null, null, null, null);
                if (lstSincCelo != null && lstSincCelo.Count > 0)
                    throw new LogicException("El Personal: " + NombreCompleto + " no puede ser borrado porque ha sido utilizado en el registro de Sincronizaciones de Celo.");

                List<Celo> lstCelo = Logic.Celo.Buscar(null, this.Id,  null);
                if (lstCelo != null && lstCelo.Count > 0)
                    throw new LogicException("El Personal: " + NombreCompleto + " no puede ser borrado porque ha sido utilizado en el registro de Celos.");

                List<DiagAnimal> lstDiagAnimal = Logic.DiagAnimal.Buscar(null, this.Id, null,null,null);
                if (lstDiagAnimal != null && lstDiagAnimal.Count > 0)
                    throw new LogicException("El Personal: " + NombreCompleto + " no puede ser borrado porque ha sido utilizado en el registro de Diagnósticos.");

                List<Inseminacion> lstInseminacion = Logic.Inseminacion.Buscar(null,null, null,this.Id, null, null,null,null);
                if (lstInseminacion != null && lstInseminacion.Count > 0)
                    throw new LogicException("El Personal: " + NombreCompleto + " no puede ser borrado porque ha sido utilizado en el registro de Inseminaciones.");

                List<Resena> lstResena = Logic.Resena.Buscar(null, this.Id, string.Empty, null);
                if (lstResena != null && lstResena.Count > 0)
                    throw new LogicException("El Personal: " + NombreCompleto + " no puede ser borrado porque ha sido utilizado en el registro de Reseñas.");

                List<TratEnfermedad> lstTratEnfermedad = Logic.TratEnfermedad.Buscar(null, null, string.Empty, null,null,null,null,null,this.Id);
                if (lstTratEnfermedad != null && lstTratEnfermedad.Count > 0)
                    throw new LogicException("El Personal: " + NombreCompleto + " no puede ser borrado porque ha sido utilizado en el registro de Tratamientos de Enfermedades.");

                List<PlaVet> Procesos = Logic.PlaVet.Buscar(null, this.Id, null, null);
                if (Procesos != null && Procesos.Count > 0)
                    throw new LogicException("El Personal: " + NombreCompleto + " no puede ser borrado porque ha sido utilizado en el registro de procesos de producción.");
            }

        }
        #endregion


    }
}