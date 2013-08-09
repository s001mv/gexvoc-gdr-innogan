using System;
using System.Collections;
using GEXVOC.Core.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Configuration;
using System.Linq;

namespace GEXVOC.Core.Logic
{
    /// <summary>
    /// Representa una explotación.
    /// Nota: Implementa la interface IClaseBase
    /// </summary>
    public partial class Explotacion:IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
        #endregion

        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)


            /// <summary>
            /// Guarda la explotación.
            /// </summary>
            public void Insertar()
            {
                ExplotacionData.Insertar(this);
            }

            /// <summary>
            /// Actualiza la explotación.
            /// </summary>
            public void Actualizar()
            {
                ExplotacionData.Actualizar(this);                       
                if (Configuracion.Explotacion != null && this.Id == Configuracion.Explotacion.Id)//Si modifico la explotacion del sistema la actualizo.
                    Configuracion.Explotacion = this;
                  
            }

          
            /// <summary>
            /// Elimina una explotacion
            /// </summary>
            /// <param name="cascada">(Booleano) nos indica si debe borrar los registros dependientes o causar error.</param>
            public void Eliminar()
            {
                Boolean TransacionPropia = false;
                if (this.Id == Configuracion.Explotacion.Id)                    
                    throw new LogicException("No es posible eliminar la explotación que se encuentra en uso.");
                
                try
                {   //Iniciando la logica de negocio en el borrado.
                  
                    TransacionPropia=BDController.IniciarTransaccion();

                    Collection<int> colIdTitularesEliminar = new Collection<int>();//Creo una coleccion con los titulares que voy a eliminar
                    //puesto que dichos titulares no se encuentran asignados a ninguna otra explotacion.
                    
                    List<ExpTit> lstexptit=GEXVOC.Core.Logic.ExpTit.Buscar(this.Id, null, null,null);
                    foreach (ExpTit exptit in lstexptit)                    
                        if (GEXVOC.Core.Logic.ExpTit.Buscar(null, exptit.IdTitular, null, null).Count == 1)//Si no esta asignado como titular a otra explotacion                      
                            colIdTitularesEliminar.Add(exptit.IdTitular);

                    //Recorro la lista lstexptit y elimino todos los registros (en esta lista solo se encuentran cargados los registros 
                    //de la explotacion que vamos a eliminar
                    foreach (ExpTit exptit in lstexptit)                       
                        exptit.Eliminar();//Si da un error no continuamos con el borrado de la explotación pq no podremos hacerlo
                    
               
                    ////Elimino los objetos del tipo ExpEsp
                    List<ExpEsp> listaExpEsp = this.lstExpEsp;
                    foreach (ExpEsp item in listaExpEsp)                    
                        item.Eliminar();

                    //Elimino los objetos del tipo ExpMod
                    List<ExpMod> listaExpMod = this.lstExpMod;
                    foreach (ExpMod item in listaExpMod)
                        item.Eliminar();

                    
                    //if (listaExpEsp != null && listaExpEsp.Count > 0)
                    //    for (int i = listaExpEsp.Count - 1; i >= 0; i--)
                    //        listaExpEsp[i].Eliminar();
                 
                    //Elimino los ANIMALES de esta explotacion
                    List<Animal> listaAnimales=this.lstAnimales;
                    foreach (Animal item in listaAnimales)
                        item.Eliminar();

                    //Elimino los contactos de la explotacion
                    List<Contacto> listaContactos = this.lstContactos;
                    foreach (Contacto item in listaContactos)
                        item.Eliminar();

                    //Elimino los Lotes Animales de la explotacion
                    List<LoteAnimal> listaLoteAnimals = this.lstLotesAnimales;
                    foreach (LoteAnimal item in lstLotesAnimales)
                        item.Eliminar();

                    List<TratHigiene> lstTratHigiene = this.lstTratHigiene;
                    foreach (TratHigiene item in lstTratHigiene)
                        item.Eliminar();

                    //if (listaAnimales != null && listaAnimales.Count > 0)
                    //    for (int i = listaAnimales.Count - 1; i >= 0; i--)
                    //        listaAnimales[i].Eliminar();


                    ////Elimino los titulares asociados a esta explotación si no tiene filas en ExpTit (las de esta explotacion ya han sido borradas)                                               
                    foreach (int idTitular in colIdTitularesEliminar)
                    {
                        Titular titular = Titular.Buscar(idTitular);
                        if (titular!=null)
                            titular.Eliminar();
                    }

                    foreach (Plantilla item in this.lstPlantillas)
                        item.Eliminar();

                    foreach (Zona item in this.lstZonas)
                        item.Eliminar();

                    foreach (Maquinaria item in this.lstMaquinas)
                        item.Eliminar();
                    
                    //borrado de la explotacion
                    ExplotacionData.Eliminar(this);

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

            /// <summary>
            /// Obtiene una explotación a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>Explotación con el id especificado. (Sin contexto activo)</returns>
            public static Explotacion Buscar(int id)
            {
                return ExplotacionData.GetExplotacion(id);
            }
            /// <summary>
            /// Obtiene una Explotacion a partid de su id a partir del contexto de opeaciones
            /// Nota: dicho contexto debe estar abierto, de lo contrario se producirá un error            
            /// </summary>
            /// <param name="id"></param>
            /// <returns>Explotacion con contexto activo</returns>
            public static Explotacion BuscarOP(int id)
            {
                return ExplotacionData.GetExplotacionOP(id);
            }

            ///// <summary>
            ///// Obtiene una explotación a partir de su CEA.
            ///// </summary>
            ///// <param name="CEA">CEA.</param>
            ///// <returns>Explotación con el CEA especificado.</returns>
            //public static Explotacion Buscar(string cea)
            //{
            //    return ExplotacionData.GetExplotacion(cea);
            //}

            ///// <summary>
            ///// Obtiene las explotaciones que coinciden con los criterios de búsqueda.
            ///// </summary>
            ///// <param name="cea">CEA.</param>
            ///// <param name="nombre">Nombre.</param>
            ///// <param name="direccion">Dirección.</param>
            ///// <param name="provincia">Provincia.</param>
            ///// <param name="municipio">Municipio.</param>
            ///// <param name="cJuridica">Condición Jurídica.</param>
            ///// <returns>Explotaciones que coinciden con los criterios de búsqueda.</returns>
            //public static System.Linq.IQueryable<Explotacion> Buscar(string cea, string nombre, string direccion, int? provincia, int? municipio, int? cJuridica)
            //{
            //    return ExplotacionData.GetExplotaciones(cea, nombre, direccion, provincia, municipio, cJuridica);
            //}

            ///// <summary>
            ///// Obtiene las explotaciones que coinciden con los criterios de búsqueda.
            ///// Esta sobrecarga utiliza clases tipadas en vez de simples identificadores
            ///// Nota: Transformaremos las clases tipadas en sus Identificadores correspondientes y utilizaremos
            ///// la misma funcion de busqueda que la anterior sobrecarga.
            ///// </summary>
            ///// <param name="cea">CEA.</param>
            ///// <param name="nombre">Nombre.</param>
            ///// <param name="direccion">Dirección.</param>
            ///// <param name="provincia">Provincia (Clase)</param>
            ///// <param name="municipio">Municipio (Clase)</param>
            ///// <param name="cJuridica">Condición Jurídica (Clase)</param>
            ///// <returns>Explotaciones que coinciden con los criterios de búsqueda.</returns>
            //public static System.Linq.IQueryable<Explotacion> Buscar(string cea, string nombre, string direccion, Provincia provincia, Municipio municipio, CondicionJuridica cJuridica)
            //{
            //    ///Obtengo los valores identificativos de las clases para enviarselos a la funcion de obtención de datos segun criterio
            //    int? idprovincia=null;
            //    int? idmunicipio=null;
            //    int? idcJuridica=null;
            //    if (provincia != null)
            //        idprovincia = provincia.Id;
            //    if (municipio != null)
            //        idmunicipio = municipio.Id;
            //    if (cJuridica != null)
            //        idcJuridica = cJuridica.Id;

       
            //    return ExplotacionData.GetExplotaciones(cea, nombre, direccion, idprovincia, idmunicipio, idcJuridica);

               
            //}

            ///// <summary>
            ///// Retorna todos los registros
            ///// </summary>
            ///// <returns></returns>
            //public static System.Linq.IQueryable<Explotacion> Buscar()
            //{
            //    return ExplotacionData.GetExplotaciones(string.Empty, string.Empty, string.Empty, null, null, null);

            //}


            public static List<Explotacion> Buscar(string cea, string nombre, string direccion, int? idProvincia, int? idMunicipio,
                int? idCJuridica)
            {             

                return ExplotacionData.GetExplotaciones(cea, nombre, direccion, idProvincia, idMunicipio, idCJuridica);

            }
            public static List<Explotacion> Buscar(){                               
                return ExplotacionData.GetExplotaciones(string.Empty, string.Empty, string.Empty, null, null, null);
            }

            /// <summary>
            /// Retorna la explotacion actual, con contexto activo.
            /// </summary>
            /// <returns>Explotacion con contexto activo</returns>
            public IClaseBase CargarContextoOperacion(TipoContexto Modo)
            {
                IClaseBase rtno=null;
                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new Explotacion();//Es una insercion
                        break;
                    case TipoContexto.Modificacion:
                        rtno = ExplotacionData.GetExplotacionOP(this.Id);//Es una modificacion
                        break;
                }
                return rtno;

            }

            public static List<Cliente> BuscarClientes(int idExplotacion,string nombre, string direccion, string cp, string dni, string telefono, DateTime? fechaAlta, DateTime? fechaBaja)
            {
                return ExplotacionData.GetClientes(idExplotacion, nombre, direccion, cp, dni, telefono, fechaAlta, fechaBaja);
            }

            public static List<Proveedor> BuscarProveedores(int idExplotacion, string nombre, string direccion, string cp, string dni, string telefono, DateTime? fechaAlta, DateTime? fechaBaja)
            {
                return ExplotacionData.GetProveedores(idExplotacion, nombre, direccion, cp, dni, telefono, fechaAlta, fechaBaja);
            }

            public static List<Titular> BuscarTitulares(int idExplotacion, string nombre, string apellidos, string direccion, string CP, string DNI, string telefono, DateTime? fechaNacimiento, DateTime? fechaAlta, DateTime? fechaBaja)
            {
                return ExplotacionData.GetTitulares(idExplotacion, nombre, apellidos, direccion, CP, DNI, telefono, fechaNacimiento, fechaAlta, fechaBaja);
            }
       
        #endregion
        
        #region PROPIEDADES PERSONALIZADAS

        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

            /// <summary>
            /// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
            /// </summary>
            public string DescProvincia{
                get
                {
                    string rtno=string.Empty;
                    if (this!=null && this.Municipio != null && this.Municipio.Provincia != null) 
                       rtno=this.Municipio.Provincia.Descripcion;

                    return rtno;
                }
            }
            /// <summary>
            /// Propiedad que devuelve la descripción del municipio al que pertenece la explotación
            /// </summary>
            public string DescMunicipio { 
                get 
                {
                    string rtno = string.Empty;
                    if (this != null && this.Municipio != null)
                        rtno =this.Municipio.Descripcion;

                    return rtno;
                } 
            }
            public int? IdProvincia
            {
                get
                {
                    int? rtno=null;
                    if (this != null && this.Municipio != null && this.Municipio.Provincia !=null)
                        rtno = this.Municipio.Provincia.Id;

                    return rtno;
                }
            }

            //public System.Linq.IQueryable<Animal> AnimalesExistentes { get { return Animal.Buscar(this, string.Empty, null, null, string.Empty); } }
         
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de la explotación
        //Estos elementos proveen de nuevas características al elemento en cuestión
        
            
        
            /// <summary>
            /// Nos devuelve, para la explotación activa, todos sus titulares
            /// Hay que tener en cuenta que la relación Explotacion -> Titulares, es N:N por lo que 
            /// existe una tabla intermedia que los relaciona (ExpTit)
            /// </summary>
            public List<Titular> lstTitulares{
                get { return ExplotacionData.GetTitulares(this.Id); }
            }
            public List<Modulo> lstModulos
            {
                get { return ExplotacionData.GetModulos(this.Id); }
            }
            public Dictionary<string,Menu> lstMenusPermitidos 
            {
                get 
                {
                    Dictionary<string,Menu> lstMenu = new Dictionary<string,Menu>();                    

                    foreach (Modulo mod in lstModulos)
                    {
                        Dictionary<string, Menu> lstMenuModulo = mod.lstMenusPermitidos;
                         foreach (KeyValuePair<string, Menu> item in lstMenuModulo) 
                         {
                             try
                             {
                                 lstMenu.Add(item.Key,item.Value);
                             }
                             catch (Exception)//No pasa nada si ya esta añadido
                             {}
                         }
                   }     
                    
                    
                    
                   return lstMenu;

                }
            }


            Dictionary<string, Proceso> _lstProcesosPermitidos=null;
            public Dictionary<string, Proceso> lstProcesosPermitidos
            {
                get
                {
                    if (_lstProcesosPermitidos==null)
                    {
                        _lstProcesosPermitidos = new Dictionary<string, Proceso>();
                        foreach (Modulo mod in lstModulos)
                        {
                            Dictionary<string, Proceso> lstProcesosModulo = mod.lstProcesosPermitidos;
                            foreach (KeyValuePair<string, Proceso> item in lstProcesosModulo)
                            {
                                try
                                {
                                    _lstProcesosPermitidos.Add(item.Key, item.Value);
                                }
                                catch (Exception)//No pasa nada si ya esta añadido
                                { }
                            }
                        } 
    
                                  

                    }
                    return _lstProcesosPermitidos;
                }
            }

            public List<Cliente> lstClientes
            {
                get { return BuscarClientes(this.Id,null,null,null,null,null,null,null); }
            }

            public List<Proveedor> lstProveedores
            {
                get { return BuscarProveedores(this.Id, null, null, null, null, null, null, null); }
            }

            /// <summary>
            /// Nos devuelve, para la explotacion activa, todas las especies que tiene asignadas
            /// </summary>
            public List<Especie> lstEspecies
            {
                get { return ExplotacionData.GetEspecies(this.Id); }
            }

            /// <summary>
            /// Nos devuelve, para la explotacion activa, todas las relaciones con especies que tiene asignadas
            /// </summary>
            public List<ExpEsp> lstExpEsp{
                get { return ExpEspData.GetExpEsp(this.Id,null); }
            }
    
            /// <summary>
            /// Nos devuelve, para la explotación activa, todos sus animales
            /// </summary>
            public List<Animal> lstAnimales{
                get { return Logic.Animal.Buscar(null,   null, null, null, null, this.Id,  string.Empty, string.Empty, string.Empty, string.Empty, null, null, null, null,null,null); }
            }
            /// <summary>
            /// Nos devuelve, para la explotación actica, todos sus lotes
            /// </summary>
            public List<LoteAnimal> lstLotesAnimales
            {
                get { return LoteAnimalData.GetLotesAnimales(this.Id,string.Empty,null,null,null,null); }
            }

            public List<Contacto> lstContactos
            {
                get { return Logic.Contacto.Buscar(this.Id, null,string.Empty, string.Empty, string.Empty,string.Empty, string.Empty); }
            }

            /// <summary>
            /// Nos devuelve, para la explotacion activa, todas las relaciones con módulos que tiene asignadas
            /// </summary>
            public List<ExpMod> lstExpMod
            {
                get { return Logic.ExpMod.Buscar(this.Id, null); }
            }

            public List<TratHigiene> lstTratHigiene
            {
                get { return Logic.TratHigiene.Buscar(null,this.Id, null,null,null); }
            }

            public List<Plantilla> lstPlantillas
            {
                get { return Logic.Plantilla.Buscar(this.Id, string.Empty); }
            }

            public List<Zona> lstZonas
            {
                get { return Logic.Zona.Buscar(this.Id, string.Empty); }
            }

            public List<Maquinaria> lstMaquinas
            {
                get { return Logic.Maquinaria.Buscar(this.Id, string.Empty); }
            }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

            /// <summary>
            /// Valida el CEA de la explotación.
            /// </summary>
            /// <param name="value">CEA.</param>
            partial void OnCEAChanging(string value)
            {
                if (value.Length != 14)
                    throw new LogicException("El Campo CEA debe tener 14 caracteres");
            }
            partial void OnFechaBajaChanged()
            {
                if (FechaBaja!=null)                
                    if (FechaBaja < FechaAlta)
                        throw new LogicException("La fecha de baja de la explotación no puede ser anterior a la fecha de alta");
                    
                
            }
        #endregion       

           


    }
}
