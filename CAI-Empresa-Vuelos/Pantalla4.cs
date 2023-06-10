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

namespace CAI_Empresa_Vuelos
{
    public partial class Pantalla4 : Form
    {
        private Persona persona {get; set;}

        public Pantalla4()
        {
            InitializeComponent();
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            persona.nombre = textBoxNombre.Text;
            persona.apellido = textBoxApellido.Text;
            persona.dni = int.Parse(textBoxDNI.Text);
            persona.numeroTelefono = textBoxTelefono.Text;
            persona.mail = textBoxEmail.Text;
            persona.fechaNac = dateTimePickerFechaNacimiento.Value;

            GuardarPersonaEnJSON(persona);

        }
        private void GuardarPersonaEnJSON(Persona persona)
        {
            string rutaArchivo = "ruta/al/archivo/persona.json"; // Especifica la ruta y el nombre del archivo JSON

            string jsonString = JsonConvert.SerializeObject(persona, Formatting.Indented);
            File.WriteAllText(rutaArchivo, jsonString);
        }

    }
}
