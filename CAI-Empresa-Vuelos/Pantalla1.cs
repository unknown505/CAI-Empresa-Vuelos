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
        private Usuario user { get; set; }

        public Pantalla1()
        {
            InitializeComponent();
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
            // Tomamr los datos ingresados 
            string usuarioIngreso = UsuarioIngreso.Text;
            string constraseñaIngreso = ContraseñaIngreso.Text;
            //Traer los datos ingresados en la BBDD
            this.user = BBDD.TraerClientePorDato(usuarioIngreso);
            //Comenzar las validaciones

            //Ingreso Valido
            if (ValidarInicioSesion())
            {
                //Oculta esta pantalla y pasa a la pantalla 2
                this.Hide();
                Pantalla2 pantalla2 = new Pantalla2();
                pantalla2.Show();
            }
            //Ingresos no validos
            else
            {
                usuarioErrorLbl.Show();
                contraseñaErrorLbl.Show();
            }

        }

        private bool ValidarInicioSesion()
        {
            bool valido = true;

            //Validar datos vacios o null en usuairo
            if (string.IsNullOrEmpty(UsuarioIngreso.Text))
            {
                usuarioErrorLbl.Text = "El usuario no puede estar vacío.";
                valido = false;
            }
            //Validar datos vacios o null en contraseña
            if (string.IsNullOrEmpty(ContraseñaIngreso.Text))
            {
                contraseñaErrorLbl.Text = "La contraseña no puede estar vacía.";
                valido = false;
            }

            if (!valido) { return valido; }
            //Validar Que el usuario estre en la lista
            if (this.user == null)
            {
                usuarioErrorLbl.Text = "El usuario no se encuentra registrado.";
                valido = false;
            }
            //Validar que el usuario registrado corresponda con la contraseña asignada
            else
            {
                //if (!string.Equals(ContraseñaIngreso.Text, this.user.contraseña, StringComparison.Ordinal))
                //{
                //    contraseñaErrorLbl.Text = "La contraseña es incorrecta.";
                //    valido = false;
                //}
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
