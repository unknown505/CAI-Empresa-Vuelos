using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAI_Empresa_Vuelos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Pantalla1 pantalla1 = new Pantalla1();
            pantalla1.Show();
            this.Hide();
        }

        private void buttonReserva_Click(object sender, EventArgs e)
        {
            Busqueda pantalal3 = new Busqueda();
            pantalal3.Show();
            this.Hide();
        }

        private void buttonEdeReserva_Click(object sender, EventArgs e)
        {
            EstadoReserva pantalal5 = new EstadoReserva();
            pantalal5.Show();
            this.Hide();
        }

        private void buttonReclamos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No tiene acceso a esta sección.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
