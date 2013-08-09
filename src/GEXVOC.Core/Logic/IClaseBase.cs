using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEXVOC.Core.Logic
{
    public enum TipoContexto { Insercion, Modificacion };

    public enum TipoOperacion { Insercion,Actualizacion,Borrado,NoDefinida}

    public interface IClaseBase
    {
        void Insertar();
        void Actualizar();
        void Eliminar();

        IClaseBase CargarContextoOperacion(TipoContexto Modo);
        int Id
        {
            get;
            set;
        }
       // IClaseBase Buscar(int id);
    }
}
