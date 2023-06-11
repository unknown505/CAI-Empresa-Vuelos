using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Empresa_Vuelos.Entidades
{
    public class Vuelo
    {

        public string idVuelo { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public DateTime fechaSalida { get; set; }
        public DateTime fechaArribo { get; set; }
        public TimeSpan tiempoVuelo { get; set; }
        public string aerolinea { get; set; }
        public List<TarifaVuelo> tarifas { get; set; }


        public class TarifaVuelo
        {
            public string clase { get; set; } // Clase solo pueden ser E P B F
            public string tipoPasajero { get; set; } // Tipos de pasajeros son A M I 
            public int precio { get; set; }
            public int disponibilidad { get; set; }

        }

    }

    
}
