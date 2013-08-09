using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Data;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class EditSincronizarContactos : GEXVOC.UI.GenericEdit
    {
        public EditSincronizarContactos()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Primero hay que borrar todos los contactos automáticos

            BDController.InicializarBDOperaciones();

            try
            {

                Dictionary<string,Contacto> lstContactosAutomaticos = Contacto.BuscarAutomaticos();
                List<Cliente> lstClientes = Cliente.Buscar();
                List<Proveedor> lstProveedores = Proveedor.Buscar();


                if (lstClientes != null && lstClientes.Count > 0)
                {
                    txtEstado.Text = "Creando contactos del tipo CLIENTE";                    
                    foreach (Cliente item in lstClientes)
                    {
                        if (lstContactosAutomaticos.ContainsKey("C" + item.Id.ToString()))
                        {//hay que actualizar el contacto de tipo cliente porque existe


                            Contacto contactoActualizar = lstContactosAutomaticos["C" + item.Id.ToString()];
                            contactoActualizar = (Contacto)contactoActualizar.CargarContextoOperacion(TipoContexto.Modificacion);
                            contactoActualizar.PermitirCambio = true;
                            contactoActualizar.Nombre = item.Nombre;
                            contactoActualizar.Direccion = item.Direccion;
                            contactoActualizar.Telefono = item.Telefono;
                            contactoActualizar.Actualizar();

                            lstContactosAutomaticos.Remove("C" + item.Id.ToString());//Quito el contacto procesado de la lista.


                        }
                        else//No existe el contacto, lo creamos
                        {

                            Contacto contactoCrear = new Contacto();
                            contactoCrear.Nombre = item.Nombre;
                            contactoCrear.Direccion = item.Direccion;
                            contactoCrear.Telefono = item.Telefono;
                            contactoCrear.IdExplotacion = Configuracion.Explotacion.Id;

                            contactoCrear.IdTipo = Configuracion.TipoContactoSistema(Configuracion.TiposContactosSistema.CLIENTE).Id;
                            contactoCrear.Automatico = "C" + item.Id.ToString();

                            contactoCrear.Insertar();
                        
                        }
                    }
                }
                if (lstProveedores != null && lstProveedores.Count > 0)
                {
                    txtEstado.Text = "Creando contactos del tipo PROVEEDOR";

                    foreach (Proveedor item in lstProveedores)
                    {
                        if (lstContactosAutomaticos.ContainsKey("C" + item.Id.ToString()))
                        {//hay que actualizar el contacto de tipo cliente porque existe


                            Contacto contactoActualizar = lstContactosAutomaticos["C" + item.Id.ToString()];
                            contactoActualizar = (Contacto)contactoActualizar.CargarContextoOperacion(TipoContexto.Modificacion);
                            contactoActualizar.PermitirCambio = true;
                            contactoActualizar.Nombre = item.Nombre;
                            contactoActualizar.Direccion = item.Direccion;
                            contactoActualizar.Telefono = item.Telefono;
                            contactoActualizar.Actualizar();

                            lstContactosAutomaticos.Remove("P" + item.Id.ToString());//Quito el contacto procesado de la lista.


                        }
                        else//No existe el contacto, lo creamos
                        {

                            Contacto contactoCrear = new Contacto();
                            contactoCrear.Nombre = item.Nombre;
                            contactoCrear.Direccion = item.Direccion;
                            contactoCrear.Telefono = item.Telefono;
                            contactoCrear.IdExplotacion = Configuracion.Explotacion.Id;

                            contactoCrear.IdTipo = Configuracion.TipoContactoSistema(Configuracion.TiposContactosSistema.PROVEEDOR).Id;
                            contactoCrear.Automatico = "P" + item.Id.ToString();

                            contactoCrear.Insertar();

                        }
                    }
                }

                foreach (KeyValuePair<string, Contacto> item in lstContactosAutomaticos)//Una vez terminado todo el proceso elimino los elementos que quedan en la lista de procesados
                //Porque se entiende que son clientes o proveedores que han sido eliminados.
                {
                    ((Contacto)item.Value).PermitirCambio = true;
                    try
                    {
                        ((Contacto)item.Value).Eliminar();
                    }
                    catch (LogicException ex)
                    {
                        Traza.RegistrarInfo("Error en Sincronizar Contactos, " + ex.Message);
                    }
                }

                txtEstado.Text = "Proceso concluído";
            
            }
            catch (Exception ex)
            {
                Generic.AvisoError("Error sincronizando los contactos: " + ex.Message);                
            }
            finally 
            {
                BDController.FinalizarBDOperaciones();
            
            }
           

           

        }

    
    }
}
