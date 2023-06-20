using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Empresa_Vuelos.Entidades
{
    class ItemVuelo
    {
        public string Datos { get; set; }
        public List<Pasajero> Pasajeros { get; set; }

        public ItemVuelo() 
        { 
            Pasajeros = new List<Pasajero>();
        }
    }
}
