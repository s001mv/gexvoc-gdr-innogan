using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Gasto : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            if (this.IdExplotacion == 0)
                this.IdExplotacion = Configuracion.Explotacion.Id;            
            GastoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ActualizarImporteReceta();

            GastoData.Actualizar(this);
        }


        /// <summary>
        /// Las recetas generan gastos, y estos deben estar siempre sincronizados con el importe en la receta.        
        /// </summary>
        /// <param name="eliminar"></param>
        private void ActualizarImporteReceta()
        {
            if (this.IdReceta != null)
            {
                Receta receta = Receta.Buscar((int)this.IdReceta);
                if ((receta.Importe != this.Total))
                {
                    receta = (Receta)receta.CargarContextoOperacion(TipoContexto.Modificacion);
                    receta.Importe = this.Total;
                    receta.Actualizar();
                }

            }
        }

        /// <summary>
        /// Cuando el gasto pertenece a una receta, cuando este se borra, estableceremos en la receta un importe '0'
        /// NOTA: normalmente en estos casos las propia receta ya eliminaría el gasto, por eso esta actualización se realiza despues
        /// de borrar el propio gasto, para que no se intente borrar mas de una vez, y con ello cause un error.
        /// </summary>
        /// <param name="idReceta"></param>
        private void EliminarImporteReceta(int idReceta)
        {
          
                Receta receta = Receta.Buscar(idReceta);
                if (receta.Importe != 0)
                {
                    receta = (Receta)receta.CargarContextoOperacion(TipoContexto.Modificacion);
                    receta.Importe = 0;
                    receta.Actualizar();                    
                }
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            
            int? idReceta = this.IdReceta;//Guardamos el idReceta si es que lo tiene, para despues poder llamar a eliminar importe receta.
             
            GastoData.Eliminar(this);

            if (idReceta!=null)//Nota importante, la actualizacion debe ser realizada despues de haber sido eliminado el gasto, peligro de bucle infinito si no se realiza asi.             
                 EliminarImporteReceta((int)idReceta);
             
           
            
            
            
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Gasto();
                    break;
                case TipoContexto.Modificacion:
                    rtno = GastoData.GetGastoOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Gasto a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Gasto con el id especificado.</returns>
        public static Gasto Buscar(int id)
        {
            return GastoData.GetGasto(id);
        }

        
        /// <summary>
        /// Obtiene los/las Gasto que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Gasto> Buscar(int? idNaturaleza, int? idExplotacion, int? idAnimal, int? idTratamiento, int? idReceta, int? idParcela, int? idAsignacion, int? idSiembra, int? idAbonado, int? idTratParcela, string detalle, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual, decimal? importe, decimal? total, int? idInseminacion)
        {
            return GastoData.GetGastos(idNaturaleza, idExplotacion, idAnimal, idTratamiento, idReceta, idParcela, idAsignacion, idSiembra, idAbonado, idTratParcela, detalle, fechaMayorIgual, fechaMenorIgual, importe,total,idInseminacion);
        }


        /// <summary>
        /// Obtiene todos los registros del tipo Gasto
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Gasto> Buscar()
        {
            return GastoData.GetGastos(null, null, null, null, null, null, null, null, null, null, string.Empty, null, null, null,null,null);
        }


        /// <summary>
        /// Obtiene registros del tipo Gasto coincidentes con el filtro
        /// </summary>
        /// <returns></returns>
        public static List<Gasto> BuscarTratamientos(int? idTratProfilaxis, int? idProducto, int? idTratHigiene)
        {
            return GastoData.GetGastosTratamientos(idTratProfilaxis, idProducto, idTratHigiene);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID
        /// <summary>
        /// Propiedad que devuelve la descripcion de la explotación que tiene que ver con el gasto.
        /// </summary>
        public string DescExplotacion
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Explotacion != null)
                    rtno = this.Explotacion.Nombre;
                return rtno;
            }
        }
        /// <summary>
        /// Propiedad que devuelve la descripcion del tipo de gasto.
        /// </summary>
        public string DescTipo
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Naturaleza != null)
                    rtno = this.Naturaleza.Descripcion;
                return rtno;
            
            }
        }

       
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        public static bool AnimalExistenteEnGastos(int idAnimal)
        {
            return GastoData.AnimalExistenteEnGastos(idAnimal);
        }


        public static ResultadoOperacion GenerarGasto(TipoOperacion operacion, object clase)
        {
            ResultadoOperacion rtno = new ResultadoOperacion() { OperacionCorrecta = true };
            GastoDefinicion Gasto = null;          

            if (clase.GetType().GetInterface(typeof(IControlGasto).Name) != null)
            {
                try
                {
                    Gasto = ((IControlGasto)clase).ToGasto(operacion);

                    ///**** INICIO - CALCULO EL IMPORTE Y PRECIO TOTAL QUE DEPENDEN DE SI LA OPERACION ES INSERCION O ACTUALIZACION            
                    if (!Gasto.OmitirCalculPrecio)
                    {
                        try
                        {
                            if (operacion == TipoOperacion.Insercion)
                            {
                                //El importe y el total dependen de la operacion en cuestión
                                Gasto.Importe = Stock.PrecioProducto(Gasto.IdProducto, Gasto.IdMacho);
                                Gasto.Total = Gasto.Importe * Gasto.Cantidad * Gasto.Extension;
                            }
                            if (operacion == TipoOperacion.Actualizacion)
                            {
                                if (Gasto.GastoActual != null)
                                {
                                    if (Gasto.IdProductoAnterior != null)//Si ha cambiado el producto el importe no es el almacenado en gastos si no el importe del producto nuevo.
                                    {
                                        Gasto.ImporteAnterior = Gasto.GastoActual.Importe;
                                        Gasto.Importe = Stock.PrecioProducto(Gasto.IdProducto, Gasto.IdMacho);
                                    }
                                    else
                                        Gasto.Importe = Gasto.GastoActual.Importe;

                                    if ((Gasto.ImporteAnterior ?? Gasto.Importe) * (Gasto.CantidadAnterior ?? Gasto.Cantidad) * (Gasto.ExtensionAnterior ?? Gasto.Extension) == Gasto.GastoActual.Total)
                                        Gasto.Total = Gasto.Importe * Gasto.Cantidad * Gasto.Extension;//Solo actualizo el total si el usuario no ha cambiado el total del gasto manualmente.
                                    else
                                        Gasto.Total = Gasto.GastoActual.Total;//Dejo el gasto total sin modificar
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Traza.RegistrarError("No se ha podido calcular el total. Detalle: " + ex.Message);
                        }                        
                    }                    
                    ///****FIN - CALCULO EL IMPORTE Y PRECIO TOTAL QUE DEPENDEN DE SI LA OPERACION ES INSERCION O ACTUALIZACION



                    switch (operacion)
                    {
                        case TipoOperacion.Insercion:
                            Gasto NuevoGasto = new Gasto()
                            {
                                IdExplotacion = Configuracion.Explotacion.Id,
                                IdNaturaleza = Gasto.IdNaturaleza,
                                IdAnimal = Gasto.IdAnimal,
                                IdTratamiento = Gasto.IdTratamiento,
                                IdReceta = Gasto.IdReceta,
                                IdParcela = Gasto.IdParcela,
                                IdAsignacion = Gasto.IdAsignacion,
                                IdSiembra = Gasto.IdSiembra,
                                IdAbonado = Gasto.IdAbonado,
                                IdTratParcela = Gasto.IdTratParcela,
                                IdInseminacion = Gasto.IdInseminacion,
                                IdTratHigiene=Gasto.IdTratHigiene,
                                IdProducto=Gasto.IdProductoTratamientos,
                                IdTratProfilaxis=Gasto.IdTratProfilaxis,
                                Detalle = Gasto.Detalle,
                                Fecha = Gasto.Fecha,
                                Importe = Gasto.Importe,
                                Total = Gasto.Total,
                            };
                            NuevoGasto.Insertar();

                            break;
                        case TipoOperacion.Borrado:
                            if (Gasto.GastoActual != null)
                                Gasto.GastoActual.Eliminar();
                            break;
                        case TipoOperacion.Actualizacion:
                            if (Gasto.GastoActual != null)
                            {
                                //Gasto.GastoActual = (Gasto)Gasto.GastoActual.CargarContextoOperacion(TipoContexto.Modificacion);
                                Gasto.GastoActual.IdAnimal = Gasto.IdAnimal;
                                Gasto.GastoActual.IdTratamiento = Gasto.IdTratamiento;
                                Gasto.GastoActual.IdReceta = Gasto.IdReceta;
                                Gasto.GastoActual.IdParcela = Gasto.IdParcela;
                                Gasto.GastoActual.IdAsignacion = Gasto.IdAsignacion;
                                Gasto.GastoActual.IdSiembra = Gasto.IdSiembra;
                                Gasto.GastoActual.IdAbonado = Gasto.IdAbonado;
                                Gasto.GastoActual.IdTratParcela = Gasto.IdTratParcela;
                                Gasto.GastoActual.IdInseminacion = Gasto.IdInseminacion;                                  
                                Gasto.GastoActual.IdTratHigiene=Gasto.IdTratHigiene;
                                Gasto.GastoActual.IdProducto=Gasto.IdProductoTratamientos;
                                Gasto.GastoActual.IdTratProfilaxis = Gasto.IdTratProfilaxis;
                                Gasto.GastoActual.Detalle = Gasto.Detalle;
                                Gasto.GastoActual.Fecha = Gasto.Fecha;
                                Gasto.GastoActual.Importe = Gasto.Importe;
                                Gasto.GastoActual.Total = Gasto.Total;
                                Gasto.GastoActual.Actualizar();                                
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw new LogicException("Error guardando: " + ex.Message);
                    //rtno.OperacionCorrecta = false;
                    //rtno.Mensaje = ex.Message;
                }

            }
            else
            {
                rtno.OperacionCorrecta = true;
                rtno.Mensaje = "El Objeto proporcionado no implementa IControlGasto. Se omitirá cualquier operación";
            }

            return rtno;
        }
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        
        #endregion


    }
}