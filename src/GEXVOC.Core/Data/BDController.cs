using System;
using System.Configuration;
using System.Linq;
using GEXVOC.Core.Logic;
using System.Data.Linq;
using System.Data.SqlClient;

namespace GEXVOC.Core.Data
{
    public static class BDController
    {
        /// <summary>
        /// Constructor sin parámetros, que inicia la variable _BD con un nuevo contexto.
        /// </summary>
        static BDController()
        {
            _BD = new GEXVOCDataContext(ConectionStringGEXVOC());
        }

        /// <summary>
        /// Nos indica el texto que representa el nombre de la instancia el archivo de configuración.
        /// Es un texto comodín que será reemplazado cada vez que se utilice el valor del conectionstring de configuración.
        /// Representa el DataSource.
        /// </summary>
        const string _NOMBRE_INSTANCIA_ = "$$INSTANCIA_SERVIDOR$$";
        const string _BASEDATOS_="$$BASE_DATOS$$";

        ////******************
        ////  Version Inicial
        ////******************
        private static GEXVOCDataContext _BD;

        /// <summary>
        /// Nos indica si en el Contexto BDOperaciones ha sido iniciada una trasacción
        /// </summary>
        public static bool TransaccionActiva
        {
            get
            {
                Boolean rtno = false;

                if (BDOperaciones != null)
                {
                    if (BDOperaciones.Transaction != null)
                        rtno = true;

                }


                return rtno;

            }
        }
        public static GEXVOCDataContext BD
        {
            get { return _BD; }
        }
      
        /// <summary>
        /// Reinicia el contexto en la variable _BD
        /// </summary>
        public static void Recargar()
        {
            _BD = new GEXVOCDataContext(ConectionStringGEXVOC());
        }

        public static void CerrarConexion()
        {
            _BD.Dispose();
            _BD = null;
        }
        
        /// <summary>
        /// Inicia una transacción en el contexto BDOperaciones.
        /// </summary>
        /// <returns></returns>
        public static Boolean IniciarTransaccion()
        {
            Boolean rtno = false;


            if (_BDOperaciones.Connection.State == System.Data.ConnectionState.Closed)
                _BDOperaciones.Connection.Open();

            if (!TransaccionActiva)
            {
                _BDOperaciones.Transaction = BDOperaciones.Connection.BeginTransaction();
                rtno = true;
            }

            return rtno;


        }

        /// <summary>
        /// Finaliza una trasacción previa en el contexto BDOperaciones
        /// </summary>
        /// <param name="operacionCorrecta"></param>
        public static void FinalizarTransaccion(bool operacionCorrecta)
        {
            if (TransaccionActiva)
            {
                if (operacionCorrecta)
                    _BDOperaciones.Transaction.Commit();
                else
                    _BDOperaciones.Transaction.Rollback();

                _BDOperaciones.Transaction = null;

                if (_BDOperaciones.Connection.State == System.Data.ConnectionState.Open)
                    _BDOperaciones.Connection.Close();
            }
        }


        private static GEXVOCDataContext _BDOperaciones=null;

        public static GEXVOCDataContext BDOperaciones
        {
            get { return _BDOperaciones; }
            set { _BDOperaciones = value; }
        }

        public static void InicializarBDOperaciones()
        {
            ///Tenemos un problema con las alertas, pues mantienen mucho tiempo bd operaciones ocupada
            ///a si que si la tenemos ocupada paramos el thread y comprobamos si sigue ocupada
            ///esta comprobación la haremos como mucho durante 15 segundos, despues si sigue ocupada BD operaciones, lanzamos una 
            ///extepción diciendo que intente la operación más tarde.
            
            if (_BDOperaciones != null) 
            {
                int cont = 0;
                while (cont < 30 && _BDOperaciones != null)
                {
                    cont++;
                    System.Threading.Thread.Sleep(500);
                }
                
                if (cont == 30 && _BDOperaciones!=null)//Comprobamos si ha salido del bucle por el tiempo o porque se ha liberado BDOperaciones.               
                    throw new LogicException("Existe alguna Operación en ejecución, pruebe a realizar su operación más tarde.");///En este caso el tiempo se ha agotado
    
            }   
            
            _BDOperaciones = new GEXVOCDataContext(ConectionStringGEXVOC());

        }
        public static void FinalizarBDOperaciones()
        {          
            _BDOperaciones = null;
        }
        public static void FinalizarBDOperaciones(bool ejecutarSubmit)
        {
            if (ejecutarSubmit)
                _BDOperaciones.SubmitChanges();

            FinalizarBDOperaciones();            
        }

        /// <summary>
        /// Nos indica si el contexto BDOperaciones se encuentra Iniciado o no.
        /// </summary>
        /// <returns></returns>
        public static bool BDOperacionesIniciada()
        {
            return _BDOperaciones != null;            
        }


           
        /// <summary>
        /// Retorna un nuevo objeto del tipo GEXVOCDataContext
        /// Para ello lo crea utilizando las credenciales de ConectionStringGEXVOC
        /// </summary>
        public static GEXVOCDataContext NuevoContexto
        {
            get{

                GEXVOCDataContext bd;
                if (!TransaccionActiva)
                    bd = new GEXVOCDataContext(ConectionStringGEXVOC());
                else
                    bd = _BDOperaciones;
                return bd;
                ;
            
            }
        }


        /// <summary>
        /// Realiza una conexion a la base de datos retornada por ConectionStringGEXVOC
        /// - Retorna True si la conexion ha sido establecida
        /// - Retorna False si la conexión no ha sido establecida o causó algun error.
        /// </summary>
        /// <returns></returns>
        public static bool ExisteBD()         
        {
            return ExisteBD(ConectionStringGEXVOC());
        }

        /// <summary>
        /// Realiza una conexion a la base de datos que se corresponde con el conection string de la aplicación,
        /// pero cambiando su origen de datos por el que se envía como parámetro.
        /// Nos vale para detectar si la información proporcionada es válida para realizar una conexión o no.
        /// </summary>
        /// <param name="InstanciaServidor"></param>
        /// <returns></returns>
        public static bool ExisteBD(string conectionString)
        {
            bool rtno = false;      

            //Hago una conexión al servidor de slq
            SqlConnection conn = new SqlConnection(conectionString + ";connection timeout=8");       
            try
            {
                conn.Open();
                conn.Close();
                rtno = true;
            }
            catch (SqlException) { }
            finally { conn.Dispose(); }

            return rtno;
        }


        /// <summary>
        /// Retorna la conection string debidamente formada para ser utilizada en la aplicación
        /// Para ello se vale de los las claves del registro:
        ///     [HKEY_LOCAL_MACHINE\SOFTWARE\Coremain\Gexvoc] {InstanciaServidor} (Ruta de la instancia del servidor sql)
        ///     [HKEY_LOCAL_MACHINE\SOFTWARE\Coremain\Gexvoc] {TipoInstalacion}    (Puede valer 'servidor' o 'cliente'), en caso de ser servidor se omite el valor la clave {InstanciaServidor} sustituyéndolo por: '(local)\SQLEXPRESS'
        /// </summary>
        public static string ConectionStringGEXVOC()
        {
            return ConectionStringGEXVOC(null,null);
        }

        /// <summary>
        /// Nos retorna el Conection String pero parametrizable, podemos definir con los parámetros lo siguiente:
        ///  - Data Source: Mediante nombreInstancia
        ///  - Initial Catalog: Mediante baseDatos        
        /// </summary>
        /// <param name="nombreInstancia"></param>
        /// <param name="baseDatos"></param>
        /// <returns></returns>
        public static string ConectionStringGEXVOC(string nombreInstancia,string baseDatos)
        {
           
                string rtno = ConfigurationManager.ConnectionStrings["gexvocConnectionString"].ConnectionString;

                if (string.IsNullOrEmpty(nombreInstancia))
                {
                    if (Registro.Registro.GetSetting("TipoInstalacion", "servidor") == "servidor")
                        rtno = rtno.Replace(_NOMBRE_INSTANCIA_, "(local)\\SQLEXPRESS");
                    else
                        rtno = rtno.Replace(_NOMBRE_INSTANCIA_, Registro.Registro.GetSetting("InstanciaServidor") ?? string.Empty);                    
                }
                else
                    rtno=rtno.Replace(_NOMBRE_INSTANCIA_, nombreInstancia);

                if (string.IsNullOrEmpty(baseDatos))                
                    rtno = rtno.Replace(_BASEDATOS_, "gexvoc");
                else
                    rtno = rtno.Replace(_BASEDATOS_, baseDatos);
                
                return rtno;           
        }
     
     


      
    }
}
