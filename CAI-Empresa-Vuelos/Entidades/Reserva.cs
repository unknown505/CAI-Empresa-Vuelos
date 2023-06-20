using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CAI_Empresa_Vuelos.Entidades
{
    class Reserva
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public string Estado { get; set; }
        public List<ItemVuelo> ItemsVuelo { get; set; }
        public List<ItemAlojamiento> ItemsAlojamiento { get; set; }

        public Reserva() 
        { 
            ItemsVuelo = new List<ItemVuelo>();
            ItemsAlojamiento = new List<ItemAlojamiento>();
        }
    }

}
