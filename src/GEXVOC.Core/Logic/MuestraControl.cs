using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;
using GEXVOC.Core.Logic;


namespace GEXVOC.Core.Logic
{
    public partial class MuestraControl : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            MuestraControlData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            MuestraControlData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            
           
                MuestraControlData.Eliminar(this);
           
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;       

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new MuestraControl();//Es una insercion
                    break;
                case TipoContexto.Modificacion:
                    rtno = MuestraControlData.GetMuestraControlOP(this.Id);//Es una modificacion
                    break;
            }
            return rtno;
        }


        /// <summary>
        /// Obtiene un/una MuestraControl a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>MuestraControl con el id especificado.</returns>
        public static MuestraControl Buscar(int id)
        {
            return MuestraControlData.GetMuestraControl(id);
        }

        /// <summary>
        /// Obtiene los/las MuestraControl que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<MuestraControl> Buscar(int? idControl, int? idLaboratorio, DateTime? fecha, decimal? rctoRegular, decimal? grasa, decimal? urea, decimal? proteina, decimal? lactosa, decimal? extractoSeco, decimal? linealPto, decimal? germenes, decimal? puntoCrioscopico, Boolean? ionhibidores)
        {
            return MuestraControlData.GetMuestraControles(idControl,idLaboratorio,fecha,rctoRegular,grasa,urea,proteina,lactosa,extractoSeco,linealPto,germenes,puntoCrioscopico,ionhibidores);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo MuestraControl
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<MuestraControl> Buscar()
        {
            return MuestraControlData.GetMuestraControles(null, null, null, null, null, null, null, null, null, null,null,null,null);
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

        


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        
        //public void CargarDatos()
        
        //{
            
               
        //    List<Animal> lstAnimal = Animal.Buscar(null, null, null, null, null, null, null, Configuracion.Explotacion.Id, string.Empty, string.Empty, string.Empty, string.Empty, null, null, null, null, string.Empty, null, null);
        //    foreach (Animal animal in lstAnimal)
        //    {
        //        Lactacion lactacion = Lactacion.BuscarLactacionAbierta(animal.Id);
        //        Parto partos = null;
        //        Secado secados = null;
        //        if (animal.lstPartos.Count > 0)
        //            partos = (Parto)animal.lstPartos[animal.lstPartos.Count - 1];
        //        if (animal.lstSecados.Count > 0)
        //            secados = (Secado)animal.lstSecados[animal.lstSecados.Count - 1];

        //        decimal? manana = null;
        //        decimal? tarde = null;
        //        decimal? noche = null;
        //        if (partos != null && partos.Fecha <= this.Fecha && (secados == null || partos.Fecha > secados.Fecha))
        //        {
        //            if (lactacion != null && this.Fecha >= ((ControlLeche)lactacion.lstControlesLeche[0]).Fecha)
        //            {
        //                ControlLeche control = null;
        //                MuestraControl Muestra = null;

        //                foreach (ControlLeche controlLeche in lactacion.lstControlesLeche)
        //                    if (controlLeche.Fecha == this.Fecha)
        //                    {
        //                        control = controlLeche;
        //                        break;
        //                    }
        //                if (control != null)
        //                {
        //                    this.IdControl = control.IdControl;

        //                    if (control.LecheManana != 0)
        //                        manana = control.LecheManana;
        //                    if (control.LecheTarde != 0)
        //                        tarde = control.LecheTarde;
        //                    if (control.LecheNoche != 0)
        //                        noche = control.LecheNoche;
        //                    if (control.lstMuestrasControl.Count == 1)
        //                        Muestra = (MuestraControl)control.lstMuestrasControl[0];

        //                    if (Muestra != null)
        //                    {
        //                        this.Id = Muestra.Id;
        //                        if (Muestra.RctoCelular != 0)
        //                            this.RctoCelular = Muestra.RctoCelular;
        //                        if (Muestra.Grasa != 0)
        //                            this.Grasa = Muestra.Grasa;
        //                        if (Muestra.Urea != 0)
        //                            this.Urea = Muestra.Urea;
        //                        if (Muestra.Proteina != 0)
        //                            this.Proteina = Muestra.Proteina;
        //                        if (Muestra.Lactosa != 0)
        //                            this.Lactosa = Muestra.Lactosa;
        //                        if (Muestra.ExtractoSeco != 0)
        //                            this.ExtractoSeco = Muestra.ExtractoSeco;
        //                        if (Muestra.ExtractoSecoMagro != 0)
        //                            this.ExtractoSecoMagro = Muestra.ExtractoSecoMagro;
        //                        if (Muestra.ExtractoQuesero != 0)
        //                            this.ExtractoQuesero = Muestra.ExtractoQuesero;
        //                        if (Muestra.LinealPto != 0)
        //                            this.LinealPto = Muestra.LinealPto;
        //                        if (Muestra.Germenes != 0)
        //                            this.Germenes = Muestra.Germenes;
        //                        if (Muestra.PuntoCrioscopico != 0)
        //                            this.PuntoCrioscopico = Muestra.PuntoCrioscopico;
        //                        if (Muestra.Ionhibidores != null)
        //                            this.Ionhibidores = Muestra.Ionhibidores;


        //                    }


        //                }
        //                control = null;
        //                Muestra = null;
        //            }

                    
        //        }
        //        lactacion = null;

        //    }

        //}

        

        

        #endregion


    }
}
