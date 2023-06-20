using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CAI_Empresa_Vuelos.Entidades
{
    public class BBDD
    {
        public static List<Vendedor> TraerVendedor()
        {
            string usuario = $"{AppDomain.CurrentDomain.BaseDirectory}/../../../Datos/Vendedor.json";
            return TraerEntidades<Vendedor>(usuario);
        }

        public static Vendedor TraerVendedorPorDato(string usuarioIngreso)
        {
            List<Vendedor> user = TraerVendedor();
            Vendedor cliente = user.Find(x => x.usuario == usuarioIngreso);

            return cliente;
        }

        public static Vuelo TraerVueloPorOrigen(string origenIngresado, string destinoIngresado, DateTime fechaVuelo)
        {
            List<Vuelo> vuelos = TraerVuelo();
            Vuelo vuelo = vuelos.Find(v => v.origen == origenIngresado && v.destino == destinoIngresado && v.fechaSalida.Date == fechaVuelo.Date);
            return vuelo;
        }

        public static List<Vuelo> TraerVuelo()
        {
            string vuelo = $"{AppDomain.CurrentDomain.BaseDirectory}/../../../Datos/Vuelo.json";

            return TraerEntidades<Vuelo>(vuelo);
        }

        public static List<Alojamiento> TraerAlojamiento()
        {
            string alojamiento = $"{AppDomain.CurrentDomain.BaseDirectory}/../../../Datos/Alojamiento.json";

            return TraerEntidades<Alojamiento>(alojamiento);
        }

        public static List<Alojamiento> TraerAlojamientoFiltrado(string ciudad, int adultos, int menores, int infantes, DateTime fecha)
        {
            List<Alojamiento> alojamientos = TraerAlojamiento();

            alojamientos = alojamientos
            .Where(a => a.codigoCiudad == ciudad &&
            a.alojamientoDispobiles.Any(ad => ad.capacidadHabitacion.Any(ch => ch.maximoInfantes >= infantes && ch.maximoMenores >= menores && ch.maximoAdulto >= adultos)) &&
            a.alojamientoDispobiles.Any(ad => ad.fechaHabitacion.Any(fh => fh.fechaDispHabitacion == fecha.Date && fh.cantHabXFecha > 0)))
            .ToList();

            return alojamientos;

        }

        private static List<T> TraerEntidades<T>(string rutaArchivo)
        {
            StreamReader r = new StreamReader(rutaArchivo);
            string jsonString = r.ReadToEnd();
            List<T> entidades = JsonConvert.DeserializeObject<List<T>>(jsonString);

            r.Close();

            return entidades;
        }

    }
}
