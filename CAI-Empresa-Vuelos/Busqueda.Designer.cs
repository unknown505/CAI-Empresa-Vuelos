
namespace CAI_Empresa_Vuelos
{
    partial class Busqueda
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
            this.LblFecha = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.Lblinfo = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.labelErrorOrigen = new System.Windows.Forms.Label();
            this.labelErrorDestino = new System.Windows.Forms.Label();
            this.labelErrorFecha = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.Confirmar = new System.Windows.Forms.Button();
            this.buttonAlojamiento = new System.Windows.Forms.Button();
            this.labelAdultos = new System.Windows.Forms.Label();
            this.labelMenores = new System.Windows.Forms.Label();
            this.labelInfantes = new System.Windows.Forms.Label();
            this.textBoxAdultos = new System.Windows.Forms.TextBox();
            this.textBoxMenores = new System.Windows.Forms.TextBox();
            this.textBoxInfantes = new System.Windows.Forms.TextBox();
            this.Destino = new System.Windows.Forms.Label();
            this.Origen = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione producto";
            // 
            // Alojamientos
            // 
            this.Alojamientos.AutoSize = true;
            this.Alojamientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Alojamientos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Alojamientos.Location = new System.Drawing.Point(175, 72);
            this.Alojamientos.Name = "Alojamientos";
            this.Alojamientos.Size = new System.Drawing.Size(119, 25);
            this.Alojamientos.TabIndex = 2;
            this.Alojamientos.Text = "Alojamientos";
            this.Alojamientos.UseVisualStyleBackColor = true;
            this.Alojamientos.CheckedChanged += new System.EventHandler(this.Alojamientos_CheckedChanged);
            // 
            // Vuelo
            // 
            this.Vuelo.AutoSize = true;
            this.Vuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vuelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vuelo.Location = new System.Drawing.Point(452, 72);
            this.Vuelo.Name = "Vuelo";
            this.Vuelo.Size = new System.Drawing.Size(75, 25);
            this.Vuelo.TabIndex = 3;
            this.Vuelo.Text = "Vuelos";
            this.Vuelo.UseVisualStyleBackColor = true;
            this.Vuelo.CheckedChanged += new System.EventHandler(this.Vuelo_CheckedChanged);
            // 
            // LblOrigen
            // 
            this.LblOrigen.AutoSize = true;
            this.LblOrigen.Location = new System.Drawing.Point(16, 116);
            this.LblOrigen.Name = "LblOrigen";
            this.LblOrigen.Size = new System.Drawing.Size(0, 15);
            this.LblOrigen.TabIndex = 4;
            this.LblOrigen.Visible = false;
            // 
            // LblDestino
            // 
            this.LblDestino.AutoSize = true;
            this.LblDestino.Location = new System.Drawing.Point(200, 116);
            this.LblDestino.Name = "LblDestino";
            this.LblDestino.Size = new System.Drawing.Size(0, 15);
            this.LblDestino.TabIndex = 5;
            this.LblDestino.Visible = false;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(391, 116);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(41, 15);
            this.LblFecha.TabIndex = 8;
            this.LblFecha.Text = "Fecha ";
            this.LblFecha.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(652, 111);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(68, 24);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Visible = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // Lblinfo
            // 
            this.Lblinfo.AutoSize = true;
            this.Lblinfo.Location = new System.Drawing.Point(29, 184);
            this.Lblinfo.Name = "Lblinfo";
            this.Lblinfo.Size = new System.Drawing.Size(0, 15);
            this.Lblinfo.TabIndex = 12;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(29, 211);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(606, 76);
            this.checkedListBox1.TabIndex = 15;
            this.checkedListBox1.Visible = false;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(16, 397);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(90, 28);
            this.buttonVolver.TabIndex = 16;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Location = new System.Drawing.Point(67, 112);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(127, 23);
            this.textBoxOrigen.TabIndex = 17;
            this.textBoxOrigen.Visible = false;
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Location = new System.Drawing.Point(247, 113);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(127, 23);
            this.textBoxDestino.TabIndex = 18;
            this.textBoxDestino.Visible = false;
            // 
            // labelErrorOrigen
            // 
            this.labelErrorOrigen.AutoSize = true;
            this.labelErrorOrigen.ForeColor = System.Drawing.Color.Red;
            this.labelErrorOrigen.Location = new System.Drawing.Point(67, 138);
            this.labelErrorOrigen.Name = "labelErrorOrigen";
            this.labelErrorOrigen.Size = new System.Drawing.Size(0, 15);
            this.labelErrorOrigen.TabIndex = 20;
            // 
            // labelErrorDestino
            // 
            this.labelErrorDestino.AutoSize = true;
            this.labelErrorDestino.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDestino.Location = new System.Drawing.Point(247, 139);
            this.labelErrorDestino.Name = "labelErrorDestino";
            this.labelErrorDestino.Size = new System.Drawing.Size(0, 15);
            this.labelErrorDestino.TabIndex = 21;
            // 
            // labelErrorFecha
            // 
            this.labelErrorFecha.AutoSize = true;
            this.labelErrorFecha.ForeColor = System.Drawing.Color.Red;
            this.labelErrorFecha.Location = new System.Drawing.Point(452, 139);
            this.labelErrorFecha.Name = "labelErrorFecha";
            this.labelErrorFecha.Size = new System.Drawing.Size(0, 15);
            this.labelErrorFecha.TabIndex = 22;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(452, 112);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(107, 23);
            this.dateTimePickerFecha.TabIndex = 23;
            this.dateTimePickerFecha.Visible = false;
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(687, 397);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(83, 28);
            this.Confirmar.TabIndex = 30;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Visible = false;
            this.Confirmar.Click += new System.EventHandler(this.Reservar_Click);
            // 
            // buttonAlojamiento
            // 
            this.buttonAlojamiento.Location = new System.Drawing.Point(652, 111);
            this.buttonAlojamiento.Name = "buttonAlojamiento";
            this.buttonAlojamiento.Size = new System.Drawing.Size(68, 24);
            this.buttonAlojamiento.TabIndex = 35;
            this.buttonAlojamiento.Text = "Buscar";
            this.buttonAlojamiento.UseVisualStyleBackColor = true;
            this.buttonAlojamiento.Visible = false;
            this.buttonAlojamiento.Click += new System.EventHandler(this.buttonAlojamiento_Click);
            // 
            // labelAdultos
            // 
            this.labelAdultos.AutoSize = true;
            this.labelAdultos.Location = new System.Drawing.Point(79, 159);
            this.labelAdultos.Name = "labelAdultos";
            this.labelAdultos.Size = new System.Drawing.Size(48, 15);
            this.labelAdultos.TabIndex = 36;
            this.labelAdultos.Text = "Adultos";
            this.labelAdultos.Visible = false;
            // 
            // labelMenores
            // 
            this.labelMenores.AutoSize = true;
            this.labelMenores.Location = new System.Drawing.Point(285, 161);
            this.labelMenores.Name = "labelMenores";
            this.labelMenores.Size = new System.Drawing.Size(53, 15);
            this.labelMenores.TabIndex = 37;
            this.labelMenores.Text = "Menores";
            this.labelMenores.Visible = false;
            // 
            // labelInfantes
            // 
            this.labelInfantes.AutoSize = true;
            this.labelInfantes.Location = new System.Drawing.Point(476, 161);
            this.labelInfantes.Name = "labelInfantes";
            this.labelInfantes.Size = new System.Drawing.Size(49, 15);
            this.labelInfantes.TabIndex = 38;
            this.labelInfantes.Text = "Infantes";
            this.labelInfantes.Visible = false;
            // 
            // textBoxAdultos
            // 
            this.textBoxAdultos.Location = new System.Drawing.Point(132, 156);
            this.textBoxAdultos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAdultos.Name = "textBoxAdultos";
            this.textBoxAdultos.Size = new System.Drawing.Size(110, 23);
            this.textBoxAdultos.TabIndex = 39;
            this.textBoxAdultos.Visible = false;
            // 
            // textBoxMenores
            // 
            this.textBoxMenores.Location = new System.Drawing.Point(341, 158);
            this.textBoxMenores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMenores.Name = "textBoxMenores";
            this.textBoxMenores.Size = new System.Drawing.Size(110, 23);
            this.textBoxMenores.TabIndex = 40;
            this.textBoxMenores.Visible = false;
            // 
            // textBoxInfantes
            // 
            this.textBoxInfantes.Location = new System.Drawing.Point(532, 158);
            this.textBoxInfantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInfantes.Name = "textBoxInfantes";
            this.textBoxInfantes.Size = new System.Drawing.Size(110, 23);
            this.textBoxInfantes.TabIndex = 41;
            this.textBoxInfantes.Visible = false;
            // 
            // Destino
            // 
            this.Destino.AutoSize = true;
            this.Destino.Location = new System.Drawing.Point(200, 116);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(47, 15);
            this.Destino.TabIndex = 42;
            this.Destino.Text = "Destino";
            this.Destino.Visible = false;
            // 
            // Origen
            // 
            this.Origen.AutoSize = true;
            this.Origen.Location = new System.Drawing.Point(16, 116);
            this.Origen.Name = "Origen";
            this.Origen.Size = new System.Drawing.Size(43, 15);
            this.Origen.TabIndex = 43;
            this.Origen.Text = "Origen";
            this.Origen.Visible = false;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Origen);
            this.Controls.Add(this.Destino);
            this.Controls.Add(this.textBoxInfantes);
            this.Controls.Add(this.textBoxMenores);
            this.Controls.Add(this.textBoxAdultos);
            this.Controls.Add(this.labelInfantes);
            this.Controls.Add(this.labelMenores);
            this.Controls.Add(this.labelAdultos);
            this.Controls.Add(this.buttonAlojamiento);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.labelErrorFecha);
            this.Controls.Add(this.labelErrorDestino);
            this.Controls.Add(this.labelErrorOrigen);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.textBoxOrigen);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Lblinfo);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblDestino);
            this.Controls.Add(this.LblOrigen);
            this.Controls.Add(this.Vuelo);
            this.Controls.Add(this.Alojamientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
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
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label Lblinfo;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.Label labelErrorOrigen;
        private System.Windows.Forms.Label labelErrorDestino;
        private System.Windows.Forms.Label labelErrorFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button Reservar;
        private System.Windows.Forms.Button buttonAlojamiento;
        private System.Windows.Forms.Label labelAdultos;
        private System.Windows.Forms.Label labelMenores;
        private System.Windows.Forms.Label labelInfantes;
        private System.Windows.Forms.TextBox textBoxAdultos;
        private System.Windows.Forms.TextBox textBoxMenores;
        private System.Windows.Forms.TextBox textBoxInfantes;
        private System.Windows.Forms.Label Destino;
        private System.Windows.Forms.Label Origen;
        private System.Windows.Forms.Button Confirmar;
    }
}