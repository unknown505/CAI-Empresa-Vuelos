
namespace CAI_Empresa_Vuelos
{
    partial class Pantalla3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Alojamientos = new System.Windows.Forms.RadioButton();
            this.Vuelo = new System.Windows.Forms.RadioButton();
            this.LblOrigen = new System.Windows.Forms.Label();
            this.LblDestino = new System.Windows.Forms.Label();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.Lblinfo = new System.Windows.Forms.Label();
            this.checkListBoxDatos = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione producto";
            // 
            // Alojamientos
            // 
            this.Alojamientos.AutoSize = true;
            this.Alojamientos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Alojamientos.Location = new System.Drawing.Point(194, 107);
            this.Alojamientos.Name = "Alojamientos";
            this.Alojamientos.Size = new System.Drawing.Size(119, 25);
            this.Alojamientos.TabIndex = 2;
            this.Alojamientos.TabStop = true;
            this.Alojamientos.Text = "Alojamientos";
            this.Alojamientos.UseVisualStyleBackColor = true;
            // 
            // Vuelo
            // 
            this.Vuelo.AutoSize = true;
            this.Vuelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vuelo.Location = new System.Drawing.Point(471, 107);
            this.Vuelo.Name = "Vuelo";
            this.Vuelo.Size = new System.Drawing.Size(75, 25);
            this.Vuelo.TabIndex = 3;
            this.Vuelo.TabStop = true;
            this.Vuelo.Text = "Vuelos";
            this.Vuelo.UseVisualStyleBackColor = true;
            // 
            // LblOrigen
            // 
            this.LblOrigen.AutoSize = true;
            this.LblOrigen.Location = new System.Drawing.Point(16, 154);
            this.LblOrigen.Name = "LblOrigen";
            this.LblOrigen.Size = new System.Drawing.Size(43, 15);
            this.LblOrigen.TabIndex = 4;
            this.LblOrigen.Text = "Origen";
            this.LblOrigen.Visible = false;
            // 
            // LblDestino
            // 
            this.LblDestino.AutoSize = true;
            this.LblDestino.Location = new System.Drawing.Point(229, 152);
            this.LblDestino.Name = "LblDestino";
            this.LblDestino.Size = new System.Drawing.Size(47, 15);
            this.LblDestino.TabIndex = 5;
            this.LblDestino.Text = "Destino";
            this.LblDestino.Visible = false;
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(79, 151);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOrigen.TabIndex = 6;
            this.comboBoxOrigen.Visible = false;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(291, 149);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDestino.TabIndex = 7;
            this.comboBoxDestino.Visible = false;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(437, 152);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(72, 15);
            this.LblFecha.TabIndex = 8;
            this.LblFecha.Text = "Fecha Salida";
            this.LblFecha.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(524, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 23);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(685, 149);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(68, 24);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Visible = false;
            // 
            // Lblinfo
            // 
            this.Lblinfo.AutoSize = true;
            this.Lblinfo.Location = new System.Drawing.Point(28, 187);
            this.Lblinfo.Name = "Lblinfo";
            this.Lblinfo.Size = new System.Drawing.Size(0, 15);
            this.Lblinfo.TabIndex = 12;
            // 
            // checkListBoxDatos
            // 
            this.checkListBoxDatos.FormattingEnabled = true;
            this.checkListBoxDatos.Location = new System.Drawing.Point(16, 214);
            this.checkListBoxDatos.Name = "checkListBoxDatos";
            this.checkListBoxDatos.Size = new System.Drawing.Size(737, 166);
            this.checkListBoxDatos.TabIndex = 13;
            // 
            // Pantalla3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkListBoxDatos);
            this.Controls.Add(this.Lblinfo);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.LblDestino);
            this.Controls.Add(this.LblOrigen);
            this.Controls.Add(this.Vuelo);
            this.Controls.Add(this.Alojamientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla3";
            this.Text = "Pantalla3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Alojamientos;
        private System.Windows.Forms.RadioButton Vuelo;
        private System.Windows.Forms.Label LblOrigen;
        private System.Windows.Forms.Label LblDestino;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label Lblinfo;
        private System.Windows.Forms.CheckedListBox checkListBoxDatos;
    }
}