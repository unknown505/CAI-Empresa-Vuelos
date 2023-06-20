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
using static CAI_Empresa_Vuelos.Entidades.Cliente;
using static CAI_Empresa_Vuelos.Entidades.Reserva;
using static CAI_Empresa_Vuelos.Entidades.ItemVuelo;
using static CAI_Empresa_Vuelos.Entidades.ItemAlojamiento;

namespace CAI_Empresa_Vuelos
{
    partial class DatosCliente : Form
    {
        private int IdReserva { get; set; }
        private Cliente persona { get; set; }
        private List<ItemVuelo> itemReservas { get; set; }
        private List<ItemAlojamiento> itemAlojamientos { get; set; }
        private List<Reserva> reservas { get; set; }


        public DatosCliente(List<ItemVuelo> items, List<ItemAlojamiento> itemsAlojamiento)
        {
            InitializeComponent();
            persona = new Cliente();
            this.reservas = new List<Reserva>();
            string[] fileLines2 = File.ReadAllLines("..\\..\\..\\Datos\\Reservas.json");
            string json2 = string.Join("", fileLines2);
            this.reservas = JsonConvert.DeserializeObject<List<Reserva>>(json2);
            if (this.reservas == null)
            {
                this.reservas = new List<Reserva>();
            }
            this.itemReservas = new List<ItemVuelo>();
            this.itemReservas.AddRange(items);
            this.itemAlojamientos = new List<ItemAlojamiento>();
            this.itemAlojamientos.AddRange(itemsAlojamiento);
        }
        // el estado debería ser PRESUPUESTO, PRE-RESERVA, RESERVA.

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            GuardarClienteEnJSON();
            GuardarReservaEnJSON();

            this.Hide();
            ResumenPresupuesto pantalla6 = new ResumenPresupuesto(/*itemReservas, itemAlojamientos*/);
            pantalla6.Show();
        }

        private void GuardarClienteEnJSON()
        {
            Cliente persona = new Cliente();
            if (ValidarDatosCliente()) {
                persona.nombre = textBoxNombre.Text;
                persona.apellido = textBoxApellido.Text;
                persona.dni = int.Parse(textBoxDNI.Text);
                persona.numeroTelefono = textBoxTelefono.Text;
                persona.mail = textBoxEmail.Text;
                persona.fechaNac = dateTimePickerFechaNacimiento.Value; }
            else
            {
                labelNombre.Show();
                labelApellido.Show();
                labelDni.Show();
                labelEmail.Show();
                labelFechaNac.Show();
                labelTelefono.Show();
            }
            //persona.idreserva = this.IdReserva;


            string rutaArchivo = "..\\..\\..\\Datos\\Cliente.json"; // Especifica la ruta y el nombre del archivo JSON
            string jsonActual = File.ReadAllText(rutaArchivo);
            List<Cliente> personasActuales = JsonConvert.DeserializeObject<List<Cliente>>(jsonActual);
            if (personasActuales == null)
            {
                personasActuales = new List<Cliente>();
            }
            bool existe = false;
            foreach (Cliente person in personasActuales)
            {
                if (Convert.ToInt32(person.dni) == Convert.ToInt32(textBoxDNI.Text))
                {
                    existe = true;
                }
            }
            if(!existe)
            {
                personasActuales.Add(persona);
                string jsonActualizado = JsonConvert.SerializeObject(personasActuales, Formatting.Indented);
                File.WriteAllText(rutaArchivo, jsonActualizado);
            }
        }

        private bool ValidarDatosCliente()
        {
            bool v = false;
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                labelNombre.Text = "Ingrese un nombre";
                return v;
            }
            if (string.IsNullOrEmpty(textBoxApellido.Text))
            {
                labelApellido.Text = "Ingrese un Apellido";
                return v;
            }
            if (string.IsNullOrEmpty(textBoxTelefono.Text) || (int.Parse(textBoxTelefono.Text) < 9999999 && int.Parse(textBoxTelefono.Text) > 99999999))//Limito a que el numero de telefono sea al menos de 10 caracteres
            {
                labelTelefono.Text = "Ingrese una Nro. de Telefono";
                return v;
            }
            if (string.IsNullOrEmpty(textBoxDNI.Text)|| (int.Parse(textBoxDNI.Text) < 9999999 && int.Parse(textBoxDNI.Text) > 100000000))
            {
                labelDni.Text = "Ingrese un Nro. de DNI";
                return v;
            }
            else
            {
                return v = true;
            }
        }

        private void GuardarReservaEnJSON()
        {
            Reserva reserva = new Reserva();
            reserva.Id = this.reservas.Count + 1;
            reserva.Estado = "Presupuesto";
            reserva.ItemsVuelo = new List<ItemVuelo>();
            reserva.ItemsVuelo.AddRange(itemReservas);
            reserva.ItemsAlojamiento.AddRange(itemAlojamientos);
            reserva.Dni = int.Parse(textBoxDNI.Text);

            string rutaArchivo = "..\\..\\..\\Datos\\Reservas.json";
            string jsonActual = File.ReadAllText(rutaArchivo);
            List<Reserva> reservasActuales = JsonConvert.DeserializeObject<List<Reserva>>(jsonActual);
            if (reservasActuales == null)
            {
                reservasActuales = new List<Reserva>();
            }
            reservasActuales.Add(reserva);
            string jsonActualizado = JsonConvert.SerializeObject(reservasActuales, Formatting.Indented);
            File.WriteAllText(rutaArchivo, jsonActualizado);

            MessageBox.Show("Se ha generado el presupuesto número: " + reserva.Id + ".", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
