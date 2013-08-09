using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEXVOC.Core.Logic
{
    /// <summary>
    /// Herramienta que se encarga de mantener actualizada correctamente la tabla contactos.
    /// Esta tabla es un tanto especial, ya que permite contactos introducidos por el usuario diferenciados por tipo,
    /// aunque también tendrá sincronizados los siguientes elementos:
    ///  - Clientes
    ///  - Proveedores
    ///  - Personal 
    ///  - Titulares
    /// Cada uno de estos elementos tienen sus propias características y se utilizan en diversas operaciones.
    /// Para poder actualizarlos es obligado hacerlo en sus formularios correspondientes.
    /// Ya que cualquiera de estos elementos es susceptible de ser actualizado, se proporciona un medio de sincronización.
    /// NOTA: Si eliminamos alguno de estos elementos se eliminará también de contactos, siempre y cuando no existan citas que lo 
    /// relacionen, en este caso no se borrará, podemos consultar este tipo de información el el log de información.
    /// </summary>
    public static class SincronizarContactos
    {
        public static void Sincronizar()
        {
             //Primero hay que borrar todos los contactos automáticos
            
            BD.IniciarBDOperaciones();
            Traza.RegistrarInfo("Comienzo del proceso de sincronización de contactos.");
            try
            {

                Dictionary<string,Contacto> lstContactosAutomaticos = Contacto.BuscarAutomaticos();
                List<Cliente> lstClientes = Cliente.Buscar();
                List<Proveedor> lstProveedores = Proveedor.Buscar();
                List<Veterinario> lstPersonal = Veterinario.Buscar();
                List<Titular> lstTitulares = Titular.Buscar();

                //SINCRONIZO LOS CLIENTES
                if (lstClientes != null && lstClientes.Count > 0)
                {
                                     
                    foreach (Cliente item in lstClientes)
                    {
                        if (lstContactosAutomaticos.ContainsKey("C" + item.Id.ToString()))
                        {//hay que actualizar el contacto de tipo cliente porque existe                            

                            Contacto contactoActualizar = lstContactosAutomaticos["C" + item.Id.ToString()];
                            lstContactosAutomaticos.Remove("C" + item.Id.ToString());//Quito el contacto procesado de la lista.

                            ActualizarContacto(contactoActualizar, item.Nombre, item.Direccion, item.Telefono, item.Movil, item.Email,string.Empty);

                       }
                        else//No existe el contacto, lo creamos
                        {
                            CrearContacto(Configuracion.TiposContactosSistema.CLIENTE, "C" + item.Id.ToString(), item.Nombre, item.Direccion,
                                item.Telefono, item.Movil, item.Email,string.Empty);
                        }
                    }
                }

                //SINCRONIZO LOS PROVEEDORES
                if (lstProveedores != null && lstProveedores.Count > 0)
                {
                    
                    foreach (Proveedor item in lstProveedores)
                    {
                        if (lstContactosAutomaticos.ContainsKey("P" + item.Id.ToString()))
                        {//hay que actualizar el contacto de tipo cliente porque existe
                                                        
                            Contacto contactoActualizar = lstContactosAutomaticos["P" + item.Id.ToString()];
                            lstContactosAutomaticos.Remove("P" + item.Id.ToString());//Quito el contacto procesado de la lista.
                            ActualizarContacto(contactoActualizar, item.Nombre, item.Direccion, item.Telefono, item.Movil, item.Email,string.Empty);

                        }
                        else//No existe el contacto, lo creamos
                        {
                            CrearContacto(Configuracion.TiposContactosSistema.PROVEEDOR, "P" + item.Id.ToString(), item.Nombre, item.Direccion,
                          item.Telefono, item.Movil, item.Email,string.Empty);

                        }
                    }
                }
                //SINCRONIZO EL PERSONAL
                if (lstPersonal != null && lstPersonal.Count > 0)
                {

                    foreach (Veterinario item in lstPersonal)
                    {
                        if (lstContactosAutomaticos.ContainsKey("V" + item.Id.ToString()))
                        {//hay que actualizar el contacto de tipo cliente porque existe

                            Contacto contactoActualizar = lstContactosAutomaticos["V" + item.Id.ToString()];
                            lstContactosAutomaticos.Remove("V" + item.Id.ToString());//Quito el contacto procesado de la lista.
                            ActualizarContacto(contactoActualizar, item.Nombre + " " + item.Apellidos??string.Empty, item.Direccion, item.Telefono, item.Movil, item.Email, item.DescTipo);

                        }
                        else//No existe el contacto, lo creamos
                        {
                            CrearContacto(Configuracion.TiposContactosSistema.PERSONAL, "V" + item.Id.ToString(), item.Nombre + " " + item.Apellidos ?? string.Empty,
                                item.Direccion,item.Telefono, item.Movil, item.Email, item.DescTipo);

                        }
                    }
                }
                //SINCRONIZO EL PERSONAL
                if (lstTitulares != null && lstTitulares.Count > 0)
                {

                    foreach (Titular item in lstTitulares)
                    {
                        if (lstContactosAutomaticos.ContainsKey("T" + item.Id.ToString()))
                        {//hay que actualizar el contacto de tipo cliente porque existe

                            Contacto contactoActualizar = lstContactosAutomaticos["T" + item.Id.ToString()];
                            lstContactosAutomaticos.Remove("T" + item.Id.ToString());//Quito el contacto procesado de la lista.
                            ActualizarContacto(contactoActualizar, item.Nombre + " " + item.Apellidos ?? string.Empty, item.Direccion, item.Telefono, item.Movil, item.Email, string.Empty);

                        }
                        else//No existe el contacto, lo creamos
                        {
                            CrearContacto(Configuracion.TiposContactosSistema.TITULARES, "T" + item.Id.ToString(), item.Nombre + " " + item.Apellidos ?? string.Empty,
                                item.Direccion, item.Telefono, item.Movil, item.Email,string.Empty);

                        }
                    }
                }


                //ELIMINO TODOS AQUELLOS ELEMENTOS QUE NO HE SINCRONIZADO Y TIENEN EL CAMPO AUTOMATICO CON INFORMACION
                foreach (KeyValuePair<string, Contacto> item in lstContactosAutomaticos)//Una vez terminado todo el proceso elimino los elementos que quedan en la lista de procesados
                //Porque se entiende que son clientes o proveedores que han sido eliminados.
                {
                    ((Contacto)item.Value).PermitirCambio = true;
                    try
                    {
                        ((Contacto)item.Value).Eliminar();
                    }
                    catch (Exception ex)
                    {
                        Traza.RegistrarInfo("Error en Sincronizar Contactos, " + ex.Message);
                    }
                }
            
            }
            catch (Exception ex)
            {
                throw new LogicException("Error sincronizando los contactos: " + ex.Message);                
            }
            finally 
            {
                BD.FinalizarBDOperaciones();
                Traza.RegistrarInfo("Finalización del proceso de sincronización de contactos.");
            }                       
        }

        private static Contacto ActualizarContacto(Contacto contactoActualizar,string nombre,string direccion,string telefono,string movil,string email,string observaciones)
        {
            contactoActualizar = (Contacto)contactoActualizar.CargarContextoOperacion(TipoContexto.Modificacion);

            contactoActualizar.PermitirCambio = true;

            if (!string.IsNullOrEmpty(nombre))
                contactoActualizar.Nombre = nombre;
            if (!string.IsNullOrEmpty(direccion))            
                contactoActualizar.Direccion = direccion;
            if (!string.IsNullOrEmpty(telefono))            
                contactoActualizar.Telefono = telefono;
            if (!string.IsNullOrEmpty(movil))            
                contactoActualizar.Movil = movil;
            if (!string.IsNullOrEmpty(email))            
                contactoActualizar.Email = email;
            if (!string.IsNullOrEmpty(observaciones))
                contactoActualizar.Observaciones = observaciones;

            try
            {
                contactoActualizar.Actualizar();
            }
            catch (Exception ex)
            { Traza.RegistrarInfo("Error en Sincronizar Contactos, " + ex.Message); }

            return contactoActualizar;
        }
        private static Contacto CrearContacto(Configuracion.TiposContactosSistema tipoContacto,string automatico,string nombre, string direccion, string telefono, string movil, string email,string observaciones)
        {

            Contacto contactoCrear = new Contacto();
            contactoCrear.IdExplotacion = Configuracion.Explotacion.Id;
            contactoCrear.IdTipo = Configuracion.TipoContactoSistema(tipoContacto).Id;
            contactoCrear.Automatico = automatico;
                    

            if (!string.IsNullOrEmpty(nombre))
                contactoCrear.Nombre = nombre;
            if (!string.IsNullOrEmpty(direccion))
                contactoCrear.Direccion = direccion;
            if (!string.IsNullOrEmpty(telefono))
                contactoCrear.Telefono = telefono;
            if (!string.IsNullOrEmpty(movil))
                contactoCrear.Movil = movil;
            if (!string.IsNullOrEmpty(email))
                contactoCrear.Email = email;
            if (!string.IsNullOrEmpty(observaciones))
                contactoCrear.Observaciones = observaciones;

            try
            {
                contactoCrear.Insertar();
            }
            catch (Exception ex)
            {
                Traza.RegistrarInfo("Error en Sincronizar Contactos, " + ex.Message);
            }

            return contactoCrear;
        }


    }
}
