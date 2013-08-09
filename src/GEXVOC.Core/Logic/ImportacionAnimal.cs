using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace GEXVOC.Core.Logic
{
    public class ImportacionAnimal
    {
        #region CONSTUCTORES
            public ImportacionAnimal (TiposImportacion tipoImportacion)
            {
                TipoImportacion = tipoImportacion;
            }
        #endregion

        #region Variables y Propiedades Principales
            public enum TiposImportacion
            {
                BovinaXLS,
                BovinaWeb,
                OvinaCaprina
            }
            TiposImportacion TipoImportacion { get; set; }

        #endregion



        public string Nombre{get;set;}
        public string CI{get;set;}
        public string Recrotalacion { get; set; }
        public string Sexo{get;set;}
        public DateTime? FechaNacimiento{get;set;}
        public string Raza { get; set; }
        public string CIMadre{get;set;}
        public string TipoAlta { get; set; }
        public DateTime? FechaAlta{get;set;}          
        public string ProcedenciaAlta{get;set;}
        public string NumDocumentoAlta{get;set;}
        public string TipoBaja { get; set; }         
        public DateTime? FechaBaja{get;set;}          
        public string DestinoBaja{get;set;}             
        public string NumDocumentoBaja{get;set;}

        string DescNombre 
        {
            get 
            {
                string rtno = string.Empty;

                switch (TipoImportacion)
                {
                    case TiposImportacion.BovinaXLS:
                    case TiposImportacion.BovinaWeb:
                        if (!string.IsNullOrEmpty(Nombre))
                            rtno = Nombre;
                        else
                            rtno = CI;
                        break;
                    case TiposImportacion.OvinaCaprina:
                        rtno = Nombre;
                        break;              
                }
                if (!string.IsNullOrEmpty(rtno))
                    rtno = rtno.ToUpper();
                
                return rtno;
            }
        
        }

        char? DescSexo 
        { 
            get 
            {       
                char? rtno=null;
                if (!string.IsNullOrEmpty(Sexo))
                {
                    switch (Sexo.ToUpper())
                    {
                        case "HEMBRA":
                        case "H":
                            rtno = char.Parse("H");
                            break;
                        case "MACHO":
                        case "M":
                        case "MC":
                            rtno = char.Parse("M");
                            break;
                        

                    }                    
                }
                
                return rtno;
            } 
        }

        string DescTipoAlta
        {
            get
            {
                string rtno = string.Empty;
                switch (TipoImportacion)
                {
                    case TiposImportacion.BovinaXLS:
                        if (!string.IsNullOrEmpty(TipoAlta))
                        {
                            switch (TipoAlta.ToUpper())
                            {
                                case "A": rtno = "APERTURA DEL LIBRO"; break;
                                case "N": rtno = "NACIMIENTO"; break;
                                case "C": rtno = "COMPRA"; break;
                                case "R": rtno = "REPOSICIÓN"; break;
                            }
                        
                        }
                        break;
                    case TiposImportacion.BovinaWeb:
                        if (!string.IsNullOrEmpty(TipoAlta))
                        {
                            if (TipoAlta.ToUpper() != "NACIMIENTO")//Si su tipo de alta es distinto de nacimiento es una compra a explotacion conocida y a demas el valor de este campo es el detalle del alta.
                                rtno = "COMPRA A EXPLOTACIÓN CONOCIDA";
                            else
                                rtno = TipoAlta;                          

                        }
                        break;
                    case TiposImportacion.OvinaCaprina:
                          rtno = "PROCESO DE IMPORTACIÓN";
                        break;           
                }
             
                
                  
                
                return rtno;
            }
        }

        string DescRaza
        {
            get
            {
                string rtno = string.Empty;
                switch (TipoImportacion)
                {
                    case TiposImportacion.BovinaXLS:
                        switch (Raza.ToUpper())
                        {
                            case "R": rtno = "RETINTA"; break;
                            case "U": rtno = "LIMUSINA"; break;
                            case "H": rtno = "CHAROLESA"; break;
                            case "S": rtno = "FLEVICH"; break;
                            case "L": rtno = "LÍDIA"; break;
                            case "B": rtno = "BERRENDA EN NEGRO"; break;
                            case "E": rtno = "BERRENDA EN COLORAO"; break;
                            case "N": rtno = "NEGRA ANDALUZA"; break;
                            case "P": rtno = "PAJUNA"; break;
                            case "C": rtno = "CÁRDENA"; break;
                            case "F": rtno = "FRISONA"; break;
                            case "A": rtno = "PARDA ALPINA"; break;
                            case "M": rtno = "MARISMEÑA"; break;
                            case "O": rtno = "OTRAS CÁRNICAS"; break;
                        }
                        break;
                    default:
                        rtno = string.IsNullOrEmpty(Raza) ? string.Empty : Raza.ToUpper();
                        break;
                 
                }             
                
                return rtno;
            }
        }

        string DescTipoBaja
        {
            get
            {
                string rtno = string.Empty;             
                switch (TipoImportacion)
                {
                    case TiposImportacion.BovinaXLS:
                        if (!string.IsNullOrEmpty(TipoBaja))
                        {
                             switch (TipoBaja.ToUpper())
                            {
                                case "V": rtno = "VENTA VIDA"; break;
                                case "S": rtno = "SACRIFICIO"; break;
                                case "M": rtno = "MUERTE"; break;
                            }
                        }
                       
                        break;
                    default:
                        rtno = string.IsNullOrEmpty(MotivoBaja) ? string.Empty : MotivoBaja.ToUpper();
                        break;                
                }                
                   
                
                return rtno;
            }
        }

        int? IdEspecie
        { 
            get 
            {
                int? rtno=null;
                Especie especie = Configuracion.EspecieSistema(Especie);
                if (especie != null)
                    rtno = especie.Id;
                return rtno;
        
            }
        }

        
        string DetalleAlta 
        {
            get 
            {
                string rtno = string.Empty;

                switch (TipoImportacion)
                {
                    case TiposImportacion.BovinaXLS:
                        rtno = (!string.IsNullOrEmpty(ProcedenciaAlta) ? "PROCEDENCIA: " + ProcedenciaAlta + " " : string.Empty) +
                             (!string.IsNullOrEmpty(NumDocumentoAlta) ? "DOCUMENTO: " + NumDocumentoAlta : string.Empty);
                        break;
                    case TiposImportacion.BovinaWeb:
                        if (TipoAlta.ToUpper() != "NACIMIENTO")
                        {
                            double num;
                            if (!double.TryParse(TipoAlta, out num))//Si el texto no se puede pasar a nº lo tratamos como detalle de alta.
                                rtno = TipoAlta;                         
                            
                        }
                        
                        break;
                    case TiposImportacion.OvinaCaprina:
                        break;                  
                }

                return rtno;
            }        
        
        }

        #region PROPIEDADES ESPECÍFICAS IMPORTACION DE OVEJAS Y CABRAS
           public string EspecieAnimal { get; set; }
           public string MotivoBaja { get; set; }
           public string Crotal { get; set; }

        #endregion

        #region PROPIEDADES ESPECÍFICAS IMPORTACION BOVINA (Web-Pigan)
           //public string EspecieAnimal { get; set; }
           //public string MotivoBaja { get; set; }
           //public string Crotal { get; set; }

       #endregion

       
        

        Configuracion.EspeciesSistema Especie
        {
            get 
            {
                Configuracion.EspeciesSistema rtno = Configuracion.EspeciesSistema.BOVINA;
                if (TipoImportacion == TiposImportacion.OvinaCaprina)
                {
                    if (!string.IsNullOrEmpty(EspecieAnimal))
                    {
                        switch (EspecieAnimal.ToUpper())
                        {
                            case "OVINA": rtno = Configuracion.EspeciesSistema.OVINA; break;
                            case "CAPRINA": rtno = Configuracion.EspeciesSistema.CAPRINA; break;
                        }
                    }                    
                }               
                
                return rtno;            
            }        
        }

      

        //public void ImportarSTR(StringDictionary strDefAnimal)
        //{

        //    if (strDefAnimal != null)
        //    {
        //       //strDefAnimal.

        //        Reflection.Reflection.AsignarValoresAPropiedades(strDefAnimal, this);
        //        Animal animal=null;

        //        if (Especie == Configuracion.EspeciesSistema.BOVINA)
        //        {
        //            if (strDefAnimal.Count < 15)
        //                throw new LogicException("Los datos de la cadena, no tienen la estructura adecuada. Detalle: La estructura debe estar compuesta al menos por 15 columnas\nConsulte el manual para obtener información de la estructura adecuada.");

        //            if (CI.Length != 14)
        //                throw new LogicException("El Nº de identificación debe estar formado por 14 caracteres.");

        //            //Busco si existe el animal
        //            animal = Animal.BuscarTodos(CI,null,null).FirstOrDefault();
        //        }
        //        else 
        //        {   ///Comprobaciones iniciales para importacion de ovejas y cabras
        //            if (strDefAnimal.Count != 12)
        //                throw new LogicException("Los datos de la cadena, no tienen la estructura adecuada. Detalle: La estructura debe estar compuesta por 12 columnas\nConsulte el manual para obtener información de la estructura adecuada.");
        //            if (string.IsNullOrEmpty(Crotal))
        //                throw new LogicException("El crotal es obligatorio.");
        //            if (string.IsNullOrEmpty(Nombre))
        //                throw new LogicException("El nombre es obligatorio.");

        //            if (Crotal.Length>4)
        //                throw new LogicException("El crotal está limitado a 4 caracteres.");

        //            animal = Animal.BuscarTodos(null,Crotal,Nombre).FirstOrDefault();
        //        }
                
        //        if (animal == null)
        //        {
        //            try
        //            {
        //                BD.IniciarBDOperaciones();
        //                BD.IniciarTransaccion();

        //                ///-----------RAZA----------------
        //                if (string.IsNullOrEmpty(this.DescRaza))
        //                    throw new LogicException("El campo Raza es obligatorio. Proceso cancelado");
        //                Raza raza = Logic.Raza.Buscar(DescRaza, IdEspecie).FirstOrDefault();
        //                if (raza == null)
        //                {
        //                    raza = new Raza();
        //                    raza.IdEspecie = (int)IdEspecie;
        //                    raza.Descripcion = this.DescRaza;
        //                    raza.Insertar();
        //                    Traza.RegistrarInfo("Insertada nueva raza: " + this.DescRaza);
        //                }

        //                ///-----------TIPO ALTA----------------
        //                if (string.IsNullOrEmpty(this.DescTipoAlta))
        //                    throw new LogicException("El campo Tipo de Alta es obligatorio. Proceso cancelado");
        //                TipoAlta tipoalta = Logic.TipoAlta.Buscar(DescTipoAlta, null).FirstOrDefault();
        //                if (tipoalta == null)
        //                {
        //                    tipoalta = new TipoAlta();
        //                    tipoalta.Descripcion = this.DescTipoAlta;
        //                    tipoalta.Insertar();
        //                    Traza.RegistrarInfo("Insertado nuevo tipo de alta: " + this.DescTipoAlta);
        //                }

        //                ///-----------TIPO BAJA----------------   
                         
        //                TipoBaja tipobaja =null;
        //                if (DescTipoBaja!=string.Empty)
        //                {                    		  
        //                    tipobaja = Logic.TipoBaja.Buscar(DescTipoBaja, null).FirstOrDefault();
        //                    if (tipobaja == null)
        //                    {
        //                        tipobaja = new TipoBaja();
        //                        tipobaja.Descripcion = this.DescTipoBaja;
        //                        tipobaja.Insertar();
        //                        Traza.RegistrarInfo("Insertado nuevo tipo de baja: " + this.DescTipoBaja);
        //                    }
        //                }
                       


        //                ///Comprobacion de los datos requeridos
        //                if (!FechaNacimiento.HasValue)
        //                    throw new LogicException("La fecha de nacimiento es obligatoria");
        //                if (!FechaAlta.HasValue)
        //                    throw new LogicException("La fecha de alta es obligatoria");
        //                if (!DescSexo.HasValue)                        
        //                    throw new LogicException("El Sexo es obligatorio");                     


                        
        //                animal = new Animal();
        //                animal.Nombre = DescNombre;
        //                animal.Crotal = Crotal;
        //                animal.DIB = CI;                        
        //                animal.FechaNacimiento = (DateTime)FechaNacimiento;
        //                animal.IdExplotacion = Configuracion.Explotacion.Id;
        //                animal.Sexo = (char)DescSexo;
        //                animal.IdRaza = raza.Id;

        //                ///Alta
        //                Alta alta = new Alta();
        //                alta.IdTipo = tipoalta.Id;
        //                alta.Fecha = (DateTime)FechaAlta;
        //                alta.Detalle=(!string.IsNullOrEmpty(ProcedenciaAlta)?"PROCEDENCIA: "+ ProcedenciaAlta + " ":string.Empty)  +
        //                             (!string.IsNullOrEmpty(NumDocumentoAlta)? "DOCUMENTO: " + NumDocumentoAlta : string.Empty);

        //                animal.Alta.Add(alta);                       
                    
        //                if (CIMadre!=string.Empty)
        //                {
        //                    LibroGenealogico libro = new LibroGenealogico();
        //                    libro.Madre = CIMadre;

        //                    animal.LibroGenealogico.Add(libro);
        //                }

        //                animal.Insertar();
        //                Traza.RegistrarInfo("Insertado el animal: " + this.DescNombre);

                                        
        //                ///Baja
        //                if (DescTipoBaja != string.Empty)
        //                {
        //                    animal = Animal.Buscar(animal.Id);        

        //                    if (!FechaBaja.HasValue)
        //                        throw new LogicException("La fecha de baja es obligatoria");
        //                    if (tipobaja == null)
        //                        throw new LogicException("El tipo baja es obligatorio");


        //                    Baja baja = new Baja();
        //                    baja.IdAnimal = animal.Id;
        //                    baja.IdTipo = tipobaja.Id;
        //                    baja.Fecha = (DateTime)FechaBaja;
        //                    baja.Detalle = (!string.IsNullOrEmpty(DestinoBaja) ? "DESTINO: " + DestinoBaja + " " : string.Empty) +
        //                                   (!string.IsNullOrEmpty(NumDocumentoBaja) ? "DOCUMENTO: " + NumDocumentoBaja : string.Empty);

        //                    baja.Insertar();
        //                    //animal.Actualizar();
        //                    Traza.RegistrarInfo("Registrando la baja al animal: " + this.DescNombre);
        //                }

        //                BD.FinalizarTransaccion(true);
        //                BD.FinalizarBDOperaciones();
        //            }
        //            catch (Exception)
        //            {
        //                BD.FinalizarTransaccion(false);
        //                BD.FinalizarBDOperaciones();
        //                throw;
        //            }
        //        }
        //        else 
        //        {
        //            throw new LogicException("El animal no se importará porque ya existe");
        //        }
        //    }
        //}

        
        public void ImportarSTR(StringDictionary strDefAnimal)
        {

            if (strDefAnimal != null)
            {
                //strDefAnimal.

                Reflection.Reflection.AsignarValoresAPropiedades(strDefAnimal, this);
                Animal animal = null;
                switch (TipoImportacion)
                {
                    case TiposImportacion.BovinaXLS:
                        if (strDefAnimal.Count < 15)
                            throw new LogicException("Los datos de la cadena, no tienen la estructura adecuada. Detalle: La estructura debe estar compuesta al menos por 15 columnas\nConsulte el manual para obtener información de la estructura adecuada.");

                        if (CI.Length != 14)
                            throw new LogicException("El Nº de identificación debe estar formado por 14 caracteres.");

                        //Busco si existe el animal
                        animal = Animal.BuscarTodos(CI, null, null).FirstOrDefault();

                        break;
                    case TiposImportacion.BovinaWeb:
                        if (strDefAnimal.Count != 8)
                            throw new LogicException("Los datos de la cadena, no tienen la estructura adecuada. Detalle: La estructura debe estar compuesta al menos por 8 columnas\nConsulte el manual para obtener información de la estructura adecuada.");

                        if (CI.Length != 14)
                            throw new LogicException("El Nº de identificación debe estar formado por 14 caracteres.");

                        //Busco si existe el animal
                        animal = Animal.BuscarTodos(CI, null, null).FirstOrDefault();

                        break;
                    case TiposImportacion.OvinaCaprina:///Comprobaciones iniciales para importacion de ovejas y cabras
                        if (strDefAnimal.Count != 12)
                            throw new LogicException("Los datos de la cadena, no tienen la estructura adecuada. Detalle: La estructura debe estar compuesta por 12 columnas\nConsulte el manual para obtener información de la estructura adecuada.");
                        if (string.IsNullOrEmpty(Crotal))
                            throw new LogicException("El crotal es obligatorio.");
                        if (string.IsNullOrEmpty(Nombre))
                            throw new LogicException("El nombre es obligatorio.");

                        if (Crotal.Length > 12)
                            throw new LogicException("El crotal está limitado a 12 caracteres.");

                        animal = Animal.BuscarTodos(null, Crotal, Nombre).FirstOrDefault();
                        break;
                    default:
                        break;
                }              

                if (animal == null)
                {
                    try
                    {
                        BD.IniciarBDOperaciones();
                        BD.IniciarTransaccion();

                        ///-----------RAZA----------------
                        if (string.IsNullOrEmpty(this.DescRaza))
                            throw new LogicException("El campo Raza es obligatorio. Proceso cancelado");
                        Raza raza = Logic.Raza.Buscar(DescRaza, IdEspecie).FirstOrDefault();
                        if (raza == null)
                        {
                            raza = new Raza();
                            raza.IdEspecie = (int)IdEspecie;
                            raza.Descripcion = this.DescRaza;
                            raza.Insertar();
                            Traza.RegistrarInfo("Insertada nueva raza: " + this.DescRaza);
                        }

                        ///-----------TIPO ALTA----------------
                        if (string.IsNullOrEmpty(this.DescTipoAlta))
                            throw new LogicException("El campo Tipo de Alta es obligatorio. Proceso cancelado");
                        TipoAlta tipoalta = Logic.TipoAlta.Buscar(DescTipoAlta, null).FirstOrDefault();
                        if (tipoalta == null)
                        {
                            tipoalta = new TipoAlta();
                            tipoalta.Descripcion = this.DescTipoAlta;
                            tipoalta.Insertar();
                            Traza.RegistrarInfo("Insertado nuevo tipo de alta: " + this.DescTipoAlta);
                        }

                        ///-----------TIPO BAJA----------------   

                        TipoBaja tipobaja = null;
                        if (DescTipoBaja != string.Empty)
                        {
                            tipobaja = Logic.TipoBaja.Buscar(DescTipoBaja, null).FirstOrDefault();
                            if (tipobaja == null)
                            {
                                tipobaja = new TipoBaja();
                                tipobaja.Descripcion = this.DescTipoBaja;
                                tipobaja.Insertar();
                                Traza.RegistrarInfo("Insertado nuevo tipo de baja: " + this.DescTipoBaja);
                            }
                        }



                        ///Comprobacion de los datos requeridos
                        if (!FechaNacimiento.HasValue)
                            throw new LogicException("La fecha de nacimiento es obligatoria");
                        if (!FechaAlta.HasValue)
                            throw new LogicException("La fecha de alta es obligatoria");
                        if (!DescSexo.HasValue)
                            throw new LogicException("El Sexo es obligatorio");



                        animal = new Animal();
                        animal.Nombre = DescNombre;
                        animal.Crotal = Crotal;
                        animal.DIB = CI;
                        animal.FechaNacimiento = (DateTime)FechaNacimiento;
                        animal.IdExplotacion = Configuracion.Explotacion.Id;
                        animal.Sexo = (char)DescSexo;
                        animal.IdRaza = raza.Id;

                        ///Alta
                        Alta alta = new Alta();
                        alta.IdTipo = tipoalta.Id;
                        alta.Fecha = (DateTime)FechaAlta;
                        alta.Detalle = DetalleAlta;
                        animal.Alta.Add(alta);

                        if (CIMadre != string.Empty)
                        {
                            LibroGenealogico libro = new LibroGenealogico();
                            libro.Madre = CIMadre;

                            animal.LibroGenealogico.Add(libro);
                        }

                        animal.Insertar();
                        Traza.RegistrarInfo("Insertado el animal: " + this.DescNombre);


                        ///Baja
                        if (DescTipoBaja != string.Empty)
                        {
                            animal = Animal.Buscar(animal.Id);

                            if (!FechaBaja.HasValue)
                                throw new LogicException("La fecha de baja es obligatoria");
                            if (tipobaja == null)
                                throw new LogicException("El tipo baja es obligatorio");


                            Baja baja = new Baja();
                            baja.IdAnimal = animal.Id;
                            baja.IdTipo = tipobaja.Id;
                            baja.Fecha = (DateTime)FechaBaja;
                            baja.Detalle = (!string.IsNullOrEmpty(DestinoBaja) ? "DESTINO: " + DestinoBaja + " " : string.Empty) +
                                           (!string.IsNullOrEmpty(NumDocumentoBaja) ? "DOCUMENTO: " + NumDocumentoBaja : string.Empty);

                            baja.Insertar();
                            //animal.Actualizar();
                            Traza.RegistrarInfo("Registrando la baja al animal: " + this.DescNombre);
                        }

                        BD.FinalizarTransaccion(true);
                        BD.FinalizarBDOperaciones();
                    }
                    catch (Exception)
                    {
                        BD.FinalizarTransaccion(false);
                        BD.FinalizarBDOperaciones();
                        throw;
                    }
                }
                else
                {
                    throw new LogicException("El animal no se importará porque ya existe");
                }
            }
        }

                    
    }
}

