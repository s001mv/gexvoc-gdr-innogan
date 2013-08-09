using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Reflection;

namespace GEXVOC.UI
{
    public partial class EditDatosSistema : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditDatosSistema()
        {
            InitializeComponent();
            btnGuardar.Visible = false;
            btnGuardar.Enabled = false;
        }

        private void EditDatosSistema_Load(object sender, EventArgs e)
        {
            //Recargo todas las listas de datos del sistema
            Configuracion.RecargarListasSistema();

            this.lstGrupos.Items.Clear();
            this.lstGrupos.Groups.Clear();         


            foreach (Type item in Configuracion.EnumeracionesSistema)
            {
                ListViewGroup GrupoActual = new ListViewGroup(item.Name);
                lstGrupos.Groups.Add(GrupoActual);
                foreach (Enum Valor in  Enum.GetValues(item))
                {
                    ListViewItem ItemActual = new ListViewItem(EnumConversiones.GetDescripcion(Valor));
                    ItemActual.Group = GrupoActual;
                  
                    ItemActual.SubItems.Add(CargarObjeto(Valor)==null?"No encontrado":CargarObjeto(Valor).Id.ToString());
                   
                    lstGrupos.Items.Add(ItemActual);
                }
            }

            //Configuracion.TiposAbortosSistema tipo;


            
            
            //dtgDatosSistema.DataSource=Configuracion.ls
        }
        //public EditDatosSistema(Modo modo, DatosSistema ClaseBase)
        //    : base(modo, ClaseBase)
        //{
        //    InitializeComponent();
        //}
        #endregion

        #region CARGAS COMUNES
 

        IClaseBase CargarObjeto(Enum TipoEnumeracion)
        {
            IClaseBase rtno = null;


            if (TipoEnumeracion.GetType() == typeof(Configuracion.EspeciesSistema))
                rtno = Configuracion.EspecieSistema((Configuracion.EspeciesSistema)TipoEnumeracion);

            if (TipoEnumeracion.GetType() == typeof(Configuracion.MomentosPesoSistema))
                rtno = Configuracion.MomentoPesoSistema((Configuracion.MomentosPesoSistema)TipoEnumeracion);


            if (TipoEnumeracion.GetType() == typeof(Configuracion.NaturalezasGastosSistema))
                rtno = Configuracion.NaturalezaGastoSistema((Configuracion.NaturalezasGastosSistema)TipoEnumeracion);

            if (TipoEnumeracion.GetType() == typeof(Configuracion.ProductosSistema))
                rtno = Configuracion.ProductoSistema((Configuracion.ProductosSistema)TipoEnumeracion);


            if (TipoEnumeracion.GetType() == typeof(Configuracion.TiposAbortosSistema))
                rtno = Configuracion.TipoAbortoSistema((Configuracion.TiposAbortosSistema)TipoEnumeracion);

            if (TipoEnumeracion.GetType() == typeof(Configuracion.TiposAltaSistema))
                rtno = Configuracion.TipoAltaSistema((Configuracion.TiposAltaSistema)TipoEnumeracion);


            if (TipoEnumeracion.GetType() == typeof(Configuracion.TiposContactosSistema))
                rtno = Configuracion.TipoContactoSistema((Configuracion.TiposContactosSistema)TipoEnumeracion);

            if (TipoEnumeracion.GetType() == typeof(Configuracion.TiposInseminacionSistema))
                rtno = Configuracion.TipoInseminacionSistema((Configuracion.TiposInseminacionSistema)TipoEnumeracion);

            if (TipoEnumeracion.GetType() == typeof(Configuracion.TiposProductosSistema))
                rtno = Configuracion.TipoProductoSistema((Configuracion.TiposProductosSistema)TipoEnumeracion);

            if (TipoEnumeracion.GetType() == typeof(Configuracion.FamiliasSistema))
                rtno = Configuracion.FamiliaSistema((Configuracion.FamiliasSistema)TipoEnumeracion);

            if (TipoEnumeracion.GetType() == typeof(Configuracion.EstadosSistema))
                rtno = Configuracion.EstadoSistema((Configuracion.EstadosSistema)TipoEnumeracion);

            if (TipoEnumeracion.GetType() == typeof(Configuracion.TiposLoteSistema))
                rtno = Configuracion.TipoLoteSistema((Configuracion.TiposLoteSistema)TipoEnumeracion);




            return rtno;
        
        }
        #endregion
    }
}

//#region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
//public DatosSistema ObjetoBase { get { return (DatosSistema)this.ClaseBase; } }
//#endregion

//#region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

//protected override void ClaseBaseAControles()
//{
//    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
//}

//protected override void ControlesAClaseBase()
//{

//    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
//}



///// <summary>
///// Validación de los Controles, se produce antes de actualizar la ClaseBase.
///// </summary>
///// <returns>Controles válidos (Si/No)</returns>
//protected override bool Validar()
//{
//    bool Rtno = true;
//    this.ErrorProvider.Clear();
//    if (!Generic.ControlValorado(new Control[] { txtDescripcion }, this.ErrorProvider))
//        Rtno = false;


//    return Rtno;

//}

// #endregion