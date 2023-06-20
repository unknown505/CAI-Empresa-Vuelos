
namespace CAI_Empresa_Vuelos
{
    partial class Pantalla1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.UsuarioIngreso = new System.Windows.Forms.TextBox();
            this.ContraseñaIngreso = new System.Windows.Forms.TextBox();
            this.buttonIngreso = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.usuarioErrorLbl = new System.Windows.Forms.Label();
            this.contraseñaErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.Location = new System.Drawing.Point(262, 51);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(289, 48);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Nombre Agencia";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.Location = new System.Drawing.Point(154, 161);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(79, 28);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContraseña.Location = new System.Drawing.Point(154, 235);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(110, 28);
            this.labelContraseña.TabIndex = 2;
            this.labelContraseña.Text = "Contraseña";
            // 
            // UsuarioIngreso
            // 
            this.UsuarioIngreso.Location = new System.Drawing.Point(326, 169);
            this.UsuarioIngreso.Name = "UsuarioIngreso";
            this.UsuarioIngreso.Size = new System.Drawing.Size(289, 23);
            this.UsuarioIngreso.TabIndex = 3;
            // 
            // ContraseñaIngreso
            // 
            this.ContraseñaIngreso.Location = new System.Drawing.Point(326, 235);
            this.ContraseñaIngreso.Name = "ContraseñaIngreso";
            this.ContraseñaIngreso.Size = new System.Drawing.Size(289, 23);
            this.ContraseñaIngreso.TabIndex = 4;
            // 
            // buttonIngreso
            // 
            this.buttonIngreso.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIngreso.Location = new System.Drawing.Point(457, 321);
            this.buttonIngreso.Name = "buttonIngreso";
            this.buttonIngreso.Size = new System.Drawing.Size(131, 49);
            this.buttonIngreso.TabIndex = 5;
            this.buttonIngreso.Text = "Ingresar";
            this.buttonIngreso.UseVisualStyleBackColor = true;
            this.buttonIngreso.Click += new System.EventHandler(this.buttonIngreso_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalir.Location = new System.Drawing.Point(224, 321);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(131, 50);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // usuarioErrorLbl
            // 
            this.usuarioErrorLbl.AutoSize = true;
            this.usuarioErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.usuarioErrorLbl.Location = new System.Drawing.Point(326, 195);
            this.usuarioErrorLbl.Name = "usuarioErrorLbl";
            this.usuarioErrorLbl.Size = new System.Drawing.Size(0, 15);
            this.usuarioErrorLbl.TabIndex = 7;
            // 
            // contraseñaErrorLbl
            // 
            this.contraseñaErrorLbl.AutoSize = true;
            this.contraseñaErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.contraseñaErrorLbl.Location = new System.Drawing.Point(326, 261);
            this.contraseñaErrorLbl.Name = "contraseñaErrorLbl";
            this.contraseñaErrorLbl.Size = new System.Drawing.Size(0, 15);
            this.contraseñaErrorLbl.TabIndex = 8;
            // 
            // Pantalla1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contraseñaErrorLbl);
            this.Controls.Add(this.usuarioErrorLbl);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonIngreso);
            this.Controls.Add(this.ContraseñaIngreso);
            this.Controls.Add(this.UsuarioIngreso);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.Titulo);
            this.Name = "Pantalla1";
            this.Text = "Pantalla Login";
            this.Load += new System.EventHandler(this.Pantalla1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox UsuarioIngreso;
        private System.Windows.Forms.TextBox ContraseñaIngreso;
        private System.Windows.Forms.Button buttonIngreso;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label usuarioErrorLbl;
        private System.Windows.Forms.Label contraseñaErrorLbl;
    }
}

