using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAI_Empresa_Vuelos.Entidades;
using Newtonsoft.Json;
using static CAI_Empresa_Vuelos.Entidades.Vuelo;


namespace CAI_Empresa_Vuelos
{
    public partial class Pantalla3 : Form
    {
        private List<Vuelo> vuelos { get; set; }
        private List<Alojamiento> alojamientos { get; set; }
        //private List<DateTime> fechasFiltradas;
        
        public Pantalla3()
        {
            string[] fileLines = File.ReadAllLines("C:\\Users\\mdarosa\\source\\repos\\CAI-Empresa-Vuelos\\CAI-Empresa-Vuelos\\Datos\\Vuelo.json");
            string json = string.Join("", fileLines);
            this.vuelos = JsonConvert.DeserializeObject<List<Vuelo>>(json);

            InitializeComponent();
        }

        private void Vuelo_CheckedChanged(object sender, EventArgs e)
        {

            if (Vuelo.Checked && Alojamientos.Checked == false)
            {
                LblOrigen.Text = "Origen";
                LblOrigen.Visible = true;
                LblDestino.Text = "Destino";
                LblDestino.Visible = true;
                LblFecha.Visible = true;
                textBoxOrigen.Visible = true;
                dateTimePickerFecha.Visible = true;
                textBoxDestino.Visible = true;
                buttonBuscar.Visible = true;
                string OrigenSeleccion = textBoxOrigen.Text;
                string DestinoSeleccion = textBoxDestino.Text;
                DateTime FechaSeleccion = dateTimePickerFecha.Value;

                Vuelo vuelo = BBDD.TraerVueloPorOrigen(OrigenSeleccion, DestinoSeleccion, FechaSeleccion);

                //ConfigurarComboBoxOrigen();

                //if (comboBoxDestino.SelectedIndex != -1 && comboBoxOrigen.SelectedIndex != -1 && comboBoxFecha.SelectedIndex != -1)
                //{
                //    buttonBuscar.Visible = true;
                //    Lblinfo.Text = ($"Vuelo con origen de: {comboBoxOrigen.Text} a {comboBoxDestino.Text} para la fecha {comboBoxFecha.Text}");
                //}
            }
        }
        private bool ValidarDatosViaje()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(textBoxOrigen.Text))
            {
                labelErrorOrigen.Text = "El Origen no puede estar vacío.";
                valido = false;
            }
            if (string.IsNullOrEmpty(textBoxDestino.Text))
            {
                labelErrorDestino.Text = "El Destino no puede estar vacío.";
                valido = false;
            }
            if (string.IsNullOrEmpty(dateTimePickerFecha.Value.ToString()))
            {
                labelErrorFecha.Text = "La Fecha no puede estar vacía.";
                valido = false;
            }

            if (!valido) { return valido; }
            //Terminar de ver por que no ingresa a la validacion de los datos vuelo
            if (string.IsNullOrEmpty(textBoxDestino.Text))
            {
                labelErrorOrigen.Text = "El Origen no se encuentra registrado.";
                valido = false;
            }
            //if (!string.Equals(textBoxDestino.Text, this.vuelos.destino))
            if (!vuelos.Any(x => x.destino == textBoxDestino.Text))
            {
                labelErrorDestino.Text = "El destino es incorrecto.";
                valido = false;
            }
            //if (!string.Equals(textBoxDestino.Text, this.vuelos.fechaSalida))
            if (!vuelos.Any(x => x.fechaSalida.Date == dateTimePickerFecha.Value.Date))
            { 
                labelErrorFecha.Text = "La fecha es incorrecta.";
                valido = false;
            }

            return valido;
        }

        //private void ConfigurarComboBoxOrigen()
        //{
        //    this.vuelos = BBDD.TraerVuelo();

        //    comboBoxOrigen.DisplayMember = "origen";
        //    comboBoxOrigen.SelectedItem = 0;
        //    comboBoxOrigen.DataSource = vuelos;

        //    comboBoxDestino.DisplayMember = "destino";
        //    comboBoxDestino.SelectedItem = 0;

        //    comboBoxFecha.DisplayMember = "fechaSalida";
        //    comboBoxFecha.SelectedItem = 0;
        //    comboBoxFecha.FormatString = "dd/MM/yyyy";

        //    comboBoxFecha.DataSource = vuelos;

        //    //fechasFiltradas = new List<DateTime>();

        //    comboBoxDestino.DataSource = vuelos;
        //}

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string origenSeleccionado = comboBoxOrigen.Text;
            //List<Vuelo> destinosFiltrados = vuelos.Where(v => v.origen == origenSeleccionado).ToList();

            //comboBoxDestino.DataSource = destinosFiltrados;
        }

        private void comboBoxFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string origenSeleccionado = comboBoxOrigen.Text;
            //string destinoSeleccionado = comboBoxDestino.Text;

            //List<Vuelo> vuelosFiltrados = vuelos.Where(v => v.origen == origenSeleccionado && v.destino == destinoSeleccionado).ToList();

            //fechasFiltradas = vuelosFiltrados.Select(v => v.fechaSalida).ToList();
            //comboBoxFecha.DataSource = vuelosFiltrados;
            //comboBoxFecha.DataSource = fechasFiltradas;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            LimpiarMensaje();

            if (ValidarDatosViaje())
            {
                Lblinfo.Text = ($"Vuelo con origen de: {textBoxOrigen.Text} a {textBoxDestino.Text} para la fecha {dateTimePickerFecha.Text}");
                checkedListBox1.Visible = true;
                MostrarDatosEnCheckedListBox();
            }
            else
            {
                labelErrorOrigen.Show();
                labelErrorDestino.Show();
                labelErrorFecha.Show();
            }


        }

        private void MostrarDatosEnCheckedListBox()
        {
            checkedListBox1.Items.Clear();
            LimpiarTextBoxLista();
            foreach (Vuelo vuelo in vuelos)
            {
                if (vuelo.origen == textBoxOrigen.Text && vuelo.destino == textBoxDestino.Text && vuelo.fechaSalida.ToString() == dateTimePickerFecha.Text)//si no funciona este metodo, usar el traervuelopororigen
                {
                    foreach (TarifaVuelo tarifa in vuelo.tarifas)
                    {
                        string itemText = $"Clase: {tarifa.clase},Tipo Pasajero: {tarifa.tipoPasajero}, Precio: {tarifa.precio}, Disponibilidad: {tarifa.disponibilidad}";
                        checkedListBox1.Items.Add(itemText);
                    }
                }
            }
        }
        
        private void LimpiarMensaje()
        {
            labelErrorOrigen.Text = "";
            labelErrorDestino.Text = "";
            labelErrorFecha.Text = "";
        }
        private void LimpiarTextBoxLista()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }



        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pantalla2 pantalla2 = new Pantalla2();
            pantalla2.Show();
        }

        private void Alojamientos_CheckedChanged(object sender, EventArgs e)
        {
            this.alojamientos = BBDD.TraerAlojamiento();

            if (Alojamientos.Checked && Vuelo.Checked == false)
            {

                LblOrigen.Text = "Ciudad";
                LblOrigen.Visible = true;
                LblDestino.Text = "Capacidad Maxima";
                LblDestino.Visible = true;
                LblFecha.Visible = true;
                textBoxOrigen.Visible = true; ///Ciudad
                textBoxDestino.Visible = true; // CapacidadMax
                dateTimePickerFecha.Visible = true;
                buttonAlojamiento.Visible = true;
            }
            string CiudadSeleccion = textBoxOrigen.Text;
            string CapacidadSeleccion = textBoxDestino.Text;
            DateTime FechaSeleccion = dateTimePickerFecha.Value;

            Vuelo vuelo = BBDD.TraerVueloPorOrigen(CiudadSeleccion, CapacidadSeleccion, FechaSeleccion);


        }

        private void buttonAlojamiento_Click(object sender, EventArgs e)
        {

        }
    }
}
