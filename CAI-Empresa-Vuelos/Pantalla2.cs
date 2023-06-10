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
    public partial class Pantalla2 : Form
    {
        public Pantalla2()
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
            Pantalla3 pantalal3 = new Pantalla3();
            pantalal3.Show();
            this.Hide();
        }

        private void buttonEdeReserva_Click(object sender, EventArgs e)
        {
            Pantalla5 pantalal5 = new Pantalla5();
            pantalal5.Show();
            this.Hide();
        }
    }
}
