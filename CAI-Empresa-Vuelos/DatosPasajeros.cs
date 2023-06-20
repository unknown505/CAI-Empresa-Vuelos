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
using static CAI_Empresa_Vuelos.Entidades.ItemVuelo;
using static CAI_Empresa_Vuelos.Entidades.Pasajero;
using static CAI_Empresa_Vuelos.Entidades.ItemAlojamiento;

namespace CAI_Empresa_Vuelos
{
    public partial class DatosPasajeros : Form
    {
        private int idreserva { get; set;}
        private List<Reserva> reservas { get; set;}

        public DatosPasajeros(int idreserva)
        {
            InitializeComponent();
            this.idreserva = idreserva;
            this.reservas = new List<Reserva>();
            string[] fileLines2 = File.ReadAllLines("..\\..\\..\\Datos\\Reservas.json");
            string json2 = string.Join("", fileLines2);
            this.reservas = JsonConvert.DeserializeObject<List<Reserva>>(json2);
            if (this.reservas == null)
            {
                this.reservas = new List<Reserva>();
            }
            CargarPasajeros();
        }

        private void CargarPasajeros()
        {
            int topMargin = 20;
            
            foreach (Reserva reserva in this.reservas)
            {
                if (reserva.Id == idreserva)
                {
                    int idunico = 1;
                    foreach (ItemVuelo item in reserva.ItemsVuelo)
                    {
                        Label lblDatos = new Label();
                        lblDatos.Text = item.Datos;
                        lblDatos.Width = 800;
                        lblDatos.Location = new Point(0, topMargin);
                        panelContenedor.Controls.Add(lblDatos);
                        topMargin += 40;
                        foreach (Pasajero pasajero in item.Pasajeros)
                        {
                            Label lblNombre = new Label();
                            lblNombre.Text = "Nombre:";
                            lblNombre.Location = new Point(0, topMargin);

                            TextBox txtNombre = new TextBox();
                            txtNombre.Name = "txtNombre" + idunico;
                            txtNombre.Text = "";
                            txtNombre.Location = new Point(100, topMargin);

                            Label lblApellido = new Label();
                            lblApellido.Text = "Apellido:";
                            lblApellido.Location = new Point(200, topMargin);

                            TextBox txtApellido = new TextBox();
                            txtApellido.Name = "txtApellido" + idunico;
                            txtApellido.Text = "";
                            txtApellido.Location = new Point(300, topMargin);

                            Label lblDni = new Label();
                            lblDni.Text = "Dni:";
                            lblDni.Location = new Point(400, topMargin);

                            TextBox txtDni = new TextBox();
                            txtDni.Name = "txtDni" + idunico;
                            txtDni.Text = "";
                            txtDni.Location = new Point(500, topMargin);

                            Label lblEdad = new Label();
                            lblEdad.Text = "Edad:";
                            lblEdad.Location = new Point(600, topMargin);

                            TextBox txtEdad = new TextBox();
                            txtEdad.Name = "txtEdad" + idunico;
                            txtEdad.Text = "";
                            txtEdad.Location = new Point(700, topMargin);

                            panelContenedor.Controls.Add(lblNombre);
                            panelContenedor.Controls.Add(txtNombre);
                            panelContenedor.Controls.Add(lblApellido);
                            panelContenedor.Controls.Add(txtApellido);
                            panelContenedor.Controls.Add(lblDni);
                            panelContenedor.Controls.Add(txtDni);
                            panelContenedor.Controls.Add(lblEdad);
                            panelContenedor.Controls.Add(txtEdad);

                            idunico++;
                            topMargin += 50;
                        }
                    }
                }
            }
            
        }

        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            foreach (Reserva reserva in this.reservas)
            {
                if (reserva.Id == idreserva)
                {
                    int idunico = 1;
                    foreach (ItemVuelo item in reserva.ItemsVuelo)
                    {
                        foreach (Pasajero pasajero in item.Pasajeros)
                        {
                            string textBoxNombre = "txtNombre" + idunico.ToString();
                            TextBox textBoxNomb = panelContenedor.Controls.Find(textBoxNombre, true).FirstOrDefault() as TextBox;
                            pasajero.nombre = textBoxNomb.Text;

                            string textBoxApellido = "txtapellido" + idunico.ToString();
                            TextBox textBoxApe = panelContenedor.Controls.Find(textBoxApellido, true).FirstOrDefault() as TextBox;
                            pasajero.apellido = textBoxApe.Text;


                            string textBoxDni = "txtDni" + idunico.ToString();
                            TextBox textBoxDn = panelContenedor.Controls.Find(textBoxDni, true).FirstOrDefault() as TextBox;
                            pasajero.dni = Convert.ToInt32(textBoxDn.Text);

                            string textBoxEdad = "txtEdad" + idunico.ToString();
                            TextBox textBoxEd = panelContenedor.Controls.Find(textBoxEdad, true).FirstOrDefault() as TextBox;
                            pasajero.edad = Convert.ToInt32(textBoxEd.Text);

                            idunico++;
                        }
                    }
                }
            }
            string rutaArchivo = "..\\..\\..\\Datos\\Reservas.json";
            string jsonActualizado = JsonConvert.SerializeObject(reservas, Formatting.Indented);
            File.WriteAllText(rutaArchivo, jsonActualizado);

            MessageBox.Show("Se ha generado la Reserva nro. :" +  idreserva, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();


        }
    }
}
