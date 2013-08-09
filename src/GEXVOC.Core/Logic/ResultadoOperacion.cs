using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEXVOC.Core.Logic
{
    public class ResultadoOperacion
    {
        public bool OperacionCorrecta { get; set; }
        public string Mensaje { get; set; }
        public IClaseBase Clase { get; set; }

    }
}
