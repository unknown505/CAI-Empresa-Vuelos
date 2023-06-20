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
using static CAI_Empresa_Vuelos.Entidades.Reserva;
//using static CAI_Empresa_Vuelos.Entidades.ItemAlojamiento;

namespace CAI_Empresa_Vuelos
{
    public partial class Busqueda : Form
    {
        private List<Vuelo> vuelos { get; set; }
        private List<Alojamiento> alojamientos { get; set; }
        private List<ItemVuelo> items { get; set; }
        private List<ItemAlojamiento> itemsAlojamiento { get; set; }

        public Busqueda()
        {
            string[] fileLines = File.ReadAllLines("..\\..\\..\\Datos\\Vuelo.json");
            string json = string.Join("", fileLines);
            this.vuelos = JsonConvert.DeserializeObject<List<Vuelo>>(json);
            items= new List<ItemVuelo>();
            itemsAlojamiento = new List<ItemAlojamiento>();

            InitializeComponent();
            textBoxAdultos.Text = "1";
            textBoxInfantes.Text = "0";
            textBoxMenores.Text = "0";

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
                textBoxOrigen.Text = "";
                dateTimePickerFecha.Visible = true;
                textBoxDestino.Visible = true;
                textBoxDestino.Text = "";
                buttonBuscar.Visible = true;
                buttonAlojamiento.Visible = false;
                buttonAlojamiento.Visible = false;
                labelAdultos.Visible = true;
                labelInfantes.Visible = true;
                labelMenores.Visible = true;
                textBoxAdultos.Visible = true;
                textBoxMenores.Visible = true;
                textBoxInfantes.Visible = true;
                checkedListBox1.Visible = false;
                string OrigenSeleccion = textBoxOrigen.Text;
                string DestinoSeleccion = textBoxDestino.Text;
                DateTime FechaSeleccion = dateTimePickerFecha.Value;

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

            if (string.IsNullOrEmpty(textBoxDestino.Text))
            {
                labelErrorOrigen.Text = "El Origen no se encuentra registrado.";
                valido = false;
            }

            if (!vuelos.Any(x => x.destino == textBoxDestino.Text))
            {
                labelErrorDestino.Text = "El destino es incorrecto.";
                valido = false;
            }

            if (!vuelos.Any(x => x.fechaSalida.Date == dateTimePickerFecha.Value.Date))
            { 
                labelErrorFecha.Text = "La fecha es incorrecta.";
                valido = false;
            }

            return valido;
        }


        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            LimpiarMensaje();

            if (ValidarDatosViaje())
            {
                Lblinfo.Text = ($"Vuelo con origen de: {textBoxOrigen.Text} a {textBoxDestino.Text} para la fecha {dateTimePickerFecha.Text}");
                checkedListBox1.Visible = true;
                MostrarDatosEnCheckedListBox();
                Confirmar.Visible= true;
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
            if (Convert.ToInt32(textBoxAdultos.Text)>0)
            {
                foreach (Vuelo vuelo in vuelos)
                {
                    if (vuelo.origen == textBoxOrigen.Text && vuelo.destino == textBoxDestino.Text && Convert.ToDateTime(vuelo.fechaSalida.ToString("dd/MM/yyyy")) == Convert.ToDateTime(dateTimePickerFecha.Text))
                    {
                        foreach (TarifaVuelo tarifa in vuelo.tarifas)
                        {
                            if(tarifa.pasajero == "Adulto" && tarifa.disponibilidad >= Convert.ToInt32(textBoxAdultos.Text))
                            {
                                string itemText = $"Vuelo:{vuelo.idVuelo},Clase:{tarifa.clase},Tipo Pasajero:{tarifa.pasajero}, Precio:{tarifa.precio}, Disponibilidad:{tarifa.disponibilidad}, Solicitados:{Convert.ToInt32(textBoxAdultos.Text)}";
                                checkedListBox1.Items.Add(itemText);

                            }
                        }
                    }
                }
            }
            if (Convert.ToInt32(textBoxAdultos.Text) >= 1) {
                if (Convert.ToInt32(textBoxMenores.Text) > 0)
                {
                    foreach (Vuelo vuelo in vuelos)
                    {
                        if (vuelo.origen == textBoxOrigen.Text && vuelo.destino == textBoxDestino.Text && Convert.ToDateTime(vuelo.fechaSalida.ToString("dd/MM/yyyy")) == Convert.ToDateTime(dateTimePickerFecha.Text)) {
                            foreach (TarifaVuelo tarifa in vuelo.tarifas)
                            {
                                if (tarifa.pasajero == "Menor" && tarifa.disponibilidad >= Convert.ToInt32(textBoxMenores.Text))
                                {
                                    string itemText = $"Vuelo:{vuelo.idVuelo},Clase:{tarifa.clase},Tipo Pasajero:{tarifa.pasajero}, Precio:{tarifa.precio}, Disponibilidad:{tarifa.disponibilidad}, Solicitados:{Convert.ToInt32(textBoxMenores.Text)}";
                                    checkedListBox1.Items.Add(itemText);
                                }
                            }
                        }
                    }

                }
                if (Convert.ToInt32(textBoxInfantes.Text) > 0)
                {
                    foreach (Vuelo vuelo in vuelos)
                    {
                        if (vuelo.origen == textBoxOrigen.Text && vuelo.destino == textBoxDestino.Text && Convert.ToDateTime(vuelo.fechaSalida.ToString("dd/MM/yyyy")) == Convert.ToDateTime(dateTimePickerFecha.Text))//si no funciona este metodo, usar el traervuelopororigen
                        {
                            foreach (TarifaVuelo tarifa in vuelo.tarifas)
                            {
                                if (tarifa.pasajero == "Infante" && tarifa.disponibilidad >= Convert.ToInt32(textBoxInfantes.Text))
                                {
                                    string itemText = $"Vuelo:{vuelo.idVuelo},Clase:{tarifa.clase},Tipo Pasajero:{tarifa.pasajero}, Precio:{tarifa.precio}, Disponibilidad:{tarifa.disponibilidad}, Solicitados:{Convert.ToInt32(textBoxInfantes.Text)}";
                                    checkedListBox1.Items.Add(itemText);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Menores e infantes no puede viajar sin un adulto", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void LimpiarMensaje()
        {
            labelErrorOrigen.Text = "";
            labelErrorDestino.Text = "";
            labelErrorFecha.Text = "";
        }
        private void LimpiarText()
        {
            textBoxOrigen.Text = "";
            textBoxDestino.Text = "";
            textBoxAdultos.Text = "1";
            textBoxMenores.Text = "0";
            textBoxInfantes.Text="0";
            
        }

        private void LimpiarTextBoxLista()
        {

        }



        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal pantalla2 = new MenuPrincipal();
            pantalla2.Show();
        }

        private void Alojamientos_CheckedChanged(object sender, EventArgs e)
        {
            /*this.alojamientos = BBDD.TraerAlojamiento();
            foreach (var item in this.alojamientos) 
            {
                this.checkedListBox1.Items.Add(item.nombreAlojamiento);
            }*/

            if (Alojamientos.Checked && Vuelo.Checked == false)
            {

                LblOrigen.Text = "Ciudad";
                LblOrigen.Visible = true;
                LblDestino.Visible = false;
                LblFecha.Visible = true;
                textBoxOrigen.Visible = true; ///Ciudad
                textBoxOrigen.Text = "";
                textBoxDestino.Visible = false;
                dateTimePickerFecha.Visible = true;
                buttonAlojamiento.Visible = true;
                checkedListBox1.Visible = false;
                labelAdultos.Visible = true;
                labelInfantes.Visible = true;
                labelMenores.Visible = true;
                textBoxAdultos.Visible = true;
                textBoxMenores.Visible = true;
                textBoxInfantes.Visible = true;
                buttonBuscar.Visible = false;
                buttonAlojamiento.Visible = true;
                Lblinfo.Text = "";

            }
            string CiudadSeleccion = textBoxOrigen.Text;
            string CapacidadSeleccion = textBoxDestino.Text;
            DateTime FechaSeleccion = dateTimePickerFecha.Value;

            //Vuelo vuelo = BBDD.TraerVueloPorOrigen(CiudadSeleccion, CapacidadSeleccion, FechaSeleccion);
        }

        private bool ValidarSeleccionAlojamiento()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(textBoxOrigen.Text))
            {
                labelErrorOrigen.Text = "La ciudad no puede estar vacía.";
                valido = false;
            }
            if (string.IsNullOrEmpty(dateTimePickerFecha.Value.ToString()))
            {
                labelErrorFecha.Text = "La Fecha no puede estar vacía.";
                valido = false;
            }

            if (!valido) { return valido; }
            //Terminar de ver por que no ingresa a la validacion de los datos vuelo
            //if (string.IsNullOrEmpty(textBoxDestino.Text))
            //{
            //    labelErrorOrigen.Text = "La ciudad no se encuentra registrada.";
            //    valido = false;
            //}
            //if (!string.Equals(textBoxDestino.Text, this.vuelos.destino))
            if (!alojamientos.Any(x => x.codigoCiudad == textBoxDestino.Text))
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

        private void buttonAlojamiento_Click(object sender, EventArgs e)
        {
            int adultos = Convert.ToInt32(textBoxAdultos.Text);
            int menores = Convert.ToInt32(textBoxMenores.Text);
            int infantes = Convert.ToInt32(textBoxInfantes.Text);


            this.alojamientos = BBDD.TraerAlojamientoFiltrado(textBoxOrigen.Text, adultos, menores, infantes, dateTimePickerFecha.Value);
            this.checkedListBox1.Items.Clear();
            checkedListBox1.Visible = true;
            foreach (var item in this.alojamientos)
            {
                string itemText = $"Alojamiento:{item.idAlojamientos},Fecha:{dateTimePickerFecha.Value.ToString("dd/MM/yyyy")},Habitacion:{item.alojamientoDispobiles[0].nombreHabitacion},Tarifa:{item.alojamientoDispobiles[0].tarifaHabitacion}";

                this.checkedListBox1.Items.Add(itemText);
            }
        }

        private void Reservar_Click(object sender, EventArgs e)
        {
            Confirmar.Visible = true;
            if (Vuelo.Checked)
            {


                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        ItemVuelo item = new ItemVuelo();
                        item.Datos = checkedListBox1.Items[i].ToString();
                        int pasajeros = 0;
                        
                        string[] datos = checkedListBox1.Items[i].ToString().Split(",");
                        string[] datos2 = datos[5].Split(":");
                        string[] datosvuelo = datos[0].Split(":");
                        string[] datosclase = datos[1].Split(":");
                        string[] datospasajero = datos[2].Split(":");
                        pasajeros = Convert.ToInt32(datos2[1]);                        
                        for (int j = 0; j < pasajeros; j++)
                        {
                            Pasajero p = new Pasajero();
                            item.Pasajeros.Add(p);
                        }

                        items.Add(item);
                    }
                }
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        ItemAlojamiento itemA = new ItemAlojamiento();
                        itemA.Datos = checkedListBox1.Items[i].ToString();
                        itemsAlojamiento.Add(itemA);
                    }

                }
            }


            DialogResult resultado = MessageBox.Show("¿Deseas agregar otro producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                checkedListBox1.Items.Clear();
                LblOrigen.Visible = false;
                LblDestino.Visible = false;
                LblFecha.Visible = false;
                textBoxOrigen.Visible = false;
                dateTimePickerFecha.Visible = false;
                textBoxDestino.Visible = false;
                buttonBuscar.Visible = false;
                buttonAlojamiento.Visible = false;
                labelAdultos.Visible = false;
                labelInfantes.Visible = false;
                labelMenores.Visible = false;
                textBoxAdultos.Visible = false;
                textBoxMenores.Visible = false;
                textBoxInfantes.Visible = false;
                checkedListBox1.Visible = false;
                Confirmar.Visible = false;
                Vuelo.Checked = false;
                Alojamientos.Checked = false;
                LimpiarMensaje();
                LimpiarText();
                Lblinfo.Text = "";

            }
            else
            {
                this.Hide();
                DatosCliente pantalla7 = new DatosCliente(items, itemsAlojamiento);
                pantalla7.Show();
            }
        }
    }
}
