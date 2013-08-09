using System;
using System.IO;
using System.Xml;
using System.Collections.Specialized;
using System.Reflection;

namespace GEXVOC.Core.Logic
{
    [Serializable]
    public class Configurador
    {
        private static NameValueCollection Configuracion;
        private const string Archivo = "gexvoc.xml";
        private const string _BD = "BD";
        private const string _Servidor = "WM5";
        private const string _Activo = "REG";
        private const string _Log = "LOG";

        /// <summary>
        /// Ruta a la base de datos.
        /// </summary>
        public static string BD
        {
            get { return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), Configuracion[_BD]); }
        }

        /// <summary>
        /// Cadena de conexión para la base de datos local.
        /// </summary>
        public static string CSLocal
        {
            get { return string.Format("Data Source = {0};", BD); }
        }

        /// <summary>
        /// Ip del equipo a sincronizar.
        /// </summary>
        public static string Servidor
        {
            get { return Configuracion[_Servidor]; }
        }

        /// <summary>
        /// Cadena de conexión para la base de datos remota.
        /// </summary>
        public static string CSRemota
        {
            get { return string.Format(@"Data Source = {0},1433; Initial Catalog = gexvoc; User Id = gexvoc; Password = gexvoc", Servidor); }
        }

        /// <summary>
        /// Obtiene el estado de activación de log.
        /// </summary>
        public static bool LogActivo
        {
            get { return Convert.ToBoolean(Configuracion[_Activo]); }
        }

        /// <summary>
        /// Ruta al archivo de log.
        /// </summary>
        public static string Log
        {
            get { return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), Configuracion[_Log]); }
        }

        /// <summary>
        /// Realiza la carga de la aplicación.
        /// </summary>
        public static void Cargar()
        {
            try
            {
                string creartablas = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), "creartablas.txt");
                            
                if(!File.Exists(creartablas))
                    CrearTablas(creartablas);

                string ConfigFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), Archivo);

                if (!File.Exists(ConfigFile))
                    Crear(ConfigFile);

                XmlDocument oXml = new XmlDocument();

                oXml.Load(ConfigFile);

                XmlNodeList oList = oXml.GetElementsByTagName("appSettings");

                Configuracion = new NameValueCollection();

                foreach (XmlNode oNode in oList)
                    foreach (XmlNode oKey in oNode.ChildNodes)
                        Configuracion.Add(oKey.Attributes["key"].Value, oKey.Attributes["value"].Value);
            }
            catch (Exception E)
            {
                throw Traza.Registrar(E);
            }
        }

        /// <summary>
        /// Crea el archivo de configuración por defecto.
        /// </summary>
        /// <param name="ruta">Archivo a crear.</param>
        private static void Crear(string ruta)
        {
            using (XmlWriter Escritor = XmlWriter.Create(ruta, new XmlWriterSettings { Indent = true, IndentChars = ("    ") }))
            {
                Escritor.WriteStartElement("configuration");
                    Escritor.WriteStartElement("appSettings");
                        Escritor.WriteStartElement("add");
                            Escritor.WriteAttributeString("key", _BD);
                            Escritor.WriteAttributeString("value", "gexvocce.sdf");
                        Escritor.WriteEndElement();

                        Escritor.WriteStartElement("add");
                            Escritor.WriteAttributeString("key", _Servidor);
                            Escritor.WriteAttributeString("value", "169.254.2.2");
                        Escritor.WriteEndElement();

                        Escritor.WriteStartElement("add");
                            Escritor.WriteAttributeString("key", _Activo);
                            Escritor.WriteAttributeString("value", "true");
                        Escritor.WriteEndElement();

                        Escritor.WriteStartElement("add");
                            Escritor.WriteAttributeString("key", _Log);
                            Escritor.WriteAttributeString("value", "gexvoclog.log");
                        Escritor.WriteEndElement();
                    Escritor.WriteEndElement();
                Escritor.WriteEndElement();

                Escritor.Flush();
            }
        }
        
        private static void CrearTablas(string rutatxt)
        {
            string fic = rutatxt; 
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fic);
            #region hacer txt crea tablas
            sw.WriteLine("CREATE TABLE [Especie](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_Especie] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [CondicionJuridica](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](50) NOT NULL,CONSTRAINT [PK_CondicionJuridica] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Provincia](	[Id] [int]  NOT NULL,	[Codigo] [nvarchar](2) NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_Provincia] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Talla](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_Talla] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Estado](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_Estado] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Conformacion](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_Conformacion] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Configuracion](	[Clave] [nvarchar](50) NOT NULL,	[Valor] [nvarchar](255) NOT NULL,CONSTRAINT [PK_Configuracion] PRIMARY KEY([Clave]))");
            sw.WriteLine("CREATE TABLE [TipoDiagnostico](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[Sistema] [bit] NULL,CONSTRAINT [PK_TipoDiagnostico] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [TipoInseminacion](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[Sistema] [bit] NULL,CONSTRAINT [PK_TipoInseminacion] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [TipoParto](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[Crias] [int] NULL,	[Sistema] [bit] NULL,CONSTRAINT [PK_TipoParto] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [TipoEnfermedad](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_TipoEnfermedad] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [TipoAlta](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[Sistema] [bit] NULL,CONSTRAINT [PK_TipoAlta] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [TipoBaja](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[Sistema] [bit] NULL,CONSTRAINT [PK_TipoBaja] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Facilidad](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[Sistema] [bit] NULL,CONSTRAINT [PK_Facilidad] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [TipoAborto](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[Sistema] [bit] NULL,CONSTRAINT [PK_TipoAborto] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Momento](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_Momento] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Veterinario](	[Id] [int]  NOT NULL,	[IdTipo] [int] NOT NULL,	[Nombre] [nvarchar](50) NOT NULL,	[Apellidos] [nvarchar](100) NOT NULL,	[DNI] [nvarchar](9) NULL,	[Direccion] [nvarchar](100) NULL,	[CP] [nvarchar](5) NULL,	[Telefono] [nvarchar](9) NULL,	[Movil] [nvarchar](9) NULL,	[Email] [nvarchar](255) NULL,	[FechaNacimiento] [datetime] NULL,CONSTRAINT [PK_Veterinario] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [StatusOrdeno](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_StatusOrdeno] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [StatusControl](	[Id] [int]  NOT NULL,	[Codigo] [nvarchar](2) NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_StatusControl] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [TipoSecado](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[Sistema] [bit] NULL,CONSTRAINT [PK_TipoSecado] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Motivo](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_Motivo] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [TipoProducto](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[Familia] [bit] NULL,	[Sistema] [bit] NULL,CONSTRAINT [PK_TipoProducto] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Naturaleza](	[Id] [int]  NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[Sistema] [bit] NULL,CONSTRAINT [PK_Naturaleza] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Explotacion](	[Id] [int]  NOT NULL,	[IdCJuridica] [int] NOT NULL,	[IdMunicipio] [int] NOT NULL,	[CEA] [nvarchar](14) NOT NULL,	[Siglas] [nvarchar](3) NULL,	[Nombre] [nvarchar](50) NOT NULL,	[Direccion] [nvarchar](100) NULL,	[FechaAlta] [datetime] NOT NULL,	[FechaBaja] [datetime] NULL,CONSTRAINT [PK_Explotacion] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Municipio](	[Id] [int]  NOT NULL,	[IdProvincia] [int] NOT NULL,	[Codigo] [nvarchar](3) NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_Municipio] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [ExpEsp](	[IdExplotacion] [int] NOT NULL,	[IdEspecie] [int] NOT NULL,CONSTRAINT [PK_ExpEsp] PRIMARY KEY([IdExplotacion], [IdEspecie]))");
            sw.WriteLine("CREATE TABLE [LoteAnimal](	[Id] [int]  NOT NULL,	[IdExplotacion] [int] NOT NULL,	[IdParidera] [int] NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[Paridera] [bit] NULL,	[FechaAlta] [datetime] NOT NULL,	[FechaBaja] [datetime] NULL,CONSTRAINT [PK_LoteAnimal] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Animal](	[Id] [int]  NOT NULL,	[IdRaza] [int] NOT NULL,	[IdEstado] [int] NULL,	[IdTalla] [int] NULL,	[IdConformacion] [int] NULL,	[IdExplotacion] [int] NOT NULL,	[DIB] [nvarchar](14) NULL,	[Crotal] [nvarchar](4) NULL,	[Tatuaje] [nvarchar](7) NULL,	[Genotipo] [nvarchar](7) NULL,	[Nombre] [nvarchar](50) NOT NULL,	[FechaNacimiento] [datetime] NOT NULL,	[FechaDestete] [datetime] NULL,	[Sexo] [nvarchar](1) NOT NULL,	[Morfologia] [int] NULL,	[Testaje] [bit] NULL,	[AptoNovillas] [bit] NULL,	[Imagen] [nvarchar](255) NULL,	[Externo] [bit] NULL,	[Identificado] [bit] NULL,CONSTRAINT [PK_Animal] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [AniLot](	[IdLote] [int] NOT NULL,	[IdAnimal] [int] NOT NULL,	[FechaInicio] [datetime] NOT NULL,	[FechaFin] [datetime] NULL,CONSTRAINT [PK_AniLot] PRIMARY KEY([IdLote], [IdAnimal]))");
            sw.WriteLine("CREATE TABLE [Raza](	[Id] [int]  NOT NULL,	[IdEspecie] [int] NOT NULL,	[Descripcion] [nvarchar](50) NOT NULL,CONSTRAINT [PK_Raza] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [TipoCondicion](	[Id] [int]  NOT NULL,	[IdEspecie] [int] NOT NULL,	[Codigo] [nvarchar](3) NOT NULL,	[Descripcion] [nvarchar](50) NOT NULL,	[Detalle] [ntext] NOT NULL,	[Apta] [bit] NOT NULL,CONSTRAINT [PK_TipoCondicion] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [CondicionCorporal](	[Id] [int]  NOT NULL,	[IdTipo] [int] NOT NULL,	[IdHembra] [int] NOT NULL,	[Fecha] [datetime] NOT NULL,CONSTRAINT [PK_CondicionCorporal] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Inseminacion](	[Id] [int]  NOT NULL,	[IdMacho] [int] NOT NULL,	[IdHembra] [int] NOT NULL,	[IdTipo] [int] NOT NULL,	[IdVeterinario] [int] NOT NULL,	[IdEmbrion] [int] NULL,[Dosis] [int] NULL,	[Fecha] [datetime] NOT NULL,	[Modificable] [bit] NOT NULL,CONSTRAINT [PK_Inseminacion] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [DiagInseminacion](	[Id] [int]  NOT NULL,	[IdTipo] [int] NOT NULL,	[IdInseminacion] [int] NOT NULL,	[Fecha] [datetime] NOT NULL,	[Resultado] [bit] NOT NULL,	[DiasGestacion] [int] NULL,	[Modificable] [bit] NOT NULL,CONSTRAINT [PK_DiagInseminacion] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Cubricion](	[Id] [int]  NOT NULL,	[IdTipo] [int] NOT NULL,	[IdLote] [int] NOT NULL,	[FechaInicio] [datetime] NOT NULL,	[FechaFin] [datetime] NULL,CONSTRAINT [PK_Cubricion] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Alta](	[Id] [int]  NOT NULL,	[IdTipo] [int] NOT NULL,	[IdAnimal] [int] NOT NULL,	[Detalle] [nvarchar](150) NULL,	[Fecha] [datetime] NOT NULL,CONSTRAINT [PK_Alta] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Baja](	[Id] [int]  NOT NULL,	[IdTipo] [int] NOT NULL,	[IdAnimal] [int] NOT NULL,	[Detalle] [nvarchar](150) NULL,	[Fecha] [datetime] NOT NULL,CONSTRAINT [PK_Baja] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Parto](	[Id] [int]  NOT NULL,	[IdHembra] [int] NOT NULL,	[IdTipo] [int] NOT NULL,	[IdFacilidad] [int] NOT NULL,	[Vivos] [int] NULL,	[Muertos] [int] NULL,	[Fecha] [datetime] NOT NULL,	[Modificable] [bit] NOT NULL,CONSTRAINT [PK_Parto] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Enfermedad](	[Id] [int]  NOT NULL,	[IdTipo] [int] NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_Enfermedad] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [DiagAnimal](	[Id] [int]  NOT NULL,	[IdAnimal] [int] NOT NULL,	[IdEnfermedad] [int] NULL,	[IdVeterinario] [int] NULL,	[Diagnostico] [nvarchar](2000) NULL,	[Fecha] [datetime] NOT NULL, [Modificable] [bit] NOT NULL, CONSTRAINT [PK_DiagAnimal] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Lactacion](	[Id] [int]  NOT NULL,	[IdHembra] [int] NOT NULL,	[FechaInicio] [datetime] NOT NULL,	[FechaFin] [datetime] NULL,	[Modificable] [bit] NOT NULL,CONSTRAINT [PK_Lactacion] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Aborto](	[Id] [int]  NOT NULL,	[IdHembra] [int] NOT NULL,	[IdTipo] [int] NOT NULL,	[Fecha] [datetime] NOT NULL,CONSTRAINT [PK_Aborto] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [TratEnfermedad](	[Id] [int]  NOT NULL,	[IdDiagnostico] [int] NOT NULL,	[IdVeterinario] [int] NOT NULL,	[Detalle] [nvarchar](150) NULL,[Duracion] [int] NOT NULL,	[SupresionLeche] [numeric](5, 2) NULL,	[SupresionCarne] [numeric](5, 2) NULL,	[Fecha] [datetime] NOT NULL,CONSTRAINT [PK_TratEnfermedad] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Peso](	[Id] [int]  NOT NULL,	[IdMomento] [int] NULL,	[IdAnimal] [int] NOT NULL,	[Peso] [numeric](6, 2) NOT NULL,	[Fecha] [datetime] NOT NULL,	[Modificable] [bit] NOT NULL,CONSTRAINT [PK_Peso] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Control](	[Id] [int]  NOT NULL,	[IdLactacion] [int] NOT NULL,	[IdControl] [int] NOT NULL,	[IdOrdeno] [int] NULL,	[Fecha] [datetime] NOT NULL,	[LecheManana] [numeric](6, 2) NULL,	[LecheTarde] [numeric](6, 2) NULL,	[LecheNoche] [numeric](6, 2) NULL,	[Modificable] [bit] NOT NULL,CONSTRAINT [PK_Control] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Secado](	[Id] [int]  NOT NULL,	[IdTipo] [int] NULL,	[IdMotivo] [int] NULL,	[IdHembra] [int] NOT NULL,	[Fecha] [datetime] NOT NULL,	[Modificable] [bit] NOT NULL,CONSTRAINT [PK_Secado] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Producto](	[Id] [int]  NOT NULL,	[IdTipo] [int] NOT NULL,	[IdFamilia] [int] NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[SupresionLeche] [numeric](5, 2) NULL,	[SupresionCarne] [numeric](5, 2) NULL,	[Sistema] [bit] NULL,CONSTRAINT [PK_Producto] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Familia](	[Id] [int]  NOT NULL,	[IdTipo] [int] NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,	[Sistema] [bit] NULL,CONSTRAINT [PK_Familia] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Receta](	[Id] [int]  NOT NULL,	[IdTratamiento] [int] NOT NULL,	[IdMedicamento] [int] NOT NULL,	[Dosis] [nvarchar](150) NULL,	[Duracion] [int] NOT NULL,	[Importe] [numeric](10, 2) NOT NULL,	[Fecha] [datetime] NOT NULL,CONSTRAINT [PK_Receta] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Movimiento](	[Id] [int]  NOT NULL,	[IdExplotacion] [int] NOT NULL,	[IdProducto] [int] NOT NULL,	[IdMacho] [int] NULL,	[Origen] [nvarchar](20) NULL,	[Identificacion] [nvarchar](20) NULL,	[Fecha] [datetime] NOT NULL,	[FechaEfecto] [datetime] NULL,	[Cantidad] [numeric](6, 2) NOT NULL,	[Precio] [numeric](6, 2) NULL,CONSTRAINT [PK_Movimiento] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Stock](	[Id] [int]  NOT NULL,	[IdExplotacion] [int] NOT NULL,	[IdProducto] [int] NOT NULL,	[IdMacho] [int] NULL,	[Cantidad] [numeric](6, 2) NOT NULL,	[Precio] [numeric](6, 2) NOT NULL,CONSTRAINT [PK_Stock] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Gasto](	[Id] [int]  NOT NULL,	[IdExplotacion] [int] NOT NULL,	[IdNaturaleza] [int] NOT NULL,	[IdAnimal] [int] NULL,	[IdInseminacion] [int] NULL,	[IdTratamiento] [int] NULL,	[IdReceta] [int] NULL,	[IdParcela] [int] NULL,	[IdAsignacion] [int] NULL,	[IdSiembra] [int] NULL,	[IdAbonado] [int] NULL,	[IdTratParcela] [int] NULL,	[IdTratHigiene] [int] NULL,	[IdTratProfilaxis] [int] NULL,	[IdProducto] [int] NULL,	[Detalle] [nvarchar](255) NULL,	[Fecha] [datetime] NOT NULL,	[Importe] [numeric](10, 2) NOT NULL,	[Total] [numeric](10, 2) NOT NULL,CONSTRAINT [PK_Gasto] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [TipoPersonal](	[Id] [int] NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_TipoPersonal] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [TipoCubricion](	[Id] [int] NOT NULL,	[Descripcion] [nvarchar](100) NOT NULL,CONSTRAINT [PK_TipoCubricion] PRIMARY KEY([Id]))");
            sw.WriteLine("CREATE TABLE [Estancia](	[IdCubricion] [int] NOT NULL,	[IdMacho] [int] NOT NULL,	[FechaInicio] [datetime] NOT NULL,	[FechaFin] [datetime] NULL,CONSTRAINT [PK_Estancia] PRIMARY KEY ([IdCubricion], [IdMacho], [FechaInicio]))");
            #endregion
            sw.Close();
            
        }
    }
}
