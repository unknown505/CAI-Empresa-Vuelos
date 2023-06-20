using CAI_Empresa_Vuelos.Entidades;
using Newtonsoft.Json;
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
using static CAI_Empresa_Vuelos.Entidades.Reserva;
using static CAI_Empresa_Vuelos.Entidades.Vuelo;
using static CAI_Empresa_Vuelos.Entidades.Alojamiento;

namespace CAI_Empresa_Vuelos
{
    public partial class EstadoReserva : Form
    {
        private List<Reserva> reservas { get; set; }
        private List<Vuelo> vuelos { get; set; }
        private List<Alojamiento> alojamientos { get; set; }

        public EstadoReserva()
        {
            InitializeComponent();
            this.reservas = new List<Reserva>();
            string[] fileLines2 = File.ReadAllLines("..\\..\\..\\Datos\\Reservas.json");
            string json2 = string.Join("", fileLines2);
            this.reservas = JsonConvert.DeserializeObject<List<Reserva>>(json2);
            if (this.reservas == null)
            {
                this.reservas = new List<Reserva>();
            }
            string[] fileLines = File.ReadAllLines("..\\..\\..\\Datos\\Vuelo.json");
            string json = string.Join("", fileLines);
            this.vuelos = JsonConvert.DeserializeObject<List<Vuelo>>(json);

            string[] fileLinesA = File.ReadAllLines("..\\..\\..\\Datos\\Alojamiento.json");
            string jsonA = string.Join("", fileLinesA);
            this.alojamientos = JsonConvert.DeserializeObject<List<Alojamiento>>(jsonA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcesarPrereserva();
            //UNICAMENTE ES DESCONTAR DISPONIBILIDAD
            //CAMBIA EL ESTADO A PRE-RESERVA 
            //SOLO SI NUMERO DE SEGUIMIENTO ES PRESUPUESTO
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosPasajeros pantalla = new DatosPasajeros(Convert.ToInt32(textBoxNumeroReserva.Text));
            pantalla.Show();
            //UNICAMENTE CARGA LOS PASAJEROS
            //CAMBIA EL ESTADO A RESERVA
            //LLEVAR A LA PANTALLA PASAJEROS
            //SOLO SI NUMERO DE SEGUIMIENTO ES PRE - RESERVA
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            foreach(Reserva reserva in this.reservas)
            {
                if(reserva.Dni == Convert.ToInt32(textBoxDNI.Text) && reserva.Id == Convert.ToInt32(textBoxNumeroReserva.Text))
                {
                    labelDatosReserva.Text = reserva.Estado + " " + reserva.Id.ToString();
                }
            }

        }

        private void ProcesarPrereserva()
        {
            foreach (Reserva reserva in this.reservas)
            {
                if (reserva.Dni == Convert.ToInt32(textBoxDNI.Text) && reserva.Id == Convert.ToInt32(textBoxNumeroReserva.Text) && reserva.Estado == "Presupuesto")
                {
                    reserva.Estado = "Pre-reserva";
                    foreach (ItemVuelo item in reserva.ItemsVuelo)
                    {
                        string[] datos = item.Datos.Split(",");
                        string[] datos2 = datos[5].Split(":");
                        string[] datosvuelo = datos[0].Split(":");
                        string[] datosclase = datos[1].Split(":");
                        string[] datospasajero = datos[2].Split(":");
                        foreach (Vuelo vuelo in vuelos)
                        {
                            if (Convert.ToInt32(vuelo.idVuelo) == Convert.ToInt32(datosvuelo[1]))
                            {
                                foreach (TarifaVuelo tarifa in vuelo.tarifas)
                                {
                                    if (tarifa.clase == datosclase[1] && tarifa.pasajero == datospasajero[1])
                                    {
                                        tarifa.disponibilidad = tarifa.disponibilidad - item.Pasajeros.Count;
                                    }
                                }
                            }
                        }
                    }

                    foreach(ItemAlojamiento itema in reserva.ItemsAlojamiento)
                    {
                        string[] datos = itema.Datos.Split(",");
                        string[] datosid = datos[0].Split(":");
                        string[] datosfecha = datos[1].Split(":");

                        foreach(Alojamiento aloj in alojamientos)
                        {
                            if(aloj.idAlojamientos == datosid[1])
                            {
                                if (aloj.alojamientoDispobiles[0].fechaHabitacion[0].fechaDispHabitacion == Convert.ToDateTime(datosfecha[1]))
                                {
                                    aloj.alojamientoDispobiles[0].fechaHabitacion[0].cantHabXFecha += -1;
                                }
                            }
                        }
                    }
                }
            }
            string rutaArchivoVuelos = "..\\..\\..\\Datos\\Vuelo.json";
            string jsonActualizadoVuelos = JsonConvert.SerializeObject(vuelos, Formatting.Indented);
            File.WriteAllText(rutaArchivoVuelos, jsonActualizadoVuelos);

            string rutaArchivoReservas = "..\\..\\..\\Datos\\Reservas.json";
            string jsonActualizadoReservas = JsonConvert.SerializeObject(reservas, Formatting.Indented);
            File.WriteAllText(rutaArchivoReservas, jsonActualizadoReservas);

            string rutaArchivoAlojamiento = "..\\..\\..\\Datos\\Alojamiento.json";
            string jsonActualizadoalojamiento = JsonConvert.SerializeObject(alojamientos, Formatting.Indented);
            File.WriteAllText(rutaArchivoAlojamiento, jsonActualizadoalojamiento);

            MessageBox.Show("El presupuesto : " + textBoxNumeroReserva.Text + " pasó a estado Pre-reserva.");
            labelDatosReserva.Text = "";
        }
    }
}
