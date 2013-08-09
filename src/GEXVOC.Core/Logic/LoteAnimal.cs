using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class LoteAnimal : IClaseBase
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
            LoteAnimalData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            LoteAnimalData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);

            List<AniLot> lstAniLot = this.lstAniLot;
            foreach (AniLot item in lstAniLot)            
                item.Eliminar();

                       
           
                

            LoteAnimalData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;         

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new LoteAnimal();
                    break;
                case TipoContexto.Modificacion:
                    rtno = LoteAnimalData.GetLoteAnimalOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una LoteAnimal a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>LoteAnimal con el id especificado.</returns>
        public static LoteAnimal Buscar(int id)
        {
            return LoteAnimalData.GetLoteAnimal(id);
        }

        /// <summary>
        /// Obtiene los/las LoteAnimal que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<LoteAnimal> Buscar(int? idExplotacion, string descripcion, 
                                                        DateTime? fechaAlta, DateTime? fechaBaja,int? idParidera,int? idTipo)
        {
            return LoteAnimalData.GetLotesAnimales(idExplotacion,  descripcion,  fechaAlta, fechaBaja,idParidera,idTipo);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo LoteAnimal
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<LoteAnimal> Buscar()
        {
            return LoteAnimalData.GetLotesAnimales(null,string.Empty,null,null,null,null);
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
        ///// Propiedad que devuelve la descripción de el/la Tipo a la que pertenece el elemento
        ///// </summary>
        public string DescTipo
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.TipoLote != null)
                    rtno = this.TipoLote.Descripcion;

                return rtno;
            }
        }

        public Cubricion UltimaCubricion()
        {
            Cubricion rtno = null;
            try
            {

                if (lstCubriciones.Count > 0)
                {
                    //try//Primero cojo el que tiene fecha fin nulo (Es el ultimo lote)
                    //{
                    //    rtno = lstCubriciones.Where(E => E.FechaFin == null).First();
                    //}
                    //catch (InvalidOperationException)
                    //{ }
                    //if (rtno!=null)
                        rtno = lstCubriciones.OrderByDescending(p => p.FechaInicio).First();
                                          
                    
                    
                }
            }
            catch (Exception)
            { }

            return rtno;
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        public List<AniLot> lstAniLot
        {
            get
            {
                return Logic.AniLot.Buscar(this.Id, null, null, null);
                 //    return Animal.Buscar(null,null,null,null,null,null,null,null,this.Id, string.Empty,string.Empty,string.Empty,string.Empty,null, null, null,null,string.Empty,null,null); 
            }

        }

        /// <summary>
        /// Nos retorna una lista con los animales del lote.
        /// Existen 2 posibilidades:
        ///     - Lote Normal: retorna los animales que se correspoden con el lote
        ///     - Lote Paridera: retorna los animales de cada uno de los lotes que contienen su id en el campo IdParidera
        /// </summary>
        public List<Animal> lstAnimales {
            get
            {
                List<Animal> rtno = null;
                if (Configuracion.TipoLoteSistema(Configuracion.TiposLoteSistema.LOTE_DE_PARIDERA).Id!=this.IdTipo)//(!(Paridera??false))//Caso Lote normal//PTE: CAMBIAR POR TIPOLOTE==PARIDERA
                {//Es un lote normal
                    rtno = LoteAnimalData.GetAnimales(this.Id);
                }
                else//Caso de lote de Paridera (Lote que agrupa lotes)
                {
                    Dictionary<int, Animal> parcial = new Dictionary<int, Animal>();//Creo un conjunto de datos con indice para no repetir animales.                   
                    foreach (LoteAnimal item in lstLotesParidera)//Recorro todos los lotes asociados al lote actual. (Campo IdParidera==LoteActual.Id)
                    {
                        foreach (Animal animal in item.lstAnimales)//Recorro todos los animales de cada uno de los lotes asociados al lote actual.
                        {
                            try
                            {
                                if (!parcial.ContainsKey(animal.Id))//Si no se encuentra en la lista lo añado.
                                    parcial.Add(animal.Id, animal); 
                            }
                            catch (Exception){}
                            
                        }
                        
                    }

                    //Cargo la lista de los animales con los elementos procesados anteriormente (No existen elementos duplicados)
                    rtno = new List<Animal>();
                    foreach (KeyValuePair<int, Animal> item in parcial)
                        rtno.Add(item.Value);
                    
                
                }

                return rtno;               

            }
        }

        public List<LoteAnimal> lstLotesParidera
        {
            get
            {
                //return null; //PTE: BUSCAR LOS QUE EL TIPO DE LOTE SEA PARIDERA.
                return Logic.LoteAnimal.Buscar(null, null,null,null, this.Id,null);
                //    return Animal.Buscar(null,null,null,null,null,null,null,null,this.Id, string.Empty,string.Empty,string.Empty,string.Empty,null, null, null,null,string.Empty,null,null); 
            }

        }
        
        public List<Cubricion> lstCubriciones
        {
            get
            {
                return Logic.Cubricion.Buscar(this.Id, null,null, null);                
            }

        }
        public List<Pastoreo> lstPastoreo
        {
            get
            {
                return Logic.Pastoreo.Buscar(null,this.Id, null, null);
            }

        }
        /// <summary>
        /// Nos dice si en el lote hay bovino.
        /// </summary>
        /// <returns></returns>
        public bool HayBovino()
        {
           Animal A=null;
           bool rtno=false;

                foreach (Animal animal in this.lstAnimales)
                    if (animal != null && animal.Raza != null && animal.Raza.Especie != null)
                    {
                        Especie especie = Especie.Buscar(animal.Raza.IdEspecie);
                        if (especie.Descripcion =="BOVINA")
                        {
                            A = animal;
                            break;
                        }
                    }
                    if (A != null)
                        rtno = true;
                return rtno; 
            
        }

        public bool HayOvinoCaprino()
        {
            Animal A = null;
            bool rtno = false;

            foreach (Animal animal in this.lstAnimales)
                if (animal != null && animal.Raza != null && animal.Raza.Especie != null)
                {
                    Especie especie = Especie.Buscar(animal.Raza.IdEspecie);
                    if (especie.Descripcion == "CAPRINA" || especie.Descripcion == "OVINA" || (especie.Descripcion == "OVINA" && especie.Descripcion == "CAPRINA"))
                    {
                        A = animal;
                        break;
                    }
                }
            if (A != null)
                rtno = true;
            return rtno; 
        
        }
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
            private void ValidarLogica(TipoOperacion operacion)
            {
                if (operacion == TipoOperacion.Actualizacion )
                {
                    LoteAnimal datosAnteriores = LoteAnimal.Buscar(this.Id);
                    if (datosAnteriores.FechaBaja!=this.FechaBaja && this.FechaBaja!=null)
                    {//Ha cambiado la fecha baja, debemos actualizar la fecha fin de los animales del lote
                        foreach (AniLot item in lstAniLot)
                        {
                            if (item.FechaFin==null ||item.FechaFin==datosAnteriores.FechaBaja)
                            {
                                AniLot actualizar=(AniLot)item.CargarContextoOperacion(TipoContexto.Modificacion);
                                actualizar.FechaFin = this.FechaBaja;
                            }
                        }
                    }
                }
                if (operacion== TipoOperacion.Borrado)
                {
                    List<Cubricion> lstCubriciones = this.lstCubriciones;
                    if (lstCubriciones != null && lstCubriciones.Count > 0)
                        throw new LogicException("El Lote: " + Descripcion + " no puede ser borrado porque tiene Cubriciones.");
                    
                    List<LoteAnimal> lstParidera = this.lstLotesParidera;
                    if (lstParidera != null && lstParidera.Count > 0)
                        throw new LogicException("El Lote: " + Descripcion + " no puede ser borrado porque contiene lotes asignados.");

                    List<Pastoreo> lstPastorero = this.lstPastoreo;
                    if (lstPastorero != null && lstPastorero.Count > 0)
                        throw new LogicException("El Lote: " + Descripcion + " no puede ser borrado porque ha sido asignado a pastoreo.");

                }
            }

           
            partial void OnIdParideraChanging(int? value)
            {
                if (this.IdParidera!=null && value!=null)
                    throw new LogicException("No es posible asignar el lote: " + this.Descripcion + " a la paridera, porque ya ha sido asociado anteriormente a otra paridera.");
                if (this.IdTipo==Configuracion.TipoLoteSistema(Configuracion.TiposLoteSistema.LOTE_DE_PARIDERA).Id)                
                    throw new LogicException("No es posible asignar el lote: " + this.Descripcion + " a la paridera, porque dicho lote ya está identificado como una paridera.");
                
            }
            partial void OnFechaBajaChanging(DateTime? value)
            {
                if (value != null)
                {
                    //comprobar que la fecha fin no sea menor a la fecha inicio
                    if (this.FechaAlta > (DateTime)value)
                        throw new LogicException("La fecha de baja debe ser mayor o igual a la fecha de alta");

                    //comprobar que la fecha de baja no sea menor que cualquiera de las fechas de inicio del lote de animales
                    //porque el establecer una fecha de baja al lote implica actualizar todos los animales que pertenecen a el, con esta fecha
                    foreach (AniLot item in lstAniLot)
                    {
                        if(item.FechaInicio>(DateTime)value)
                            throw new LogicException("La fecha de baja debe ser mayor o igual que cualquiera de las fechas de alta introducidas en el lote,\r" + 
                                "El animal: " + item.DescAnimalNombre + ", ha sido dado de alta el " + item.FechaInicio.ToShortDateString() + 
                                " y por tanto no cumple esta condición");
                        if (item.FechaFin!=null && item.FechaFin > (DateTime)value)
                            throw new LogicException("La fecha de baja debe ser mayor o igual que cualquiera de las fechas de baja introducidas en el lote,\r" +
                                "El animal: " + item.DescAnimalNombre + ", ha sido dado de baja el " + ((DateTime)item.FechaFin).ToShortDateString() +
                                " y por tanto no cumple esta condición.");
                    }
                    foreach (Cubricion item in this.lstCubriciones)
                    {
                        if (item.FechaInicio>(DateTime)value)                        
                              throw new LogicException("La fecha de baja debe ser mayor o igual que cualquiera de las fechas de inicio de las cubriciones en el lote,\r" + 
                                "existe un lote con fecha inicio: " + item.FechaInicio.ToShortDateString() +  " y por tanto no se cumple esta condición.");

                        //#MOD_A2
                        if (item.FechaFin!=null && item.FechaFin>(DateTime)value)                        
                            throw new LogicException("La fecha de baja debe ser mayor o igual que cualquiera de las fechas de fin de las cubriciones en el lote,\r" +
                                "existe un lote con fecha fin: " + item.FechaFin.Value.ToShortDateString() + " y por tanto no se cumple esta condición.");
                        
                        
                        
                    }
                }
            }
        #endregion


    }
}