using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Lactacion : IClaseBase
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

            if (this.IdHembra!=0)//Asignar el número a la lactación
            {
                Animal animal = Animal.Buscar(this.IdHembra);
                this.Numero = animal.lstLactaciones.Count + 1;                
            }
            


            LactacionData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            LactacionData.Actualizar(this);
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
                //Recorro la lista de lactación extendida que está asociada a esta lactación.
                foreach (Extendida extendida in lstLactacionExtendida)
                    extendida.Eliminar();
               
                //Borrado de la lactación.
                LactacionData.Eliminar(this);
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
                        rtno = new Lactacion();//Es una insercion
                        break;
                    case TipoContexto.Modificacion:
                        rtno = LactacionData.GetLactacionOP(this.Id);
                        break;
                }
                return rtno;

        }


        /// <summary>
        /// Obtiene un/una Lactacion a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Lactacion con el id especificado.</returns>
        public static Lactacion Buscar(int id)
        {
            return LactacionData.GetLactacion(id);
        }

        /// <summary>
        /// Obtiene los/las Lactacion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Lactacion> Buscar(int? idHembra, DateTime? fechaInicio, DateTime? fechaFin, Boolean? modificable)
        {
            return LactacionData.GetLactaciones(idHembra, fechaInicio, fechaFin, modificable);
        }
        public static List<Lactacion> Buscar(int? idHembra, DateTime? fechaIntervaloInicio, DateTime? fechaIntervaloFin)
        {
            return LactacionData.GetLactaciones(idHembra, fechaIntervaloInicio,fechaIntervaloFin);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Lactacion
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Lactacion> Buscar()
        {
            return LactacionData.GetLactaciones(null,null,null,null);
        }

        public static Lactacion BuscarLactacionAbierta(int idHembra)
        {
            return LactacionData.GetLactacioAbierta(idHembra);
        }
        public static Lactacion BuscarLactacionabiertaIdLactacion(int idLactacion)
        {
            return LactacionData.GetLactacioAbiertaIdLactacion(idLactacion);
        }





        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

        
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

           public List<ControlLeche> lstControlesLeche
            {
             get { return ControlLecheData.GetControlesLeche(this.Id,null,null,null,null,null,null,null); }
            }
           public List<Extendida> lstLactacionExtendida
           {
               get { return Logic.Extendida.Buscar(this.Id, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null); }

           }
            

           public List<Secado> lstSecadosLactacion
           {
               get { return Secado.Buscar(null, null, this.IdHembra, null, null); }
           }

           public ControlLeche PrimerControl()
           {
               ControlLeche rtno = null;
               try
               {
                   List<ControlLeche> lista = lstControlesLeche;
                   if (lista != null)
                       rtno = lista.OrderBy(p => p.Id).First();
               }
               catch (Exception)
               {}
               
               
               return rtno;
           }
           public ControlLeche UltimoControl()
           {
               ControlLeche rtno = null;
               try
               {
                   List<ControlLeche> lista = lstControlesLeche;
                   if (lista != null)
                       rtno = lista.OrderByDescending(p => p.Id).First();
               }
               catch (Exception)
               { }


               return rtno;
           }

        


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO


           private void ValidarLogica(TipoOperacion operacion)
           {
               //if (operacion== TipoOperacion.Insercion)               
               //    this.Numero=Animal.lstLactaciones.Count;


               if (operacion == TipoOperacion.Insercion)
               {
                   Animal hembra = Animal.Buscar(this.IdHembra);
                   DateTime? UltimafechaPartoAborto = hembra.UltimaFechaParto_Aborto(hembra.Id);
                   if (UltimafechaPartoAborto.HasValue && this.FechaInicio <= UltimafechaPartoAborto.Value)
                       throw new LogicException("La fecha de la lactación debe ser mayor a la última fecha de parto o aborto de la hembra, que se corresponde con la fecha: " + UltimafechaPartoAborto.Value.ToShortDateString());

                   //Comprobar que no se tenga ninguna lactación abierta.
                   if (hembra.UltimaLactacionAbierta() != null)
                       throw new LogicException("Esta hembra ya tiene una lactación abierta.");

                   ///Comprobar que se ha producido un parto o aborto desde la última lactación existente (Que está cerrada si no saldria por la excepción anterior).
                   Lactacion ultimalactacion = hembra.UltimaLactacion();
                   if (UltimafechaPartoAborto.HasValue && ultimalactacion != null && (UltimafechaPartoAborto.Value < ultimalactacion.FechaFin))                   
                       throw new LogicException("No se ha producido un parto o aborto desde la última lactación. El registro no puede ser creado.");

                   ///Comprobar que no se metan lactaciones anteriores a la última
                   if (ultimalactacion != null && (ultimalactacion.FechaFin.Value > this.FechaInicio))
                       throw new LogicException("La fecha de la lactación debe ser mayor a la fecha fin de la última lactación que se corresponde con: " + ultimalactacion.FechaFin.Value.ToShortDateString());
                   
           
               }
           }
           public static void CalcularProduccion(Lactacion lactacion)
           {
               if (lactacion!=null)
               {
                   lactacion.OrdenarControles();
                   CalcularProduccion(lactacion, true, false);
                   CalcularProduccion(lactacion, false, false);
                   CalcularProduccionExtendida(lactacion);
                   
               }
               

           }

           public static void CalcularProduccion(Lactacion lactacionActual, bool normalizada, bool controlLechero)
           {
               Lactacion lactacion = lactacionActual;
               int NumControles = default(int);
               decimal leche = default(decimal);
               decimal grasa=default(decimal);
               decimal proteina=default(decimal);
               
               //Se establece el número de controles válidos, teniendo en cuenta que
               //la lactación normalizada no puede superar los 305 días.
               if (normalizada)
                   for (NumControles = 0; NumControles < lactacion.lstControlesLeche.Count; NumControles++)
                   {
                       ControlLeche controles = (ControlLeche)lactacion.lstControlesLeche[NumControles];
                       if (controles.Fecha.Subtract(lactacion.FechaInicio).Days >= 305)
                       {
                           NumControles += 1;
                           break;
                       }
                   }
               else
                   NumControles = lactacion.lstControlesLeche.Count;
               for (int i = 0; i < NumControles; i++)
               { 
                   // Control actual.
                   ControlLeche controlActual = (ControlLeche)lactacion.lstControlesLeche[i];
                   int diasLactacion = controlActual.Fecha.Subtract(lactacion.FechaInicio).Days;
                   decimal lecheControl =Convert.ToDecimal(controlActual.LecheManana + controlActual.LecheTarde + controlActual.LecheNoche);
                   decimal grasaControl = default(decimal);
                   decimal proteinaControl = default(decimal);
                   if (controlActual.lstMuestrasControl!=null && controlActual.lstMuestrasControl.Count > 0 && controlActual.lstMuestrasControl[0] != null)
                   {
                       MuestraControl muestras = (MuestraControl)controlActual.lstMuestrasControl[0];
                       grasaControl =(decimal) (lecheControl * muestras.Grasa) / 100;
                       proteinaControl =(decimal) (lecheControl * muestras.Proteina) / 100;
                       muestras = null;
                   }
                   // Control siguiente.
                   ControlLeche controlSiguiente = null;
                   int diasLactacionSiguiente = default(int);
                   decimal lecheControlSiguiente = default(decimal);
                   decimal grasaControlSiguiente = default(decimal);
                   decimal proteinaControlSiguiente = default(decimal);
                   if ((i + 1) < NumControles)
                   {
                       controlSiguiente = (ControlLeche)lactacion.lstControlesLeche[i + 1];
                       diasLactacionSiguiente = controlSiguiente.Fecha.Subtract(lactacion.FechaInicio).Days;
                       lecheControlSiguiente =Convert.ToDecimal(controlSiguiente.LecheManana + controlSiguiente.LecheTarde + controlSiguiente.LecheNoche);
                       if (controlSiguiente.lstMuestrasControl.Count > 0 && controlSiguiente.lstMuestrasControl[0] != null)
                       {
                           MuestraControl muestras = (MuestraControl)controlSiguiente.lstMuestrasControl[0];
                           grasaControlSiguiente =(decimal) (lecheControlSiguiente * muestras.Grasa) / 100;
                           proteinaControlSiguiente =(decimal) (lecheControlSiguiente * muestras.Proteina) / 100;
                           muestras = null;
                       }
                   }
                   //Primer control: la producción desde el inicio de la lactación hasta el primer control es la 
                   //multiplicación de la producción del primer control por los días transcurridos desde la fecha.
                   if (i == 0)
                   {
                       int diasInicio = controlActual.Fecha.Subtract(lactacion.FechaInicio).Days;
                       leche = lecheControl * diasInicio;
                       grasa = grasaControl * diasInicio;
                       proteina = proteinaControl * diasInicio;
                   }
                   //Cálculo de todos los controles a excepción del último.
                   if (controlSiguiente != null)
                   {
                       int dias = default(int);
                       // Si el control siguiente supera los 305 días, lo truncamos a este valor.
                       if (normalizada)
                           dias = diasLactacionSiguiente > 305 ? 305 : dias = diasLactacionSiguiente;
                       else
                           dias = diasLactacionSiguiente;
                       leche += (lecheControl + lecheControlSiguiente) / 2 * (dias - diasLactacion);
                       grasa += (grasaControl + grasaControlSiguiente) / 2 * (dias - diasLactacion);
                       proteina += (proteinaControl + proteinaControlSiguiente) / 2 * (dias - diasLactacion);
                   }
                   //Último control de lactación: se multiplica la producción del último control por los días que
                   //trascurren hasta el secado. En caso de no tener secado, no se tiene en cuenta este último control.
                   if (controlSiguiente == null && NumControles == lactacion.lstControlesLeche.Count && lactacion.lstSecadosLactacion.Count > 0)
                   {
                       int diasFinal = default(int);
                       if (normalizada && diasLactacion < 305)
                       {
                           if (((Secado)lactacion.lstSecadosLactacion[lactacion.lstSecadosLactacion.Count - 1]).Fecha.Subtract(lactacion.FechaInicio).Days > 305)
                               diasFinal = 305 - diasLactacion;
                           else
                               diasFinal = ((Secado)lactacion.lstSecadosLactacion[lactacion.lstSecadosLactacion.Count - 1]).Fecha.Subtract(controlActual.Fecha).Days;
                           leche += lecheControl * diasFinal;
                           grasa += grasaControl * diasFinal;
                           proteina += proteinaControl * diasFinal;
                       }
                       if (!normalizada)
                       {
                           diasFinal = ((Secado)lactacion.lstSecadosLactacion[lactacion.lstSecadosLactacion.Count - 1]).Fecha.Subtract(controlActual.Fecha).Days;
                           leche += lecheControl * diasFinal;
                           grasa += grasaControl * diasFinal;
                           proteina += proteinaControl * diasFinal;
                       }

                   }
                   controlActual = null;
                   controlSiguiente = null;
               
               }
               leche = decimal.Round(leche, 0, MidpointRounding.AwayFromZero);
               grasa = decimal.Round(grasa, 0, MidpointRounding.AwayFromZero);
               proteina = decimal.Round(proteina, 0, MidpointRounding.AwayFromZero);
               if (!controlLechero)
               {
                   Extendida extendida = null;
                   bool nueva = false;
                   if (lactacion.lstLactacionExtendida.Count > 0)
                       extendida = (Extendida)lactacion.lstLactacionExtendida[0];
                   else
                   {
                       extendida = new Extendida();
                       extendida.IdLactacion = lactacion.Id;
                       nueva = true;
                   }
                   if (normalizada)
                   {
                       extendida.LecheNorm = leche;
                       extendida.GrasaNorm = grasa;
                       extendida.ProteinaNorm = proteina;
                   }
                   else
                   {
                       extendida.Leche = leche;
                       extendida.Grasa = grasa;
                       extendida.Proteina = proteina;
                   }
                   if (nueva)
                   {
                       extendida.Insertar();
                   }
                   else
                       extendida.Actualizar();
                   extendida = null;


               }
               lactacion = null;
               
           
           }
            /// <summary>
            /// Realiza el cálculo de producción a 305 días.
            /// </summary>
            /// <param name="lactacionActual">Lactación sobre la que se realiza el cálculo.</param>
           public static void CalcularProduccionExtendida(Lactacion lactacionActual)
           { 
           //Parámetros
               double Cv = 0.9974;
               double Cn = 0.9985;
               int diasLactacion = default(int);
               double lecheTotal = default(double);
               double grasaTotal = default(double);
               double proteinaTotal = default(double);
               double lecheHoy = default(double);
               double grasaHoy = default(double);
               double proteinaHoy = default(double);
               decimal ProduccionLeche = default(decimal);
               decimal ProduccionGrasa = default(decimal);
               decimal ProduccionProteina = default(decimal);
               Lactacion lactacion = lactacionActual;
               ControlLeche controlUltimo = null;
               if (lactacion.lstControlesLeche.Count > 0)
               {
                   controlUltimo = (ControlLeche)lactacion.lstControlesLeche[lactacion.lstControlesLeche.Count - 1];
               }
               else
                   controlUltimo = new ControlLeche();
                   
               Extendida extendida = null;
               
               bool nueva = false;
               if (lactacion.lstLactacionExtendida.Count > 0)
                   extendida = (Extendida)lactacion.lstLactacionExtendida[0];
               else
               {
                   extendida = new Extendida();
                   extendida.IdLactacion = lactacion.Id;
                   nueva = true;
               }
               diasLactacion = controlUltimo.Fecha.Subtract(lactacion.FechaInicio).Days;
               if (diasLactacion >= 60 && diasLactacion <= 305)
               {
                   lecheTotal = Convert.ToDouble(extendida.Leche);
                   grasaTotal = Convert.ToDouble(extendida.Grasa);
                   proteinaTotal = Convert.ToDouble(extendida.Proteina);

                   lecheHoy = Convert.ToDouble(controlUltimo.LecheManana + controlUltimo.LecheTarde + controlUltimo.LecheNoche);
                   if (controlUltimo.lstMuestrasControl.Count == 1 && controlUltimo.lstMuestrasControl[0] != null)
                   {
                       MuestraControl muestra = (MuestraControl)controlUltimo.lstMuestrasControl[0];
                       grasaHoy = (lecheHoy * Convert.ToDouble(muestra.Grasa)) / 100;
                       proteinaHoy = (lecheHoy * Convert.ToDouble(muestra.Proteina)) / 100;
                       muestra = null;
                   }
                   //El cálculo de producción difiere en el parámetro a aplicar en relación a si es vaca o novilla.
                   Animal animal =Animal.Buscar(lactacion.IdHembra);
                   if (animal.FechaNacimiento != null && DateTime.Today.Subtract(animal.FechaNacimiento).Days <= 365 && animal.lstPartos.Count < 2)
                   {
                       ProduccionLeche = Convert.ToDecimal(Math.Round(lecheTotal + (lecheHoy / Math.Log(Cv)) * (Math.Pow(Cv, 305 - diasLactacion) - 1 / Cv)));
                       ProduccionGrasa = Convert.ToDecimal(Math.Round(grasaTotal + (grasaHoy / Math.Log(Cv)) * (Math.Pow(Cv, 305 - diasLactacion) - 1 / Cv)));
                       ProduccionProteina = Convert.ToDecimal(Math.Round(proteinaTotal + (proteinaHoy / Math.Log(Cv)) * (Math.Pow(Cv, 305 - diasLactacion) - 1 / Cv)));
                   }
                   else
                   {
                       ProduccionLeche = Convert.ToDecimal(Math.Round(lecheTotal + (lecheHoy / Math.Log(Cn)) * (Math.Pow(Cn, 305 - diasLactacion) - 1 / Cn)));
                       ProduccionGrasa = Convert.ToDecimal(Math.Round(grasaTotal + (grasaHoy / Math.Log(Cn)) * (Math.Pow(Cn, 305 - diasLactacion) - 1 / Cn)));
                       ProduccionProteina = Convert.ToDecimal(Math.Round(proteinaTotal + (proteinaHoy / Math.Log(Cn)) * (Math.Pow(Cn, 305 - diasLactacion) - 1 / Cn)));
                   }
                  
               }
               extendida.LecheExt = decimal.Round(ProduccionLeche, 0, MidpointRounding.AwayFromZero);
               extendida.GrasaExt = decimal.Round(ProduccionGrasa, 0, MidpointRounding.AwayFromZero);
               extendida.ProteinaExt = decimal.Round(ProduccionProteina, 0, MidpointRounding.AwayFromZero);
               if (nueva)
               {
                   extendida.Insertar();
               }
               else
                   extendida.Actualizar();

               extendida = null;
               controlUltimo = null;
               lactacion = null;
               
               
           }
           /// <summary>
           /// Ordena los cotroles por fecha antes de realizar los calculos de producción.
           /// </summary>
           public void OrdenarControles()
           { 
           for (int i=1;i<=this.lstControlesLeche.Count-1; i++)
               for (int j = this.lstControlesLeche.Count - 1; j >= i; j--)
               {
                   ControlLeche aux = null;
                   if (((ControlLeche)this.lstControlesLeche[j - 1]).Fecha > ((ControlLeche)this.lstControlesLeche[j]).Fecha)
                   {
                       aux = (ControlLeche)this.lstControlesLeche[j - 1];
                       this.lstControlesLeche[j - 1] = this.lstControlesLeche[j];
                       this.lstControlesLeche[j] = aux;
                   }
               }
           
           }



        #endregion


    }
}