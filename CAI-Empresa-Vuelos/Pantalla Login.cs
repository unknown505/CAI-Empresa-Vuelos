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

namespace CAI_Empresa_Vuelos
{
    public partial class Pantalla1 : Form
    {
        //inicio un nuevo usuario para guardar los datos que ingresa para dar comienzo al login
        private Vendedor user { get; set; }

        public Pantalla1()
        {
            InitializeComponent();
            
            UsuarioIngreso.Text = "Vendedor";
            ContraseñaIngreso.Text = "12345";
        }

        private void Pantalla1_Load(object sender, EventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }
        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            LimpiarMensajesError();

            string usuarioIngreso = UsuarioIngreso.Text;
            string constraseñaIngreso = ContraseñaIngreso.Text;
            this.user = BBDD.TraerVendedorPorDato(usuarioIngreso);


            if (ValidarInicioSesion())
            {
                this.Hide();
                MenuPrincipal pantalla2 = new MenuPrincipal();
                pantalla2.Show();
            }
            else
            {
                usuarioErrorLbl.Show();
                contraseñaErrorLbl.Show();
            }

        }

        private bool ValidarInicioSesion()
        {
            bool valido = true;

            if (string.IsNullOrEmpty(UsuarioIngreso.Text))
            {
                usuarioErrorLbl.Text = "El usuario no puede estar vacio.";
                valido = false;
            }

            if (string.IsNullOrEmpty(ContraseñaIngreso.Text))
            {
                contraseñaErrorLbl.Text = "La contraseña no puede estar vacia.";
                valido = false;
            }

            if (!valido) { return valido; }

            if (this.user == null)
            {
                usuarioErrorLbl.Text = "El vendedor no se encuentra registrado.";
                valido = false;
            }
            else
            {
                if (!string.Equals(ContraseñaIngreso.Text, this.user.contrasena, StringComparison.Ordinal))
                {
                    contraseñaErrorLbl.Text = "La contraseña es incorrecta.";
                    valido = false;
                }
            }

            return valido;
        }

        //Borrar los datos del msj de error en ambos casos
        private void LimpiarMensajesError()
        {
            usuarioErrorLbl.Text = "";
            contraseñaErrorLbl.Text = "";
        }

        //Salir del sistema con el boton salir
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
