using System;
using System.Collections;
using GEXVOC.Core.Data;
using System.Collections.Generic;
using System.Linq;
using GEXVOC.Core.Reflection;
using System.Reflection;
using System.Configuration;

namespace GEXVOC.Core.Logic
{



    public enum Claves
    {
        DiasAbortoConLactacion,
        DiasMaximoGestacion,
        DiasMinimoGestacion,
        DiasNormalEstimado,
        DiasVacaciones,
        IntervaloCelosInicio,
        IntervaloCelosFin,
        PeriodoInseminacionPostParto,
        TipoAperturaLactacion,
        ValorPredeterminadoNombreAnimal,
        DiasAlertaDiagnosticoInicio,
        DiasAlertaDiagnosticoFin,
        vBD
    }

  

    /// <summary>
    /// Representa la configuración del sistema.
    /// </summary>
    public partial class Configuracion
    {

        public static Hashtable Parametros = null;
        public static Explotacion Explotacion = null;

        /// <summary>
        /// Realiza la carga de la configuración.
        /// </summary>
        public static void Cargar()
        {
            Parametros = new Hashtable();

            List<Configuracion> lstConfiguracion = Configuracion.Buscar();
            foreach (Configuracion C in lstConfiguracion)
                Parametros.Add(C.Clave, C.Valor);

            Configuracion.RecargarListasSistema();
            
        }
        public enum ValorPredeterminadoNombreAnimal : int
        {
            [EnumDescription("Nombre")]
            Nombre = 0,
            [EnumDescription("DIB/CIB")]
            DIB = 1,
            [EnumDescription("Crotal")]
            Crotal = 2,
            [EnumDescription("Tatuaje")]
            Tatuaje = 3
        }
                
        
        #region DATOS SISTEMA

        #region TIPOS DE APERTURA LACTACION
        public enum TipoAperturaLactacion
        {
            Parto = 0,
            [EnumDescription("Primer Control")]
            Primer_control = 1,
        }

        public static TipoAperturaLactacion AperturaLactacion
        {
            get
            {
                TipoAperturaLactacion rtno;
                if (Convert.ToInt32(Parametros["TipoAperturaLactacion"]) == 1)
                    rtno = TipoAperturaLactacion.Primer_control;
                else
                    rtno = TipoAperturaLactacion.Parto;


                return rtno;


            }

        }

        #endregion

        #region TIPOS DE PRODUCTO DE SISTEMA
        /// <summary>
        /// Nos proporciona una lista con los tipos de productos que la aplicacion reconoce internamente
        /// esta lista debe estar contrastada con la tabla TiposProductos en la que cada elemento debe corresponderse
        /// con un registro con la misma descripción y el campo Sistema a True (se impide por lógica modificar estos valores)
        /// </summary>
        public enum TiposProductosSistema
        {
            [EnumDescription("ALIMENTACIÓN")]
            [EnumConfig(new string[] { "Descripcion", "Familia", "Sistema" }, new object[] { "ALIMENTACIÓN", true, true }, typeof(TipoProducto))]
            ALIMENTACION,          
            [EnumConfig(new string[] { "Descripcion", "Familia", "Sistema" }, new object[] { "SANIDAD", true, true }, typeof(TipoProducto))]
            SANIDAD,
            [EnumConfig(new string[] { "Descripcion", "Familia", "Sistema" }, new object[] { "HIGIENE", true, true }, typeof(TipoProducto))]
            HIGIENE,
            [EnumDescription("TRATAMIENTO PARCELA")]
            [EnumConfig(new string[] { "Descripcion", "Familia", "Sistema" }, new object[] { "TRATAMIENTO PARCELA", true, true }, typeof(TipoProducto))]
            TRATAMIENTO_PARCELA,
            [EnumDescription("PRODUCCIÓN")]
            [EnumConfig(new string[] { "Descripcion", "Familia", "Sistema" }, new object[] { "PRODUCCIÓN", true, true }, typeof(TipoProducto))]
            PRODUCCION,


            //[EnumConfig(new string[] { "Descripcion", "Familia", "Sistema" }, new object[] { "TRATAMIENTO PROFILAXIS", true, true }, typeof(TipoProducto))]
            //TRATAMIENTO_PROFILAXIS,

            //[EnumConfig(new string[] { "Descripcion", "Familia", "Sistema" }, new object[] { "PAJUELA DE SEMEN", false, true }, typeof(TipoProducto))]
            //PAJUELA_DE_SEMEN
            
          
            
          
        }

        /// <summary>
        /// Variable que guarda una lista de todos los tipos de productos que existen en la base de datos, se carga 
        /// cuando inicia la aplicacion (de ella solo extraeremos los tipos del sistema a si que no es  necesario que se 
        /// actualice ya que la lista de los elementos a los que se puede acceder dentro de ella es la enumeracion TiposProductoSistema
        /// </summary>
        private static List<TipoProducto> lstTiposProductos = null;//= TipoProducto.Buscar(null, null, true);

        /// <summary>
        /// Nos devuelve un objeto del tipo TipoProducto de acuerdo con el argumento especificado
        /// </summary>
        /// <param name="tipo">Es una enumeracion pública declarada en Configuración que define los nombres 
        /// de los tipos de productos posibles a buscar.</param>
        /// <returns></returns>
        public static TipoProducto TipoProductoSistema(TiposProductosSistema tipo)
        {
            TipoProducto rtno = null;

            try
            {
                if (!lstTiposProductos.Exists(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo)))
                    CrearPersistencia(tipo);

                rtno = lstTiposProductos.Single(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo));
            }
            catch (Exception) { }

            return rtno;
        }


        #endregion

        #region FAMILIAS DE SISTEMA


        public enum FamiliasSistema
        {
            /// <summary>
            /// Mucho cuidado con IdTipo
            /// </summary>            

            [EnumDescription("ABONO/FERTILIZANTE")]              
            [EnumConfig(new string[] { "Descripcion", "Sistema","IdTipo" },
                        new object[] { "ABONO/FERTILIZANTE", true, Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA },
                        typeof(Familia))]
            ABONO,
            [EnumConfig(new string[] { "Descripcion", "Sistema", "IdTipo" },
                        new object[] { "SEMILLA", true, Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA },
                        typeof(Familia))]   
            
            SEMILLA,
            [EnumDescription("PAJUELA SEMEN")]
            [EnumConfig(new string[] { "Descripcion", "Sistema", "IdTipo" },
                        new object[] { "PAJUELA SEMEN", true, Configuracion.TiposProductosSistema.PRODUCCION },
                        typeof(Familia))]
            PAJUELA_SEMEN

        }
        /// <summary>
        /// Variable que obtiene una lista de todas las familias de sistema de la base de datos.
        /// </summary>
        private static List<Familia> lstFamilias = null;//Se carga en RecargarListasSistema() //Producto.Buscar(null, null, null, null, null, true);

        public static Familia FamiliaSistema(FamiliasSistema tipo)
        {
            Familia rtno = null;
            try
            {
                if (!lstFamilias.Exists(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo)))
                    CrearPersistencia(tipo);

                rtno = lstFamilias.Single(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo));

            }
            catch (Exception ex)
            {
                Traza.RegistrarError(ex);
            }

            return rtno;
        }



        #endregion

        #region TIPOS DE INSEMINACION DE SISTEMA
        /// <summary>
        /// Nos proporciona una lista con los tipos de productos que la aplicacion reconoce internamente
        /// esta lista debe estar contrastada con la tabla TiposProductos en la que cada elemento debe corresponderse
        /// con un registro con la misma descripción y el campo Sistema a True (se impide por lógica modificar estos valores)
        /// </summary>
        public enum TiposInseminacionSistema
        {
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "INSEMINACIÓN ARTIFICIAL", true }, typeof(TipoInseminacion))]
            INSEMINACIÓN_ARTIFICIAL,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "TRANSPLANTE EMBRIONARIO", true }, typeof(TipoInseminacion))]
            TRANSPLANTE_EMBRIONARIO
        }

        /// <summary>
        /// Variable que guarda una lista de todos los tipos de productos que existen en la base de datos, se carga 
        /// cuando inicia la aplicacion (de ella solo extraeremos los tipos del sistema a si que no es  necesario que se 
        /// actualice ya que la lista de los elementos a los que se puede acceder dentro de ella es la enumeracion TiposProductoSistema
        /// </summary>
        private static List<TipoInseminacion> lstTiposInseminacion = null; //= TipoInseminacion.Buscar(string.Empty, true);
        /// <summary>
        /// Nos devuelve un objeto del tipo TipoProducto de acuerdo con el argumento especificado
        /// </summary>
        /// <param name="tipo">Es una enumeracion pública declarada en Configuración que define los nombres 
        /// de los tipos de productos posibles a buscar.</param>
        /// <returns></returns>
        public static TipoInseminacion TipoInseminacionSistema(TiposInseminacionSistema tipo)
        {
            TipoInseminacion rtno = null;

            try
            {
                if (!lstTiposInseminacion.Exists(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo)))
                    CrearPersistencia(tipo);

                rtno = lstTiposInseminacion.Single(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo));
            }
            catch (Exception) { }

            return rtno;
        }



        #endregion

        #region TIPOS DE ESPECIES DE SISTEMA
        public enum EspeciesSistema
        {
            [EnumConfig(new string[] { "Descripcion" }, new object[] { "BOVINA" }, typeof(Especie))]
            BOVINA,
            [EnumConfig(new string[] { "Descripcion" }, new object[] { "OVINA" }, typeof(Especie))]
            OVINA,
            [EnumConfig(new string[] { "Descripcion" }, new object[] { "CAPRINA" }, typeof(Especie))]
            CAPRINA
        }

        /// <summary>
        /// Variable que guarda una lista de todas las especies que existen en la base de datos, se carga 
        /// cuando inicia la aplicacion (de ella solo extraeremos los tipos del sistema a si que no es  necesario que se 
        /// actualice ya que la lista de los elementos a los que se puede acceder dentro de ella es la enumeracion EspeciesSistema
        /// </summary>
        private static List<Especie> lstEspeciesSistema = null;//= Especie.Buscar();
        /// <summary>
        /// Nos devuelve un objeto del tipo Especie de acuerdo con el argumento especificado
        /// </summary>
        /// <param name="tipo">Es una enumeracion pública declarada en Configuración que define los nombres 
        /// de los tipos de productos posibles a buscar.</param>
        /// <returns></returns>
        public static Especie EspecieSistema(EspeciesSistema tipo)
        {
            Especie rtno = null;
            try
            {
                if (!lstEspeciesSistema.Exists(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo)))
                    CrearPersistencia(tipo);

                rtno = lstEspeciesSistema.Single(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo));
            }
            catch (Exception) { }

            return rtno;
        }

        #endregion

        #region TIPOS DE ABORTO DE SISTEMA
        /// <summary>
        /// Nos proporciona una lista de los tipos de Aborto que aparecen en la tabla tipo de aborto y con el 
        /// campo sistema a true.
        /// </summary>
        public enum TiposAbortosSistema
        {
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "ABORTO CONTINUANDO LACTACIÓN", true }, typeof(TipoAborto))]
            ABORTO_CONTINUANDO_LACTACIÓN,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "ABORTO SEGUIDO DE NUEVA LACTACIÓN", true }, typeof(TipoAborto))]
            ABORTO_SEGUIDO_DE_NUEVA_LACTACIÓN,
        }
        /// <summary>
        /// Variable que obtiene una lista de todos los tipos de aborto de la base de datos.
        /// </summary>
        private static List<TipoAborto> lstTiposAbortos = null; //TipoAborto.Buscar(null, true);
        /// <summary>
        /// Nos devuelve un objeto TipoAborto de acuerdo con el argumento especificado.
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static TipoAborto TipoAbortoSistema(TiposAbortosSistema tipo)
        {
            TipoAborto rtno = null;
            try
            {
                if (!lstTiposAbortos.Exists(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo)))
                    CrearPersistencia(tipo);

                rtno = lstTiposAbortos.Single(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo));
            }
            catch (Exception) { }
            return rtno;
        }

        #endregion

        #region TIPOS DE MOMENTOPESO DE SISTEMA
        public enum MomentosPesoSistema
        {
            [EnumConfig(new string[] { "Descripcion" }, new object[] { "NACIMIENTO" }, typeof(Momento))]
            NACIMIENTO,
            [EnumConfig(new string[] { "Descripcion" }, new object[] { "DESTETE" }, typeof(Momento))]
            DESTETE
        }

        /// <summary>
        /// Variable que guarda una lista de todos los MOMENTO de PESO de sistema que existen en la base de datos, se carga 
        /// cuando inicia la aplicacion (de ella solo extraeremos los tipos del sistema a si que no es  necesario que se 
        /// actualice ya que la lista de los elementos a los que se puede acceder dentro de ella es la enumeracion MOMENTOPESOSistema
        /// </summary>
        private static List<Momento> lstMomentoPesoSistema = null;//= Momento.Buscar();
        /// <summary>
        /// Nos devuelve un objeto del tipo Momento de acuerdo con el argumento especificado
        /// </summary>
        /// <param name="tipo">Es una enumeracion pública declarada en Configuración que define los nombres 
        /// de los tipos de productos posibles a buscar.</param>
        /// <returns></returns>
        public static Momento MomentoPesoSistema(MomentosPesoSistema tipo)
        {
            Momento rtno = null;
            try
            {
                if (!lstMomentoPesoSistema.Exists(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo)))
                    CrearPersistencia(tipo);

                rtno = lstMomentoPesoSistema.Single(E => E.Descripcion ==  EnumConversiones.GetDescripcion(tipo));
            }
            catch (Exception) { }

            return rtno;
        }

        #endregion

        #region TIPOS DE ALTA DE SISTEMA
        /// <summary>
        /// Nos proporciona una lista de los tipos de Alta que aparecen en la tabla tipo de Alta y con el 
        /// campo sistema a true.
        /// </summary>
        public enum TiposAltaSistema
        {
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "NACIMIENTO", true }, typeof(TipoAlta))]
            NACIMIENTO,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "COMPRA A EXPLOTACIÓN CONOCIDA", true }, typeof(TipoAlta))]
            COMPRA_A_EXPLOTACIÓN_CONOCIDA,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "COMPRA EN MERCADO", true }, typeof(TipoAlta))]
            COMPRA_EN_MERCADO,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "DONACIÓN", true }, typeof(TipoAlta))]
            DONACIÓN
        }
        /// <summary>
        /// Variable que obtiene una lista de todos los tipos de Alta de la base de datos.
        /// </summary>
        private static List<TipoAlta> lstTiposAltas = null;//= TipoAlta.Buscar(null, true);

        /// <summary>
        /// Nos devuelve un objeto TipoAlta de acuerdo con el argumento especificado.
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static TipoAlta TipoAltaSistema(TiposAltaSistema tipo)
        {
            TipoAlta rtno = null;
            try
            {
                if (!lstTiposAltas.Exists(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo)))
                    CrearPersistencia(tipo);

                rtno = lstTiposAltas.Single(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo));
            }
            catch (Exception) { }
            return rtno;
        }

        #endregion

        #region TIPOS DE NATURALEZA-GASTOS DE SISTEMA
        public enum NaturalezasGastosSistema
        {
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "ALIMENTACION ANIMAL", true }, typeof(Naturaleza))]
            ALIMENTACION_ANIMAL,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "SIEMBRA FINCAS", true }, typeof(Naturaleza))]
            SIEMBRA_FINCAS,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "ABONADO FINCAS", true }, typeof(Naturaleza))]
            ABONADO_FINCAS,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "TRATAMIENTO FINCAS", true }, typeof(Naturaleza))]
            TRATAMIENTO_FINCAS,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "DIAGNOSTICO ENFERMEDAD ANIMAL", true }, typeof(Naturaleza))]
            DIAGNOSTICO_ENFERMEDAD_ANIMAL,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "INSEMINACION", true }, typeof(Naturaleza))]
            INSEMINACION,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "TRATAMIENTO HIGIENE", true }, typeof(Naturaleza))]
            TRATAMIENTO_HIGIENE,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "TRATAMIENTO PROFILAXIS", true }, typeof(Naturaleza))]
            TRATAMIENTO_PROFILAXIS,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "TRAZABILIDAD", true }, typeof(Naturaleza))]
            TRAZABILIDAD
        }

        /// <summary>
        /// Variable que guarda una lista de todos los tipos de productos que existen en la base de datos, se carga 
        /// cuando inicia la aplicacion (de ella solo extraeremos los tipos del sistema a si que no es  necesario que se 
        /// actualice ya que la lista de los elementos a los que se puede acceder dentro de ella es la enumeracion TiposProductoSistema
        /// </summary>
        private static List<Naturaleza> lstNaturalezaGastos = null;//= Naturaleza.Buscar(null, true);
        /// <summary>
        /// Nos devuelve un objeto del tipo TipoProducto de acuerdo con el argumento especificado
        /// </summary>
        /// <param name="tipo">Es una enumeracion pública declarada en Configuración que define los nombres 
        /// de los tipos de productos posibles a buscar.</param>
        /// <returns></returns>
        public static Naturaleza NaturalezaGastoSistema(NaturalezasGastosSistema tipo)
        {
            Naturaleza rtno = null;

            try
            {
                if (!lstNaturalezaGastos.Exists(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo)))
                    CrearPersistencia(tipo);

                rtno = lstNaturalezaGastos.Single(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo));
            }
            catch (Exception) { }

            return rtno;
        }
        #endregion

        #region TIPOS DE CONTACTOS DE SISTEMA
        /// <summary>
        /// Nos proporciona una lista de los tipos de Contactos que aparecen en la tabla TipoContacto y con el 
        /// campo sistema a true.
        /// </summary>
        public enum TiposContactosSistema
        {
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "PROVEEDOR", true }, typeof(TipoContacto))]
            PROVEEDOR,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "CLIENTE", true }, typeof(TipoContacto))]
            CLIENTE,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "PERSONAL", true }, typeof(TipoContacto))]
            PERSONAL,
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "TITULARES", true }, typeof(TipoContacto))]
            TITULARES
        }
        /// <summary>
        /// Variable que obtiene una lista de todos los tipos de Alta de la base de datos.
        /// </summary>
        private static List<TipoContacto> lstTiposContactos = null;//= TipoContacto.Buscar(null, true);
        /// <summary>
        /// Nos devuelve un objeto TipoContacto de acuerdo con el argumento especificado.
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static TipoContacto TipoContactoSistema(TiposContactosSistema tipo)
        {
            TipoContacto rtno = null;
            try
            {
                if (!lstTiposContactos.Exists(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo)))
                    CrearPersistencia(tipo);

                rtno = lstTiposContactos.Single(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo));
            }
            catch (Exception) { }
            return rtno;
        }

        #endregion

        #region PRODUCTOS DE SISTEMA


        public enum ProductosSistema
        {
            /// <summary>
            /// Mucho cuidado con IdTipo
            /// </summary>            
        
            [EnumConfig(new string[] { "Descripcion", "Sistema", "IdTipo","IdFamilia" },
                        new object[] { "PAJUELA PROPIA", true, Configuracion.TiposProductosSistema.PRODUCCION,Configuracion.FamiliasSistema.PAJUELA_SEMEN },
                        typeof(Producto))]
            PAJUELA_PROPIA
        }
        /// <summary>
        /// Variable que obtiene una lista de todos los tipos de Alta de la base de datos.
        /// </summary>
        private static List<Producto> lstProductos = null;//Se carga en RecargarListasSistema() //Producto.Buscar(null, null, null, null, null, true);

        public static Producto ProductoSistema(ProductosSistema tipo)
        {
            Producto rtno = null;
            try
            {
                if (!lstProductos.Exists(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo)))                
                    CrearPersistencia(tipo);

                rtno = lstProductos.Single(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo));

            }
            catch (Exception ex) { 
                Traza.RegistrarError(ex);
            }

            return rtno;
        }



        #endregion

        #region ESTADOS DE SISTEMA
        /// <summary>
        /// Nos proporciona una lista de los tipos de Contactos que aparecen en la tabla TipoContacto y con el 
        /// campo sistema a true.
        /// </summary>
        public enum EstadosSistema
        {
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "SEMENTAL", true }, typeof(Estado))]
            SEMENTAL
        }
        /// <summary>
        /// Variable que obtiene una lista de todos los tipos de Alta de la base de datos.
        /// </summary>
        private static List<Estado> lstEstadosSistema = null;
        /// <summary>
        /// Nos devuelve un objeto Estado de acuerdo con el argumento especificado.
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static Estado EstadoSistema(EstadosSistema tipo)
        {
            Estado rtno = null;
            try
            {
                if (!lstEstadosSistema.Exists(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo)))
                    CrearPersistencia(tipo);

                rtno = lstEstadosSistema.Single(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo));
            }
            catch (Exception) { }
            return rtno;
        }

        #endregion

        #region TIPOS DE LOTE DE SISTEMA
        /// <summary>
        /// Nos proporciona una lista de los tipos de TipoLote que aparecen en la tabla tipo de TipoLote y con el 
        /// campo sistema a true.
        /// </summary>
        public enum TiposLoteSistema
        {
            [EnumConfig(new string[] { "Descripcion", "Sistema" }, new object[] { "LOTE DE PARIDERA", true }, typeof(TipoLote))]
            LOTE_DE_PARIDERA            
        }
        /// <summary>
        /// Variable que obtiene una lista de todos los tipos de TipoLote de la base de datos.
        /// </summary>
        private static List<TipoLote> lstTiposLotes = null;//= TipoTipoLote.Buscar(null, true);

        /// <summary>
        /// Nos devuelve un objeto TipoTipoLote de acuerdo con el argumento especificado.
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static TipoLote TipoLoteSistema(TiposLoteSistema tipo)
        {
            TipoLote rtno = null;
            try
            {
                if (!lstTiposLotes.Exists(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo)))
                    CrearPersistencia(tipo);

                rtno = lstTiposLotes.Single(E => E.Descripcion == EnumConversiones.GetDescripcion(tipo));
            }
            catch (Exception) { }
            return rtno;
        }

        #endregion

        /// <summary>
        /// Recarga las listas que contienen datos de sistema
        /// para ello se vale de la función CargarListaSistema, que llama por cada 
        /// elemento que se encuentre en EnumeracionesSistema, que no es mas que una lista de las enumeraciones
        /// que contienen datos de sistema.
        /// </summary>
        public static void RecargarListasSistema() 
        {
            foreach (Type item in EnumeracionesSistema)
                CargarListaSistema(item);

        }

        /// <summary>
        /// Carga la lista adecuada en función del parámetro
        /// Las listas que carga son listas de elementos del tipo iclasebase, pero que han sido 
        /// marcados como de sistema, pues en funcion de sus valores cambian el flujo de la aplicación.
        /// </summary>
        /// <param name="TipoEnumeracion"></param>
        public static void CargarListaSistema(Type TipoEnumeracion)
        {

            try
            {
                if (TipoEnumeracion == typeof(ProductosSistema))
                    lstProductos = Producto.Buscar(null, null, null, null, null, true);

                if (TipoEnumeracion == typeof(TiposContactosSistema))
                    lstTiposContactos = TipoContacto.Buscar(null, true);

                if (TipoEnumeracion == typeof(NaturalezasGastosSistema))
                    lstNaturalezaGastos = Naturaleza.Buscar(null, true);

                if (TipoEnumeracion == typeof(TiposAltaSistema))
                    lstTiposAltas = TipoAlta.Buscar(null, true);

                if (TipoEnumeracion == typeof(MomentosPesoSistema))
                    lstMomentoPesoSistema = Momento.Buscar();

                if (TipoEnumeracion == typeof(TiposAbortosSistema))
                    lstTiposAbortos = TipoAborto.Buscar(null, true);

                if (TipoEnumeracion == typeof(EspeciesSistema))
                    lstEspeciesSistema = Especie.Buscar();

                if (TipoEnumeracion == typeof(TiposInseminacionSistema))
                    lstTiposInseminacion = TipoInseminacion.Buscar(null, true);

                if (TipoEnumeracion == typeof(TiposProductosSistema))
                    lstTiposProductos = TipoProducto.Buscar(null, null, true);

                if (TipoEnumeracion == typeof(EstadosSistema))
                    lstEstadosSistema = Estado.Buscar(null, true);

                if (TipoEnumeracion == typeof(TiposLoteSistema))
                    lstTiposLotes = TipoLote.Buscar(null, true);

                if (TipoEnumeracion == typeof(FamiliasSistema))
                    lstFamilias = Familia.Buscar(null,null,true);
            }
            catch (Exception ex)
            {
                Traza.RegistrarError(ex);
            }
            

        }

        /// <summary>
        /// Lista de todas las enumeraciones que contienen datos de sistema
        /// es necesario administrar esta lista para poder hacer la carga inicial, recargas etc... 
        /// sin tener que especificar los tipos concretos.
        /// </summary>
        public static List<Type> EnumeracionesSistema
        {
            get
            {
                List<Type> lstEnumeraciones = new List<Type>();
                lstEnumeraciones.Add(typeof(Configuracion.TiposAbortosSistema));
                lstEnumeraciones.Add(typeof(Configuracion.TiposAltaSistema));
                lstEnumeraciones.Add(typeof(Configuracion.TiposContactosSistema));
                lstEnumeraciones.Add(typeof(Configuracion.TiposInseminacionSistema));
                lstEnumeraciones.Add(typeof(Configuracion.TiposProductosSistema));
                lstEnumeraciones.Add(typeof(Configuracion.FamiliasSistema));
                lstEnumeraciones.Add(typeof(Configuracion.NaturalezasGastosSistema));
                lstEnumeraciones.Add(typeof(Configuracion.MomentosPesoSistema));
                lstEnumeraciones.Add(typeof(Configuracion.ProductosSistema));
                lstEnumeraciones.Add(typeof(Configuracion.EspeciesSistema));
                lstEnumeraciones.Add(typeof(Configuracion.EstadosSistema));
                lstEnumeraciones.Add(typeof(Configuracion.TiposLoteSistema));


                return lstEnumeraciones;
            }
        }

        /// <summary>
        /// Crea la persistencia de un valor concreto de sistema (Elemento especifico de alguna de las enumeraciones del sistema)
        /// Para que sea posible crear la persistencia de un elemento de la enumeracíón en la base de datos
        /// debemos especificar en los valores de dicha enumeración, los atributos necesarios para la creación de la persistencia
        /// dichos atributo debe ser del tipo EnumConfig.
        /// </summary>
        /// <param name="value"></param>
        public static void CrearPersistencia(Enum value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            string description = value.ToString();
            FieldInfo fieldInfo = value.GetType().GetField(description);
            EnumConfig[] attributes = (EnumConfig[])fieldInfo.GetCustomAttributes(typeof(EnumConfig), false);

            if (attributes != null && attributes.Length > 0)
            {
                EnumConfig Definicion = attributes[0];
                
                try
                {
                    object claseBase = value.GetType().Assembly.CreateInstance(Definicion.TipoClaseBase.FullName);
                    if (claseBase != null)
                    {

                        try
                        {
                            if (Definicion.Valores != null && Definicion.Valores.Count > 0)
                            {
                                for (int i = 0; i < Definicion.Valores.Count; i++)
                                {
                                    System.Reflection.PropertyInfo Propiedad = claseBase.GetType().GetProperty(Definicion.Valores[i].Key);
                                    object Valor = Definicion.Valores[i].Value;

                                    if (Propiedad != null)
                                    {
                                        if (Valor.GetType() == typeof(TiposProductosSistema))
                                            Valor = TipoProductoSistema((TiposProductosSistema)Valor).Id;

                                        if (Valor.GetType() == typeof(FamiliasSistema))
                                            Valor = FamiliaSistema((FamiliasSistema)Valor).Id;

                                        Propiedad.SetValue(claseBase, Valor, null);
                                    }
                                }

                            }
                        }
                        catch (Exception)
                        {
                            
                            throw;
                        }                  

                     
                        //Antes de insertar compruebo si existe o no BDOperaciones, si no existe la creo y finalizo
                        bool BDOperacionesPropia = !BD.BDOperacionesIniciada();
                        if (BDOperacionesPropia) 
                            BD.IniciarBDOperaciones();
                        try
                        {
                            ((IClaseBase)claseBase).Insertar();
                        }                        
                        finally 
                        {
                            if (BDOperacionesPropia)                             
                                BD.FinalizarBDOperaciones();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Traza.RegistrarError(ex);
                }
            }

            Logic.Configuracion.CargarListaSistema(value.GetType());
            //return description;
        }
        #endregion

        #region VALORES CLAVES

        /// <summary>
        /// Nos indica la cantidad de días que debe no se debe exceder entre la última inseminación y el parto        
        /// </summary>
        public static int MaximoGestacion(int idEspecie)
        {
            int rtno = -1;
            Especie especie = Especie.Buscar(idEspecie);
            if (especie != null)
            {
                try
                {
                    rtno = Convert.ToInt32(Configuracion.Parametros["DiasMaximoGestacion_" + especie.Descripcion]);
                }
                catch (Exception)
                { }
            }
            return rtno;

        }
        /// <summary>
        /// Nos indica la cantidad de días que debe haber entre la última inseminación y el parto    
        /// Este valor es especifico por especie.
        /// </summary>
        public static int MinimoGestacion(int idEspecie)
        {
            int rtno = -1;
            Especie especie = Especie.Buscar(idEspecie);
            if (especie != null)
            {
                try
                {
                    rtno = Convert.ToInt32(Configuracion.Parametros["DiasMinimoGestacion_" + especie.Descripcion]);
                }
                catch (Exception)
                { }
            }
            return rtno;

        }
        /// <summary>
        /// Días establecidos entre un parto y una nueva inseminación.
        /// </summary>
        public static int PeriodoPostParto(int idEspecie)
        {
            int rtno = -1;
            Especie especie = Especie.Buscar(idEspecie);
            if (especie != null)
            {
                try
                {
                    rtno = Convert.ToInt32(Configuracion.Parametros["PeriodoInseminacionPostParto_" + especie.Descripcion]);
                }
                catch (Exception)
                { }
            }
            return rtno;

        }
        ///// <summary>
        ///// Comienzo del intervalo entre celos que debe cumplirse.
        ///// Nos indica que no se podra dar de alta un celo de un animal en los dias aqui establecidos contando a partir
        ///// del último celo.
        ///// Valor de configuración.
        ///// </summary>
        public static int IntervaloCelosInicio(int idEspecie)
        {
            int rtno = -1;
            Especie especie = Especie.Buscar(idEspecie);
            if (especie != null)
            {
                try
                {
                    rtno = Convert.ToInt32(Configuracion.Parametros["IntervaloCelosInicio_" + especie.Descripcion]);
                }
                catch (Exception)
                { }
            }
            return rtno;

        }
        ///// <summary>
        ///// Fin del intervalo entre celos que debe cumplirse.
        ///// Nos indica que no se podra dar de alta un celo de un animal con una fecha superior a la fecha del ultimo celo 
        ///// + los dias aqui establecidos.
        ///// Valor de configuración.
        ///// </summary>
        public static int IntervaloCelosFin(int idEspecie)
        {
            int rtno = -1;
            Especie especie = Especie.Buscar(idEspecie);
            if (especie != null)
            {
                try
                {
                    rtno = Convert.ToInt32(Configuracion.Parametros["IntervaloCelosFin_" + especie.Descripcion]);
                }
                catch (Exception)
                { }
            }
            return rtno;

        }
        /// <summary>
        /// Valor de configuracion de los días del secado normal estimado.
        /// </summary>
        /// <param name="idEspecie"></param>
        /// <returns></returns>
        public static int SecadoNormalEstimado(int idEspecie)
        {
            int rtno = -1;
            Especie especie = Especie.Buscar(idEspecie);
            if (especie != null)
            {
                try
                {
                    rtno = Convert.ToInt32(Configuracion.Parametros["DiasSecadoNormalEstimado_" + especie.Descripcion]);

                }
                catch (Exception)
                { }
            }
            return rtno;

        }
        /// <summary>
        /// Valor de configuracion de los días de secado estimados para un aborto con lactación.
        /// </summary>
        /// <param name="idEspecie"></param>
        /// <returns></returns>
        public static int SecadoAbortoConLactacion(int idEspecie)
        {
            int rtno = -1;
            Especie especie = Especie.Buscar(idEspecie);
            if (especie != null)
            {
                try
                {
                    rtno = Convert.ToInt32(Configuracion.Parametros["DiasSecadoAbortoConLactacion_" + especie.Descripcion]);
                }
                catch (Exception)
                { }

            }
            return rtno;

        }
        /// <summary>
        /// Valor de configuracion de los dias de vacaciones a tener en cuenta para la fecha del secado.
        /// </summary>
        /// <param name="idEspecie"></param>
        /// <returns></returns>
        public static int SecadoDiasVacaciones(int idEspecie)
        {
            int rtno = -1;
            Especie especie = Especie.Buscar(idEspecie);
            if (especie != null)
            {
                try
                {
                    rtno = Convert.ToInt32(Configuracion.Parametros["SecadoDiasVacaciones_" + especie.Descripcion]);
                }
                catch (Exception)
                { }

            }
            return rtno;

        }
        #endregion

        /// <summary>
        /// Propiedad configurada en el xml de configuracion
        /// Nos indica si en las tablas inseminaciones y partos se permiten o no
        /// establecer fechas posteriores a la actual. (Por defecto False)
        /// </summary>
        public static bool PermitirRegistrosFuturos 
        {
            get 
            {
                bool rtno = false;
                try
                {
                    if (ConfigurationManager.AppSettings.Get("PermitirRegistrosFuturos") != null)
                        rtno = bool.Parse(ConfigurationManager.AppSettings.Get("PermitirRegistrosFuturos"));
                }
                catch (Exception) { }
                return rtno;            
            }        
        }

    }
}

namespace GEXVOC.Core.Logic
{
    public partial class Configuracion : IClaseBase
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
            ConfiguracionData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            ConfiguracionData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            ConfiguracionData.Eliminar(this);
        }

        /// <summary>
        /// Sobrecarga que omite la especie, se interpreta que el valor es configurable a nivel de aplicación
        /// independiente de la especie.
        /// Nota: Tendrá un único valor para toda la aplicación.
        /// </summary>
        /// <param name="clave"></param>
        /// <param name="valor"></param>       
        public static void GuardarValor(Claves clave, string valor)
        {
            GuardarValor(clave, valor, null);
        }

        /// <summary>
        /// Guarda un elemento en la tabla de configuración.
        /// Dicho elemento se compone por clave, valor y especie.
        /// Si no existe dicho elemento, este es creado automáticamente.
        /// </summary>
        /// <param name="clave"></param>
        /// <param name="valor"></param>
        /// <param name="idEspecie"></param>
        public static void GuardarValor(Claves clave, string valor, int? idEspecie)
        {
            Configuracion config = null;
            config = ObtenerClave(clave, idEspecie);

            BDController.InicializarBDOperaciones();
            try
            {
                if (config != null)
                {
                    if (config.Valor != valor)
                    {
                        config = (Configuracion)config.CargarContextoOperacion(TipoContexto.Modificacion);
                        config.Valor = valor;
                        config.Actualizar();
                    }
                }
                else//No existe la clave, hay que crearla
                {
                    config = new Configuracion();
                    if (idEspecie != null)
                    {
                        Especie especie = Especie.Buscar((int)idEspecie);
                        config.Clave = clave.ToString() + "_" + especie.Descripcion;
                    }
                    else
                        config.Clave = clave.ToString();

                    config.Valor = valor;
                    config.Insertar();
                }
            }
            catch (Exception ex)
            {
                throw new LogicException(ex.Message);
            }
            finally
            {
                BDController.FinalizarBDOperaciones();
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
                    rtno = new Configuracion();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ConfiguracionData.GetConfiguracionOP(this.Clave);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Configuracion a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Configuracion con el id especificado.</returns>
        public static Configuracion Buscar(string clave)
        {
            return ConfiguracionData.GetConfiguracion(clave);
        }

        /// <summary>
        /// Obtiene los/las Configuracion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Configuracion> Buscar(string clave, string valor)
        {
            return ConfiguracionData.GetConfiguraciones(clave, valor);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Configuracion
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Configuracion> Buscar()
        {
            return ConfiguracionData.GetConfiguraciones(string.Empty, string.Empty);
        }

     

        public static string ObtenerValor(Claves clave, int? idEspecie)
        {
            string rtno = string.Empty;
            Configuracion config = null;

            config = ObtenerClave(clave, idEspecie);

            if (config != null)
            {
                rtno = config.Valor;
            }
            return rtno;
        }
        public static string ObtenerValor(Claves clave)
        {
            return ObtenerValor(clave, null);
        }

        public static Configuracion ObtenerClave(Claves clave, int? idEspecie)
        {
            Configuracion rtno = null;
            if (idEspecie == null)
            {
                rtno = Configuracion.Buscar(clave.ToString());
            }
            else
            {
                Especie especie = Especie.Buscar((int)idEspecie);
                if (especie != null)
                {
                    rtno = Configuracion.Buscar(clave.ToString() + "_" + especie.Descripcion);
                }
            }
            return rtno;
        }
        public static Configuracion ObtenerClave(Claves clave)
        {
            return ObtenerClave(clave, null);
        }


        public static int? ObtenerValorInt(Claves clave, int? idEspecie)
        {
            int? rtno = null;
            try
            {

                if (idEspecie == null)
                    rtno = Convert.ToInt32(ObtenerValor(clave, null));
                else
                    rtno = Convert.ToInt32(ObtenerValor(clave, idEspecie));
            }
            catch (Exception ex)
            { Traza.RegistrarError(ex); }
            return rtno;


        }
        public static int? ObtenerValorInt(Claves clave)
        {
            return ObtenerValorInt(clave, null);
        }

        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

        public int Id
        {
            get { return -1; }
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
        /// </summary>
        /// <param name="operacion">Operación en curso que se debe validar.</param>
        private void ValidarLogica(TipoOperacion operacion)
        {//Añadir código de validación
        }

        #endregion

    }
}