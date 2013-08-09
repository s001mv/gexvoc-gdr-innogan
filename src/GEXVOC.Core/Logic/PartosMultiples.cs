using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEXVOC.Core.Logic
{
    public class PartoMultiple
    {
        Animal _animal;

        public Animal animal
        {
            get { return _animal; }
            set { _animal = value; }
        }

        
        public int? IdTipoParto
        {
            get 
            {
                int? rtno = null;
                if (TipoParto != null)
                    rtno = TipoParto.Id;
                return rtno; 
            }
            set
            {
                if (value != null)
                    TipoParto = Logic.TipoParto.Buscar((int)value);
                else
                    TipoParto = null;            
            }
        }
        private TipoParto _TipoParto = null;
        public TipoParto TipoParto
        {
            get { return _TipoParto; }
            set {
                //Cuando cambio el tipo de parto, si tiene configurado un nº específico de crias
                //se lo inicializo por defecto como vivos.
                if (value!=null && value.Crias!=null)                
                    Vivos = value.Crias;
                    
                
                _TipoParto = value; 
            }
        }

        int? _idFacilidad = null;
        public int? IdFacilidad
        {
            get { return _idFacilidad; }
            set { _idFacilidad = value; }
        }

        int? _vivos;
        public int? Vivos
        {
            get { return _vivos; }
            set { _vivos = value; }
        }
        
        int? _muertos;
        public int? Muertos
        {
            get { return _muertos; }
            set { _muertos = value; }
        }


        DateTime? _FechaParto;

        public DateTime? FechaParto
        {
            get { return _FechaParto; }
            set {
                _FechaParto = value;
                _IntervaloPartoAnterior = null;
                }
        }

        int? _IntervaloPartoAnterior;
        public int? IntervaloPartoAnterior
        {
            get 
            {
                if (_IntervaloPartoAnterior==null && animal!=null & FechaParto != null)
                {
                    DateTime? ultimafecha = animal.UltimaFechaParto_Aborto(animal.Id);
                    if (ultimafecha!=null)
                    {
                        
                        System.TimeSpan diffResult = ((DateTime)FechaParto).Subtract((DateTime)ultimafecha);
                        _IntervaloPartoAnterior = diffResult.Days;                                                
                    }
                }

                return _IntervaloPartoAnterior; 
            }
            
        }

       

        public string DescMadre
        {
            get 
            {
                string rtno = string.Empty;
                if (animal!=null)
                    rtno = animal.Nombre;

                return rtno; 
            }
          
        }
                

        string _TipoInsCub = null;
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la UltimoTipoInsCub a la que pertenece el elemento
        ///// </summary>
        public string TipoInsCub
        {
            get
            {

                if (_TipoInsCub == null)
                {
                    _TipoInsCub = string.Empty;
                    if (animal!=null)
                    {
                        IClaseBase inscub = animal.UltimaInseminacion_Cubricion();
                        if (inscub != null)
                        {
                            if (inscub.GetType() == typeof(Inseminacion))
                                _TipoInsCub = ((Inseminacion)inscub).DescTipo;
                            if (inscub.GetType() == typeof(Cubricion))
                                _TipoInsCub = ((Cubricion)inscub).DescTipo;
                        }                        
                    }
                    
                }

                return _TipoInsCub;
            }
        }

        private DateTime? _UltimaFechaParto_Aborto=null;

        public DateTime? UltimaFechaParto_Aborto
        {
            get { return _UltimaFechaParto_Aborto; }
            set { _UltimaFechaParto_Aborto = value; }
        }

        private DateTime? _UltimaFechaInseminacion_Cubricion = null;

        public DateTime? UltimaFechaInseminacion_Cubricion
        {
            get { return _UltimaFechaInseminacion_Cubricion; }
            set { _UltimaFechaInseminacion_Cubricion = value; }
        }

        public int _minimoGestacion=-1;
        public int MinimoGestacion
        {
            get
            {
                if (_minimoGestacion==-1 & animal!=null)                                
                    _minimoGestacion = animal.MinimoGestacion; 

                return _minimoGestacion;
            }

        }
        public int _maximoGestacion = -1;
        public int MaximoGestacion
        {
            get
            {
                if (_maximoGestacion == -1 & animal != null)
                    _maximoGestacion = animal.MaximoGestacion;

                return _maximoGestacion;
            }

        }








    }
}
