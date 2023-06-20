using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CAI_Empresa_Vuelos.Entidades
{
    class Pasajero
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public int edad { get; set; }
    }

}
