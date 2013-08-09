using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.UI.Clases;
using GEXVOC.UI;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Informes;





namespace GEXVOC.Informes
{
    public partial class InfLibroExplotacion : GEXVOC.Core.Controles.ctlInforme
    {
        public InfLibroExplotacion()
        {
            InitializeComponent();
        }
        public GenericMaestro FormularioMaestro
        { get { return ((GenericMaestro)this.FormularioInformes); } }

        private void btnBuscarExplotacion_Click(object sender, EventArgs e)
        {
            if (FormularioMaestro != null)
                FormularioMaestro.LanzarFormularioConsulta(new FindExplotaciones(Modo.Consultar, this.cmbExplotacion));
        }
        public override void CargaControles()
        {
            this.cmbExplotacion.ClaseActiva = Configuracion.Explotacion;
            FormularioMaestro.CargarCombo(cmEstado, Estado.Buscar());
            Generic.CargarComboSexos(cmbSexo);
            base.CargaControles();
        }

        /// <summary>
        /// Propiedad que nos retorna el valor que debe tener el parámetro del informe txtDIB
        /// Se calcula en función de la especie seleccionada.
        /// </summary>
        string parametro_txtDIB
        { 
            get
            {
                string rtno="DIB";
                if (cmbEspecie.SelectedValue != null)
                {
                    if ((int)cmbEspecie.SelectedValue == Configuracion.EspecieSistema(Configuracion.EspeciesSistema.BOVINA).Id)                    
                        rtno = "CIB";                                            
                    else                    
                        rtno = "DIB";
                    
                }
                return rtno;
            }
        }

        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {


            LibroExplotacion rpte = new LibroExplotacion();
            LibroExplotacionDS datos = new LibroExplotacionDS();

            Explotacion explotacion = (Explotacion)cmbExplotacion.ClaseActiva;            
            string titular=string.Empty;
            string nif=string.Empty;
            foreach (Titular item in explotacion.lstTitulares)
	        {
        		 titular+=item.NombreCompleto + "/";
                 nif+=item.DNI + "/";
	        }
           
            if (titular!=string.Empty)
                titular=titular.TrimEnd(Convert.ToChar("/"));
            if (nif != string.Empty)
                nif = nif.TrimEnd(Convert.ToChar("/"));

        
             List<Animal> lstAnimales = Animal.Buscar(explotacion.Id, Generic.ControlAIntNullable(cmbEspecie), this.txtNombre.Text,
                                                      txtTatuaje.Text, this.txtCrotal.Text, txtDIB.Text, 
                                                      Generic.ControlAIntNullable(cmEstado), Generic.ControlACharNullable(cmbSexo),false);
            foreach (Animal item in lstAnimales)
            {
                
                LibroExplotacionDS.LibroRow FilaLibro = datos.Libro.NewLibroRow();
                FilaLibro.CEA = explotacion.CEA;
                FilaLibro.Titular = titular;
                FilaLibro.NIF = nif;
                FilaLibro.Explotacion = explotacion.Nombre;
                FilaLibro.Siglas = explotacion.Siglas;

                FilaLibro.Raza = item.DescRaza;
                FilaLibro.Sexo = item.Sexo.ToString();
                FilaLibro.Animal = item.Nombre;
                FilaLibro.FNacimiento = item.FechaNacimiento.ToShortDateString();
                FilaLibro.DIB = item.DIB;


                Alta alta = item.AltaAnimal();
                if (alta != null)
                {
                    FilaLibro.Alta = alta.Fecha.ToShortDateString();
                    FilaLibro.CausaAlta = alta.DescTipo;
                    FilaLibro.Origen = alta.Detalle;
                    FilaLibro.NumeroGuiaEntrada = alta.NumeroGuia;
                }
                Baja baja = item.BajaAnimal();
                if (baja != null)
                {
                    FilaLibro.Baja = baja.Fecha.ToShortDateString();
                    FilaLibro.CausaBaja = baja.DescTipo;
                    FilaLibro.Destino = baja.Detalle;
                    FilaLibro.NumeroGuiaSalida = baja.NumeroGuia;
                }
                LibroGenealogico lgenealogico = item.LibroAnimal();
                if (lgenealogico != null)
                    FilaLibro.CrotalMadre = lgenealogico.Madre;


                    datos.Libro.AddLibroRow(FilaLibro);
                
            }
            
            rpte.SetDataSource(datos);
            rpte.SetParameterValue("txtDIB", parametro_txtDIB);

            return rpte;
        }
        public override void GenerarFiltroVisual()
        {
            AgregarFiltroVisual((Generic.ControlAIntNullable(cmbEspecie).HasValue ? "Especie = " + cmbEspecie.Text:string.Empty));
            AgregarFiltroVisual((txtNombre.Text != string.Empty ? "Nombre contiene (" + txtNombre.Text + ")" : string.Empty));
            AgregarFiltroVisual((txtTatuaje.Text != string.Empty ? "Tatuaje contiene (" + txtTatuaje.Text + ")" : string.Empty));
            AgregarFiltroVisual((txtCrotal.Text != string.Empty ? "Crotal contiene (" + txtCrotal.Text + ")" : string.Empty));
            AgregarFiltroVisual((txtDIB.Text != string.Empty ? "C.I. contiene (" + txtDIB.Text + ")" : string.Empty));           
            AgregarFiltroVisual((Generic.ControlAIntNullable(cmEstado).HasValue ? "Estado = " + cmEstado.Text : string.Empty));
            AgregarFiltroVisual((Generic.ControlACharNullable(cmbSexo).HasValue ? "Sexo = " + Generic.ControlACharNullable(cmbSexo).Value.ToString() : string.Empty));     

        }
        public override bool Validar()
        {
            Boolean rtno = true;
            if (FormularioMaestro != null)
            {
                if (!Generic.ControlValorado(this.cmbExplotacion, FormularioMaestro.ErrorProvider)) rtno = false;
                if (!Generic.ControlValorado(this.cmbEspecie, FormularioMaestro.ErrorProvider)) rtno = false;
            }

                

            return rtno;
        }

        private void cmbExplotacion_ClaseActivaChanged(object sender, GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs e)
        {   //Cuando cambie la explotacion, debo cargar el combo especie de acuerdo con el nuevo valor.

            //Primero limpio el combo y su contenido
            this.cmbEspecie.DataSource = null;
            this.cmbEspecie.Text = string.Empty;

            //Si las condiciones lo permiten cargo el combo especie, unicamente con las especies de la explotación.
            if (e.ClaseActiva != null)
                if (FormularioMaestro != null)
                    FormularioMaestro.CargarCombo(this.cmbEspecie, ((Explotacion)e.ClaseActiva).lstEspecies, true);          

            
        }
     
    }
}
