
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.Lblinfo = new System.Windows.Forms.Label();
            this.comboBoxFecha = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonVolver = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(16, 66);
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
            this.Alojamientos.Location = new System.Drawing.Point(194, 107);
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
            this.Vuelo.Location = new System.Drawing.Point(471, 107);
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
            this.LblOrigen.Location = new System.Drawing.Point(16, 154);
            this.LblOrigen.Name = "LblOrigen";
            this.LblOrigen.Size = new System.Drawing.Size(0, 15);
            this.LblOrigen.TabIndex = 4;
            this.LblOrigen.Visible = false;
            // 
            // LblDestino
            // 
            this.LblDestino.AutoSize = true;
            this.LblDestino.Location = new System.Drawing.Point(194, 154);
            this.LblDestino.Name = "LblDestino";
            this.LblDestino.Size = new System.Drawing.Size(0, 15);
            this.LblDestino.TabIndex = 5;
            this.LblDestino.Visible = false;
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(67, 150);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOrigen.TabIndex = 6;
            this.comboBoxOrigen.Visible = false;
            this.comboBoxOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigen_SelectedIndexChanged);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(247, 150);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDestino.TabIndex = 7;
            this.comboBoxDestino.Visible = false;
            this.comboBoxDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestino_SelectedIndexChanged);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(389, 153);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(41, 15);
            this.LblFecha.TabIndex = 8;
            this.LblFecha.Text = "Fecha ";
            this.LblFecha.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(685, 148);
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
            this.Lblinfo.Location = new System.Drawing.Point(28, 187);
            this.Lblinfo.Name = "Lblinfo";
            this.Lblinfo.Size = new System.Drawing.Size(0, 15);
            this.Lblinfo.TabIndex = 12;
            // 
            // comboBoxFecha
            // 
            this.comboBoxFecha.FormattingEnabled = true;
            this.comboBoxFecha.Location = new System.Drawing.Point(452, 150);
            this.comboBoxFecha.Name = "comboBoxFecha";
            this.comboBoxFecha.Size = new System.Drawing.Size(182, 23);
            this.comboBoxFecha.TabIndex = 14;
            this.comboBoxFecha.Visible = false;
            this.comboBoxFecha.SelectedIndexChanged += new System.EventHandler(this.comboBoxFecha_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(28, 205);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(606, 166);
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
            this.buttonVolver.Visible = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Pantalla3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBoxFecha);
            this.Controls.Add(this.Lblinfo);
            this.Controls.Add(this.buttonBuscar);
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
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label Lblinfo;
        private System.Windows.Forms.ComboBox comboBoxFecha;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonVolver;
    }
}