using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAI_Empresa_Vuelos.Entidades;
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

            InitializeComponent();

        }

        private void Vuelo_CheckedChanged(object sender, EventArgs e)
        {
            Alojamientos.Checked = false;

            if (Vuelo.Checked)
            {
                LblOrigen.Text = "Origen";
                LblOrigen.Visible = true;
                LblDestino.Text = "Destino";
                LblDestino.Visible = true;
                LblFecha.Visible = true;
                comboBoxDestino.Visible = true;
                comboBoxOrigen.Visible = true;
                comboBoxFecha.Visible = true;


                ConfigurarComboBoxOrigen();

                while (comboBoxDestino.SelectedIndex != -1 && comboBoxOrigen.SelectedIndex != -1 && comboBoxFecha.SelectedIndex != -1)
                {
                    buttonBuscar.Visible = true;
                    Lblinfo.Text = ($"Vuelo con origen de: {comboBoxOrigen.Text} a {comboBoxDestino.Text} para la fecha {comboBoxFecha.Text}");
                }
            }
        }

        private void ConfigurarComboBoxOrigen()
        {
            this.vuelos = BBDD.TraerVuelo();

            comboBoxOrigen.DisplayMember = "origen";
            comboBoxOrigen.SelectedItem = 0;
            comboBoxOrigen.DataSource = vuelos;

            comboBoxDestino.DisplayMember = "destino";
            comboBoxDestino.SelectedItem = 0;

            comboBoxFecha.DisplayMember = "fechaSalida";
            comboBoxFecha.SelectedItem = 0;
            comboBoxFecha.FormatString = "dd/MM/yyyy";

            comboBoxFecha.DataSource = vuelos;

            //fechasFiltradas = new List<DateTime>();
            
            comboBoxDestino.DataSource = vuelos;
        }

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            string origenSeleccionado = comboBoxOrigen.Text;
            List<Vuelo> destinosFiltrados = vuelos.Where(v => v.origen == origenSeleccionado).ToList();

            comboBoxDestino.DataSource = destinosFiltrados;
        }

        private void comboBoxFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            string origenSeleccionado = comboBoxOrigen.Text;
            string destinoSeleccionado = comboBoxDestino.Text;

            List<Vuelo> vuelosFiltrados = vuelos.Where(v => v.origen == origenSeleccionado && v.destino == destinoSeleccionado).ToList();

            //fechasFiltradas = vuelosFiltrados.Select(v => v.fechaSalida).ToList();
            comboBoxFecha.DataSource = vuelosFiltrados;
            //comboBoxFecha.DataSource = fechasFiltradas;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = true;

            MostrarDatosEnCheckedListBox();

        }

        private void MostrarDatosEnCheckedListBox()
        {
            checkedListBox1.Items.Clear();

            foreach (Vuelo vuelo in vuelos)
            {
                while (vuelo.origen == comboBoxOrigen.Text && vuelo.destino == comboBoxDestino.Text && vuelo.fechaSalida.ToString() == comboBoxFecha.Text)
                {
                    foreach (TarifaVuelo tarifa in vuelo.tarifas)
                    {
                    
                        string itemText = $"Clase: {tarifa.clase}, Precio: {tarifa.precio}, Disponibilidad: {tarifa.disponibilidad}";
                        checkedListBox1.Items.Add(itemText);
                    }
                }
            }
        }



        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pantalla2 pantalla2 = new Pantalla2();
            pantalla2.Show();
        }

        private void Alojamientos_CheckedChanged(object sender, EventArgs e)
        {
            Vuelo.Checked = false;
            this.alojamientos = BBDD.TraerAlojamiento();

            if (Alojamientos.Checked)
            {

                LblOrigen.Text = "Ciudad";
                LblOrigen.Visible = true;
                LblDestino.Text = "Capacidad Maxima";
                LblDestino.Visible = true;
                LblFecha.Visible = true;
                comboBoxDestino.Visible = true; ///Ciudad
                comboBoxOrigen.Visible = true; // 
                comboBoxFecha.Visible = true;
                buttonBuscar.Visible = true;
            }

        }
    }
}
