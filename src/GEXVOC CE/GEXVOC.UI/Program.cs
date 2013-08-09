using System;
using System.Reflection;
using System.Windows.Forms;

using GEXVOC.Core.Logic;
using System.Text.RegularExpressions;
using System.Data;
using GEXVOC.Core.Data;

namespace GEXVOC.UI
{
    static class Program
    {
        /// <summary>
        /// Versión de la aplicación.
        /// </summary>
        /// 
        public static string queSeleccion = "Hembras";
        public static string ordenamientoparagrids = "";
        public static string crovaca="";
        public static string Nombre = "";
        public static string NombreVaca = "";
        public static string NombreEmbrion = "";
        public static Int32 IdExplotacion=0;
        public static Int32 IdLote = 0;
        public static string dedonde = "";
        public static Int32 IdLoteCubricion = 0;
        public static string estado;        
        public static Int32 IdDiagnosticoInsertaTratamiento;
        public static Int32 IdEnfermedad;
        public static Int32 IdAnimal;
        public static Int32 IdAnimalBuscaTrat;
        public static Int32 IdAnimalInsertarLeches;
        public static Int32 IdAnimalInsertaSecado;
        public static Int32 Embrion;
        public static Int32 IdhembraParaDiagnostico;
        public static Int32 IdHembraParaBuscarPartos;
        public static Int32 IdHembrarParaInsertarPartos;
        public static string NombreVacaPartos = "";
        public static string NombreVacaCondicionesCorporales="";
        public static string NombreVacaInsertarCondicionesCorporales = "";
        public static string NombreAnimalBuscaPesos = "";
        public static string NombreAnimalBuscaDiagnosticos = "";
        public static string NombreAnimalInsertarDiagnosticos = "";
        public static string NombreAnimalinsertarPesos = "";
        public static Int32 IdAnimalInsertarPeso;
        //public static Int32 IdAnimalBuscaTrat;
        public static Int32 IdAnimalInsertarDiagnosticos;
        public static Int32 IdAimalBuscaDiagnosticos;
        public static Int32 IdAimalBuscaPesos;
        public static Int32 IdHembraInsertarCondicionesCorporales;
        public static Int32 IdHembraBuscaCondicionesCorporales;
        public static string Version            
        {
            get
            {
                return " v" + Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() +
                    "." + Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() +
                    "." + Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();
            }
        }

        /// <summary>
        /// Muestra el reloj de proceso.
        /// </summary>
        public static void Procesar()
        {
            Procesar(true);
        }

        /// <summary>
        /// Muestra u oculta el reloj de proceso.
        /// </summary>
        /// <param name="mostrar">Especifica si se muestra u oculta el reloj de proceso.</param>
        public static void Procesar(bool mostrar)
        {
            if (mostrar)
            {
                Cursor.Current = Cursors.WaitCursor;
                Cursor.Show();
            }
            else
            {
                Cursor.Current = Cursors.Default;
                Cursor.Hide();
            }
        }

        /// <summary>
        /// Pregunta al usuario sobre una determinada acción.
        /// </summary>
        /// <param name="texto">Texto.</param>
        /// <returns>Respuesta del usuario.</returns>
        public static DialogResult Preguntar(string texto)
        {
            return MessageBox.Show(texto, "Confirmación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Informa al usuario sobre una determinada acción.
        /// </summary>
        /// <param name="texto">Texto.</param>
        public static void Informar(string texto)
        {
            MessageBox.Show(texto, "Información:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Alerta al usuario sobre un error del sistema.
        /// </summary>
        /// <param name="texto">Texto.</param>
        public static void Alertar(string texto)
        {
            MessageBox.Show(texto + "\rSe ha generado un registro de error.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }
        public static bool EsVarCharCorrecto(string validar)
        {
            if (validar != "")
            {
                return char.IsLetterOrDigit(validar, validar.Length - 1);
            }
            else
            {
                return false;
            }
        }
        public static void MostrarCursorEspera()
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Show();
        }
        public static void OcultarCursorEspera()
        {
            Cursor.Current = Cursors.Default;
            Cursor.Hide();
        }
        public static int ConvertirBoolean(bool bBoolean)
        {
            int iRes;
            if (bBoolean)
                iRes = 1;
            else
                iRes = 0;
            return iRes;
        }
        public static string ConvertirString(object ObjectsString)
        {
            string sString;
            if (ObjectsString != DBNull.Value)
            {
                sString = ObjectsString.ToString().Replace((char)(39), (char)(96));
                sString = "'" + sString + "'";
            }
            else
                sString = "null";

            return sString;
        }
        public static string ConvertirFecha(object dDate)
        {
            string sString;
            if (dDate != DBNull.Value)
                sString = "'" + ((DateTime)dDate).Date.ToShortDateString() + "'";
            else
                sString = "null";
            return sString;
        }
        public static string ConvertirObjectInteger(object ObjectInt)
        {
            string sString;
            if (ObjectInt != DBNull.Value)
                sString = ObjectInt.ToString();
            else
                sString = "null";

            if (sString == "0")
                sString = "null";
            return sString;
        }
        public static string ConvertirObjectDecimal(object ObjectDec)
        {
            string sString;
            if (ObjectDec != DBNull.Value)
            {
                sString = ObjectDec.ToString();
                sString = sString.Replace(",", ".");
            }
            else
                sString = "null";
            return sString;
        }
        public static bool EsVacio(string cadena)
        {
            return cadena == String.Empty;
        }

        public static bool EsEntero(string numero)
        {
            Regex objNotIntPattern = new Regex("[^0-9-]");
            Regex objIntPattern = new Regex("^-[0-9]+$|^[0-9]+$");

            return !objNotIntPattern.IsMatch(numero) && objIntPattern.IsMatch(numero);
        }
        public static bool EsDecimal(string numerodecimal)
        {
            Regex objEsDecima = new Regex("^-[0-9.,]+$|^[0-9.,]+$");
            return objEsDecima.IsMatch(numerodecimal);
        }



        public static DateTime? CalcularFechaUltimoPartoAborot(int IdHembra)
        {
            DateTime? fechaultimoparto;
            DateTime? fechaultimoaborto;
            DataTable Dtfechasultimoparto = PartosTA.ObtenerFechaUltimoParto(IdHembra);
            DataTable Dtfechasultimoaborto = AbortosTA.ObtenerUltimoAborto(IdHembra);
            if (Dtfechasultimoaborto.Rows.Count > 0)
                fechaultimoaborto = Convert.ToDateTime(Dtfechasultimoaborto.Rows[0]["Fecha"].ToString());
            else
                fechaultimoaborto = null;
            if (Dtfechasultimoparto.Rows.Count > 0)
                fechaultimoparto = Convert.ToDateTime(Dtfechasultimoparto.Rows[0]["Fecha"].ToString());
            else
                fechaultimoparto = null;


            if (fechaultimoaborto != null && fechaultimoparto != null)
            {
                if (fechaultimoparto > fechaultimoaborto)
                    return fechaultimoparto;
                else if (fechaultimoaborto > fechaultimoparto)
                    return fechaultimoaborto;
            }
            else if (fechaultimoaborto != null && fechaultimoparto == null)
                return fechaultimoaborto;
            else if (fechaultimoaborto == null && fechaultimoparto != null)
                return fechaultimoparto;

            return null;

        }
        public static DateTime? CalcularFechaUltimoParto(int IdHembra)
        {
            DateTime? fechaultimoparto;
           // DateTime? fechaultimoaborto;
            DataTable Dtfechasultimoparto = PartosTA.ObtenerFechaUltimoParto(IdHembra);
            DataTable Dtfechasultimoaborto = AbortosTA.ObtenerUltimoAborto(IdHembra);
           
            if (Dtfechasultimoparto.Rows.Count > 0)
                fechaultimoparto = Convert.ToDateTime(Dtfechasultimoparto.Rows[0]["Fecha"].ToString());
            else
                fechaultimoparto = null;


          

            return fechaultimoparto;

        }
        public static DateTime? CalcularFechaUltimoPartoAbortoConLactacion(int IdHembra)
        {
            DateTime? fechaultimoparto;
            DateTime? fechaultimoaborto;
            DataTable Dtfechasultimoparto = PartosTA.ObtenerFechaUltimoParto(IdHembra);
            DataTable Dtfechasultimoaborto = AbortosTA.ObtenerUltimoAborto(IdHembra);
            if (Dtfechasultimoaborto.Rows.Count > 0)
                fechaultimoaborto = Convert.ToDateTime(Dtfechasultimoaborto.Rows[0]["Fecha"].ToString());
            else
                fechaultimoaborto = null;
            if (Dtfechasultimoparto.Rows.Count > 0)
                fechaultimoparto = Convert.ToDateTime(Dtfechasultimoparto.Rows[0]["Fecha"].ToString());
            else
                fechaultimoparto = null;


            if (fechaultimoaborto != null && fechaultimoparto != null)
            {
                if (fechaultimoparto > fechaultimoaborto)
                    return fechaultimoparto;
                else if (fechaultimoaborto > fechaultimoparto)
                    return fechaultimoaborto;
            }
            else if (fechaultimoaborto != null && fechaultimoparto == null)
                return fechaultimoaborto;
            else if (fechaultimoaborto == null && fechaultimoparto != null)
                return fechaultimoparto;

            return null;

        }

     

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            try
            {
                Procesar();

                Configurador.Cargar();

                Intro Splash = (Intro)FormFactory.Obtener(Formulario.Intro);
                Splash.Show();
                Splash.Iniciar((int)Formulario.Sincronizar + 1);
                Application.DoEvents();
                
               
                Splash.Cargar(FormFactory.Crear(Formulario.Principal).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.Animal).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.BorrarAnimal).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.CondicionCorporal).Name);
               // //Splash.Cargar(FormFactory.Crear(Formulario.Controles).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.DiagnosticoGestacion).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.Diagnosticos).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.Enfermedades).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.Explotaciones).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.Inseminaciones).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.InsertarAnimal).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.InsertarCondicionCorporal).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.InsertarDiagnosticoEnfermedad).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.InsertarDiagnosticoGestacion).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.InsertarInseminacion).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.InsertarParto).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.InsertarPeso).Name);
               //// Splash.Cargar(FormFactory.Crear(Formulario.Leches).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.Partos).Name);
               // //Splash.Cargar(FormFactory.Crear(Formulario.PartosMultiples).Name);
               // Splash.Cargar(FormFactory.Crear(Formulario.Pesos).Name);
               //// Splash.Cargar(FormFactory.Crear(Formulario.Tratamientos).Name);
                // Pendiente la carga del resto de formularios.

                Procesar(false);

                Application.Run((Principal)FormFactory.Obtener(Formulario.Principal));
            }
            catch (Exception E)
            {
                Traza.Registrar(E);
                Program.Alertar("La aplicación ha realizado una operación no válida.");
            }
        }
    }
}
