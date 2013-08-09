using System;
using System.Collections;
using System.Windows.Forms;

namespace GEXVOC.UI
{
    public enum Formulario
    {
        Intro,
        Principal,
        Animal,
        InsertarAnimal,
        BorrarAnimal,
        Inseminaciones,
        InsertarInseminacion,
        DiagnosticoGestacion,
        Explotaciones,
        InsertarDiagnosticoGestacion,
        Partos,
        InsertarParto,
        CondicionCorporal,
        InsertarCondicionCorporal,
        PartosMultiples,
        InsertarPartosMultiples,
        Pesos,
        InsertarPeso,
        Diagnosticos,
        InsertarDiagnosticoEnfermedad,
        InsertarTratamientoEnfermedad,
        Enfermedades,
        Tratamientos,
        InsertarRegistroLeches,
        InsertarSecados,
        SeleccionarLotes,
        Cubriciones,
        InsertarCubricion,
        Controles,       ////////////
        Vacas,       
        FindPesos,               
        FindControles,
        FindSecados,
        Secados,
        Sincronizar // Debe ser la última entrada de la enumeración.
    }

    public class FormFactory
    {
        private static Hashtable Formularios = new Hashtable();

        /// <summary>
        /// Constructor
        /// </summary>
        public FormFactory() { }

        /// <summary>
        /// Permite recuperar un formulario.
        /// </summary>
        /// <param name="formulario">Formulario a recuperar.</param>
        /// <returns>Formulario instanciado.</returns>
        public static Form Obtener(Formulario formulario)
        {
            Form Pantalla = (Form)Formularios[formulario];

            if (Pantalla == null)
                Pantalla = Crear(formulario);

            return Pantalla;
        }

        /// <summary>
        /// Instancia un formulario.
        /// </summary>
        /// <param name="formulario">Formulario a crear.</param>
        /// <returns>Formulario</returns>
        public static Form Crear(Formulario formulario)
        {
            Form Pantalla = null;
            switch (formulario)
            {
                case Formulario.Intro:
                    Pantalla = new Intro();
                    break;
                case Formulario.Principal:
                    Pantalla = new Principal(Program.Version);
                    break;
                case Formulario.Animal:
                    Pantalla = new Animal();
                    break;
                case Formulario.InsertarAnimal:
                    Pantalla = new InsertarAnimal();
                    break;
                case Formulario.BorrarAnimal:
                    Pantalla = new BorrarAnimal();
                    break;
                case Formulario.Inseminaciones:
                    Pantalla = new Inseminaciones();
                    break;
                case Formulario.InsertarInseminacion:
                    Pantalla = new InsertarInseminacion();
                    break;
                case Formulario.Explotaciones:
                    Pantalla = new Explotaciones();
                    break;
                case Formulario.Partos:
                    Pantalla = new Partos();
                    break;
                case Formulario.InsertarParto:
                    Pantalla = new InsertarPartoMultiples();
                    break; 
                case Formulario.DiagnosticoGestacion:
                    Pantalla = new DiagnosticoGestacion();
                    break;
                case Formulario.InsertarDiagnosticoGestacion:
                    Pantalla = new InsertarDiagnosticoGestacion();
                    break;
                case Formulario.CondicionCorporal:
                    Pantalla = new CondicionCorporal();
                    break;
                case Formulario.InsertarCondicionCorporal:
                    Pantalla = new InsertarCondicionCorporal();
                    break;
                case Formulario.Pesos:
                    Pantalla = new Pesos();
                    break;
                case Formulario.InsertarPeso:
                    Pantalla = new InsertarPeso();
                    break;
                case Formulario.Diagnosticos:
                    Pantalla = new Diagnosticos();
                    break;
                case Formulario.Tratamientos:
                    Pantalla = new Tratamientos();
                    break;
                case Formulario.InsertarDiagnosticoEnfermedad:
                    Pantalla = new InsertarDiagnosticoEnfermedad();
                    break;
                case Formulario.Enfermedades:
                    Pantalla = new Enfermedades();
                    break;
                case Formulario.InsertarTratamientoEnfermedad:
                    Pantalla = new InsertarTratamientoEnfermedad();
                    break;
                case Formulario.Controles:
                    Pantalla = new Controles();
                    break;
                case Formulario.InsertarRegistroLeches:
                    Pantalla = new InsertarRegistroLeches();
                    break;
                case Formulario.Secados:
                    Pantalla = new Secados();
                    break;
                case Formulario.InsertarSecados:
                    Pantalla = new InsertarSecados();
                    break;
                case Formulario.PartosMultiples:
                    Pantalla = new PartosMultiples();
                    break;
                case Formulario.InsertarPartosMultiples:
                    Pantalla = new InsertarPartosMultiples();
                    break;
                case Formulario.SeleccionarLotes:
                    Pantalla = new SeleccionarLotes();
                    break;
                case Formulario.Cubriciones:
                    Pantalla = new Cubriciones();
                    break;
                case Formulario.InsertarCubricion:
                    Pantalla = new InsertarCubricion();
                    break; 
                case Formulario.Sincronizar:
                    Pantalla = new Sincronizar();
                    break;
            }

            if (Pantalla != null)
                Formularios.Add(formulario, Pantalla);

            return Pantalla;
        }
        public static void ActualizarBarrasEstado()
        {
            foreach (Form frm in Formularios.Values)
            {
                if (frm.Name != "Intro" && frm.Name != "")
                    ((Principal)frm).statusBar1.Text = Program.estado;
            }
        }
    }
}
