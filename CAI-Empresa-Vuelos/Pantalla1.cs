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
            usuarioErrorLbl.Text = UsuarioValidaciones.ValidarInicioSesionUsuario(UsuarioIngreso.Text, this.user);
            contraseñaErrorLbl.Text = UsuarioValidaciones.ValidarInicioSesionUsuario(UsuarioIngreso.Text, this.user);
            if(usuarioErrorLbl.Text == "" && contraseñaErrorLbl.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
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
