namespace CAI_Empresa_Vuelos
{
    partial class Pantalla7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.textBoxNombrePasajero = new System.Windows.Forms.TextBox();
            this.textBoxApellidoPasajero = new System.Windows.Forms.TextBox();
            this.textBoxDNIPasajero = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasajeros.Location = new System.Drawing.Point(35, 39);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(75, 21);
            this.lblPasajeros.TabIndex = 4;
            this.lblPasajeros.Text = "Pasajeros";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(35, 136);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Visible = false;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(35, 181);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(27, 15);
            this.lblDNI.TabIndex = 9;
            this.lblDNI.Text = "DNI";
            this.lblDNI.Visible = false;
            // 
            // textBoxNombrePasajero
            // 
            this.textBoxNombrePasajero.Location = new System.Drawing.Point(119, 81);
            this.textBoxNombrePasajero.Name = "textBoxNombrePasajero";
            this.textBoxNombrePasajero.Size = new System.Drawing.Size(100, 23);
            this.textBoxNombrePasajero.TabIndex = 13;
            // 
            // textBoxApellidoPasajero
            // 
            this.textBoxApellidoPasajero.Location = new System.Drawing.Point(119, 133);
            this.textBoxApellidoPasajero.Name = "textBoxApellidoPasajero";
            this.textBoxApellidoPasajero.Size = new System.Drawing.Size(100, 23);
            this.textBoxApellidoPasajero.TabIndex = 14;
            // 
            // textBoxDNIPasajero
            // 
            this.textBoxDNIPasajero.Location = new System.Drawing.Point(119, 181);
            this.textBoxDNIPasajero.Name = "textBoxDNIPasajero";
            this.textBoxDNIPasajero.Size = new System.Drawing.Size(100, 23);
            this.textBoxDNIPasajero.TabIndex = 15;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(648, 377);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 18;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            // 
            // Pantalla7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxDNIPasajero);
            this.Controls.Add(this.textBoxApellidoPasajero);
            this.Controls.Add(this.textBoxNombrePasajero);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPasajeros);
            this.Name = "Pantalla7";
            this.Text = "Pantalla7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasajeros;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox textBoxNombrePasajero;
        private System.Windows.Forms.TextBox textBoxApellidoPasajero;
        private System.Windows.Forms.TextBox textBoxDNIPasajero;
        private System.Windows.Forms.Button buttonConfirmar;
    }
}