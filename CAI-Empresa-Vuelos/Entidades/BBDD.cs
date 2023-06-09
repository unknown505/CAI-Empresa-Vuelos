using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CAI_Empresa_Vuelos.Entidades
{
    class BBDD
    {
        public static List<Usuario> TraerUsuario()
        {
            string usuario = $"{AppDomain.CurrentDomain.BaseDirectory}/../../../Datos/Usuario.json";
            return TraerEntidades<Usuario>(usuario);
        }

        public static Usuario TraerClientePorDato(string usuarioIngreso)
        {
            List<Usuario> user = TraerUsuario();
            Usuario cliente = user.Find(x => x.usuario == usuarioIngreso);

            return cliente;
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
