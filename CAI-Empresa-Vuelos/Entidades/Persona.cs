using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CAI_Empresa_Vuelos.Entidades
{
    class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string numeroTelefono { get; set; }
        public string mail { get; set; }
        public DateTime fechaNac { get; set; }


    }

}
