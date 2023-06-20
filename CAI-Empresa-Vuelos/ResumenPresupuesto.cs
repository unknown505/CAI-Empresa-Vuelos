using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAI_Empresa_Vuelos.Entidades;
using Newtonsoft.Json;
using static CAI_Empresa_Vuelos.Entidades.Reserva;
using static CAI_Empresa_Vuelos.Entidades.ItemAlojamiento;
using static CAI_Empresa_Vuelos.Entidades.ItemVuelo;

namespace CAI_Empresa_Vuelos
{
    public partial class ResumenPresupuesto : Form
    {
        private List<Reserva> reservas { get; set; }
        private List<ItemAlojamiento> alojamientos { get; set; }
        private List<ItemVuelo> vuelos { get; set; }
        public ResumenPresupuesto(/*List<ItemVuelo> vuelo, List<ItemAlojamiento> alojamiento*/)
        {
            InitializeComponent();

            string rutaArchivo = "..\\..\\..\\Datos\\Reservas.json"; // Especifica la ruta y el nombre del archivo JSON
            string jsonActual = File.ReadAllText(rutaArchivo);
            List<Reserva> reservas = JsonConvert.DeserializeObject<List<Reserva>>(jsonActual);
            if (reservas == null)
            {
                reservas = new List<Reserva>();
            }


            List<Reserva> reserva = reservas.Skip(Math.Max(0, reservas.Count - 1)).ToList();

            foreach (Reserva r in reservas)
            {
                labelResumen.Text = $"  {r.Dni}    +     {r.Id} ";

                //foreach (ItemVuelo v in reservas.ItemsVuelo) {
                //    labelVuelos.Text = $"{v.Datos}";
                //}
                //foreach (ItemAlojamiento a in reservas.alojamientos)
                //{
                //    labelAlojamiento.Text = $"{a.Datos}";
                //}

            }
        }


        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }


    }
}
