using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Secado : IClaseBase
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
                Animal hembra = Animal.BuscarOP((int)this.IdHembra);
                Lactacion lactacion = hembra.UltimaLactacionAbierta();
                if (lactacion != null)
                {
                    lactacion.FechaFin = lactacion.UltimoControl().Fecha;
                    lactacion.Actualizar();
                    Lactacion.CalcularProduccion(lactacion);
                }
                lactacion = null;
                SecadoData.Insertar(this);

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
            Boolean TransacionPropia = false;
            try
            {
                TransacionPropia = BDController.IniciarTransaccion();
                Animal hembra = Animal.BuscarOP((int)this.IdHembra);
                Lactacion.CalcularProduccion((Lactacion)hembra.UltimaLactacion());
                SecadoData.Actualizar(this);
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
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            Boolean TransacionPropia = false;
            try
            {
                TransacionPropia=BDController.IniciarTransaccion();
            Animal hembra = Animal.BuscarOP((int)this.IdHembra);            
            Lactacion ultimaLactacion = (Lactacion)hembra.UltimaLactacion();
            if (ultimaLactacion != null)
            {             
                if ( ultimaLactacion.FechaFin <= this.Fecha)   //ultimaLactacion.FechaInicio >= hembra.UltimaFechaParto_Aborto((int)this.IdHembra) 
                {
                    ultimaLactacion.FechaFin = null;
                    ultimaLactacion.Actualizar();
                }
                Lactacion.CalcularProduccion(ultimaLactacion);
            }
            SecadoData.Eliminar(this);
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
              IClaseBase rtno=null;        
          
                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new Secado();
                        break;
                    case TipoContexto.Modificacion:
                        rtno = SecadoData.GetSecadoOP(this.Id);
                        break;
                }
                return rtno;


        }


        /// <summary>
        /// Obtiene un/una Secado a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Secado con el id especificado.</returns>
        public static Secado Buscar(int id)
        {
            return SecadoData.GetSecado(id);
        }

        /// <summary>
        /// Obtiene los/las Secado que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Secado> Buscar(int? idTipo,int? idMotivo,int? idHembra, DateTime? fecha,Boolean? modificable)
        {
            return SecadoData.GetSecados(idTipo, idMotivo,idHembra, fecha, modificable);
        }
        public static List<Secado> Buscar(int? idTipo, int? idMotivo,int? idHembra, DateTime? fechaMayorIgual,DateTime? fechaMenorIgual, Boolean? modificable)
        {
            return SecadoData.GetSecados(idTipo,idMotivo, idHembra, fechaMayorIgual, fechaMenorIgual, modificable);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Secado
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Secado> Buscar()
        {
            return SecadoData.GetSecados(null,null,null,null,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        public string DescTipo 
        { 
            get {
                string rdo = string.Empty;
                if (this != null && this.Tipo != null)
                    rdo = this.Tipo.Descripcion;

                return rdo;
            } 
        }
        public string DescHembra
        {
            get
            {
                string rdo = string.Empty;
                if (this != null && this.Animal != null)
                    rdo = this.Animal.Nombre;

                return rdo;
            }
        }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Motivo a la que pertenece el elemento
        ///// </summary>
        public string DescMotivoSecado
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Motivo != null)
                    rtno = this.Motivo.Descripcion;

                return rtno;
            }
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        /// <summary>
        /// Obtiene la fecha de secado a partir de la parametrización correspondiente.
        /// </summary>
        /// <param name="idhembra">hembra a secar.</param>
        /// <param name="idSecado">Secado.</param>
        /// <param name="idTipoSecado">Tipo de secado.</param>
        /// <returns>Fecha de secado.</returns>
        public static DateTime ObtenerFecha(int idhembra, int idSecado, int idTipoSecado)
        {
            DateTime Fecha = DateTime.Today;
            try
            {
                Lactacion lactacion = Lactacion.BuscarLactacionAbierta(idhembra);
                Animal hembra = Animal.Buscar(idhembra);

                switch (idTipoSecado)
                {
                    case TipoSecado.IdPartoSinLactacion:
                        if (hembra.lstPartos.Count > 0)
                        {
                            Parto P = hembra.UltimoParto();
                            Secado S = null;

                            if (hembra.lstSecados.Count > 0)
                                S = hembra.UltimoSecado();

                            if (S != null)
                            {
                                if (P.Fecha > S.Fecha || S.Id == idSecado)
                                    Fecha = P.Fecha;
                                else
                                    Fecha = DateTime.Today;
                            }
                            else
                                Fecha = P.Fecha;

                            P = null;
                            S = null;
                        }
                        else
                            Fecha = DateTime.Today;

                        break;
                    case TipoSecado.IdNormalEstimado:
                        if (lactacion != null)
                            Fecha = lactacion.UltimoControl().Fecha.AddDays(hembra.SecadoNormalEstimado);
                        else
                            Fecha = DateTime.Today;

                        lactacion = null;

                        break;
                    case TipoSecado.IdAbortoConLactacion:
                        if (lactacion != null)
                            Fecha = lactacion.UltimoControl().Fecha.AddDays(hembra.SecadoAbortoConLactacion);
                        else
                            Fecha = DateTime.Today;

                        lactacion = null;

                        break;
                    case TipoSecado.Idhembravacaciones:
                        if (lactacion != null)
                            Fecha = lactacion.UltimoControl().Fecha.AddDays(hembra.SecadoDiasVaciones);
                        else
                            Fecha = DateTime.Today;

                        lactacion = null;

                        break;
                    default:
                        Fecha = DateTime.Today;
                        break;
                }           
            }
            catch (Exception)
            {
                Fecha=DateTime.Today;
                //throw;
            }
          

            return Fecha;
        }

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
                // Debe existir un parto a secar y que este sea posterior a los secados existentes.
                Animal hembra = Animal.Buscar(this.IdHembra);
                //if (hembra.lstPartos.Count() > 0)
                //{                  
                    DateTime? FUltimoParto_Aborto = hembra.UltimaFechaParto_Aborto(this.IdHembra);
                    Secado S = null;
                 
                    if (hembra.lstSecados.Count() > 0)
                        S = hembra.UltimoSecado();

                    if (FUltimoParto_Aborto == null)                    
                         throw new LogicException("La hembra no ha tenido ningún parto o aborto.");

                    if (S != null && FUltimoParto_Aborto.Value <= S.Fecha && S.Id != this.Id)
                        throw new LogicException("La hembra no ha tenido un parto o aborto desde el último secado.");

                    ///Fran: Puede ser que haya un parto sin secado y sin cerrar la lactacion
                    //if (this.Fecha < FUltimoParto_Aborto.Value)
                      //  throw new LogicException("La fecha de secado debe ser superior al " + FUltimoParto_Aborto.Value.AddDays(-1).ToShortDateString());
                //}
                //else
                //    throw new LogicException("La hembra no ha tenido un parto.");


                // El secado debe ser posterior a todos los controles en caso de tener lactación abierta.
                Lactacion lactacion = hembra.UltimaLactacionAbierta();//Obtener la ultima lactacion abierta (Sin fecha fin)
                if (lactacion != null && lactacion.FechaFin != null)
                {
                    DateTime FUltimoControl = lactacion.UltimoControl().Fecha;
                    if (FUltimoControl > this.Fecha)
                        throw new LogicException("La fecha de secado debe ser superior al " + FUltimoControl.AddDays(-1).ToShortDateString());

                }
                lactacion = null;

            //    ///Fran: Puede ser que haya un parto sin secado y sin cerrar la lactacion
            //   if (this.Fecha < FUltimoParto_Aborto.Value)
            //      throw new LogicException("Existe un parto o aborto con una fecha posterior a la que está especificando " + FUltimoParto_Aborto.Value.AddDays(-1).ToShortDateString());
            }
            else if (operacion == TipoOperacion.Borrado)
            {
                Animal hembra=Animal.Buscar(this.IdHembra);
                if (hembra.UltimaFechaParto_Aborto(this.IdHembra)>this.Fecha)
                    throw new LogicException("No se puede eliminar el secado con fecha " + this.Fecha.ToShortDateString() + " porque la hembra tiene un parto o un aborto posterior.");
            }  
        


        }
       
        
        

        #endregion


    }
}