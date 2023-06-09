using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Empresa_Vuelos.Entidades
{
    class Alojamiento
    {

        public int idAlojamientos { get; set; }
        public string nombreAlojamiento { get; set; }
        public string codigoCiudad { get; set; }
        public string direccion { get; set; }
        public char calificacion { get; set; }
        public List<HabitacionDisponibilidad> alojamientoDispobiles { get; set; }

        public class HabitacionDisponibilidad
        {
            public string nombreHabitacion { get; set; }
            public int tarifaHabitacion { get; set; }
            public List<CapacidadMaxima> capacidadHabitacion { get; set; }
            public List<HabitacionFecha> fechaHabitacion { get; set; }

            public class CapacidadMaxima
            {
                public int maximoAdulto { get; set; }
                public int maximoMenores { get; set; }
                public int maximoInfantes { get; set; }
            }
            public class HabitacionFecha
            {
                public DateTime fechaDispHabitacion { get; set; }
                public int cantHabXFecha { get; set; }
            }
        }

    }
}
