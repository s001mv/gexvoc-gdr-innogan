using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class AniLot : IClaseBase
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
            ValorAutomaticoFechaFin();
            AniLotData.Insertar(this);
        }
        /// <summary>
        /// Establezo el valor de la fecha fin automaticamente si se cumplen las siguientes opciones:
        /// - El valor de fechabaja del lote esta valorado.
        /// - El valor de fecha fin de AniLot no se encuentra valorado.
        /// Si se cumple todo esto se hará la siguiente asignación: [AniLot.FechaFin=Lote.FechaBaja]
        /// </summary>
        private void ValorAutomaticoFechaFin()
        {           
            LoteAnimal lote = LoteAnimal.Buscar(this.IdLote);
            if (lote != null && lote.FechaBaja != null && this.FechaFin == null)                  
                this.FechaFin = lote.FechaBaja;
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            ValorAutomaticoFechaFin();
            AniLotData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            AniLotData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new AniLot();
                    break;
                case TipoContexto.Modificacion:
                    rtno = AniLotData.GetAniLotOP(this.IdLote,this.IdAnimal);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una AniLot a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>AniLot con el id especificado.</returns>
        public static AniLot Buscar(int idLote,int idAnimal)
        {
            return AniLotData.GetAniLot(idLote,idAnimal);
        }

        /// <summary>
        /// Obtiene los/las AniLot que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<AniLot> Buscar(int? idLote,int? idAnimal,DateTime? fechaInicio,DateTime? fechaFin)
        {
            return AniLotData.GetAniLotes(idLote,idAnimal,fechaInicio,fechaFin);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo AniLot
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<AniLot> Buscar()
        {
            return AniLotData.GetAniLotes(null,null,null,null);
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
        ///// Propiedad que devuelve la descripción de el/la AnimalSexo a la que pertenece el elemento
        ///// </summary>
        public string DescAnimalSexo
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Animal != null)
                    rtno = this.Animal.Sexo.ToString();

                return rtno;
            }
        }
        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la AnimalNombre a la que pertenece el elemento
        ///// </summary>
        public string DescAnimalNombre
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Animal != null)
                    rtno = this.Animal.Nombre;
                return rtno;
            }
        }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la AnimalIdentificador a la que pertenece el elemento
        ///// </summary>
        public string DescAnimalIdentificador
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Animal != null)
                    rtno = this.Animal.Identificador;

                return rtno;
            }
        }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Lote a la que pertenece el elemento
        ///// </summary>
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

        public int Id
        {
            get { return this.IdAnimal; }
            set { }

        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida.
        /// - Comprueba que no se inntente insertar un registro con clave duplicada, el mensaje indicado si no se cumple esta restricción será: 
        ///     "No es posible insertar el registro porque ya existe la relacion entre el animal y el Lote indicados"
        /// 
        /// </summary>
        /// <param name="eliminar"></param>
        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion == TipoOperacion.Insercion)
            {
                //*Inicio - Compruebo que no se inserte un indice duplicado
                AniLot anilot = AniLot.Buscar(this.IdLote, this.IdAnimal);
                if (anilot != null)
                    throw new LogicException("No es posible insertar el registro porque ya existe la relacion entre el Animal: " + anilot.DescAnimalNombre + " y el Lote: " + anilot.DescLote + ".");
                //*Fin - Compruebo que no se inserte un indice duplicado


                //**Inicio  - Compruebo que no se inserten animales activos en otro lote
                anilot = null;
                anilot = AniLotData.GetLoteActivo(this.IdAnimal);
                if (anilot != null)                                    
                    throw new LogicException("No es posible insertar el registro porque el Animal: " + anilot.DescAnimalNombre + " se encuentra activo en el lote: " + anilot.DescLote);
                //**Fin  - Compruebo que no se inserten animales activos en otro lote


                //***Inicio - Compruebo que todos los animales sean de la misma especie
                LoteAnimal lote = LoteAnimal.Buscar(this.IdLote);
                List<Animal> lstAnimales = lote.lstAnimales;
                if (lstAnimales != null && lstAnimales.Count > 0)
                {
                    Animal animalLote = lstAnimales.First();
                    Animal animalAgregar = Animal.Buscar(this.IdAnimal);
                    if (animalLote.DescIdEspecie != animalAgregar.DescIdEspecie)
                        throw new LogicException("No es posible insertar el animal: " + animalAgregar.Nombre + " en el lote: " + lote.Descripcion +
                            " porque un lote no puede contener animales de distintas especies.");
                }
                //***Fin - Compruebo que todos los animales sean de la misma especie                
            }
            
         
        }

        partial void OnFechaInicioChanged()
        {
            LoteAnimal lote = LoteAnimal.Buscar(this.IdLote);
            if (lote!=null)
            {
                if (lote.FechaBaja!=null && this.FechaInicio>(DateTime)lote.FechaBaja)                
                    throw new LogicException("La fecha inicio debe ser menor que la fecha de baja del lote que es: " + ((DateTime)lote.FechaBaja).ToShortDateString());                                                  
            }
            //throw new NotImplementedException();
        }

        partial void OnFechaFinChanging(DateTime? value)
        {
            if (value != null)
            {
                //comprobar que la fecha fin no sea menor a la fecha inicio
                if (this.FechaInicio > (DateTime)value)
                    throw new LogicException("La fecha fin debe ser mayor o igual a la fecha de inicio");

             
            }
            //comprobar que no pueda eliminar la fecha fin si el animal ha sido asignado a otro lote
            else if (this.FechaFin != null)//Si la fecha fin anterior tenia un valor y ahora se lo quitamos (value es null)
            {
                AniLot anilot = AniLotData.GetLoteActivo(this.IdAnimal);
                if (anilot != null)
                    throw new LogicException("No es posible  eliminar la fecha fin del Animal: " + anilot.DescAnimalNombre + ", pues se encuentra activo en el lote: " + anilot.DescLote +
                        ", y este cambio probocaría la activación en más de un lote simultaneamente");


            }


        }
        #endregion


    }
}