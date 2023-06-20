namespace UI
{
    partial class MenuPrincipalTruco
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
            this.btn_CrearSala = new System.Windows.Forms.Button();
            this.btn_MostrarSalas = new System.Windows.Forms.Button();
            this.btn_RegistrarJugador = new System.Windows.Forms.Button();
            this.btn_MostrarEstaditicas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CrearSala
            // 
            this.btn_CrearSala.Location = new System.Drawing.Point(38, 36);
            this.btn_CrearSala.Name = "btn_CrearSala";
            this.btn_CrearSala.Size = new System.Drawing.Size(149, 23);
            this.btn_CrearSala.TabIndex = 0;
            this.btn_CrearSala.Text = "CREAR SALA";
            this.btn_CrearSala.UseVisualStyleBackColor = true;
            this.btn_CrearSala.Click += new System.EventHandler(this.btn_CrearSala_Click);
            // 
            // btn_MostrarSalas
            // 
            this.btn_MostrarSalas.Location = new System.Drawing.Point(38, 78);
            this.btn_MostrarSalas.Name = "btn_MostrarSalas";
            this.btn_MostrarSalas.Size = new System.Drawing.Size(149, 23);
            this.btn_MostrarSalas.TabIndex = 1;
            this.btn_MostrarSalas.Text = "MOSTRAR SALAS";
            this.btn_MostrarSalas.UseVisualStyleBackColor = true;
            this.btn_MostrarSalas.Click += new System.EventHandler(this.btn_MostrarSalas_Click);
            // 
            // btn_RegistrarJugador
            // 
            this.btn_RegistrarJugador.Location = new System.Drawing.Point(38, 116);
            this.btn_RegistrarJugador.Name = "btn_RegistrarJugador";
            this.btn_RegistrarJugador.Size = new System.Drawing.Size(149, 23);
            this.btn_RegistrarJugador.TabIndex = 2;
            this.btn_RegistrarJugador.Text = "REGISTRAR JUGADOR";
            this.btn_RegistrarJugador.UseVisualStyleBackColor = true;
            this.btn_RegistrarJugador.Click += new System.EventHandler(this.btn_RegistrarJugador_Click);
            // 
            // btn_MostrarEstaditicas
            // 
            this.btn_MostrarEstaditicas.Location = new System.Drawing.Point(38, 159);
            this.btn_MostrarEstaditicas.Name = "btn_MostrarEstaditicas";
            this.btn_MostrarEstaditicas.Size = new System.Drawing.Size(149, 23);
            this.btn_MostrarEstaditicas.TabIndex = 3;
            this.btn_MostrarEstaditicas.Text = "MOSTRAR ESTADISTICAS";
            this.btn_MostrarEstaditicas.UseVisualStyleBackColor = true;
            this.btn_MostrarEstaditicas.Click += new System.EventHandler(this.btn_MostrarEstaditicas_Click);
            // 
            // MenuPrincipalTruco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 211);
            this.Controls.Add(this.btn_MostrarEstaditicas);
            this.Controls.Add(this.btn_RegistrarJugador);
            this.Controls.Add(this.btn_MostrarSalas);
            this.Controls.Add(this.btn_CrearSala);
            this.Name = "MenuPrincipalTruco";
            this.Text = "MenuPrincipalTruco";
            this.Load += new System.EventHandler(this.MenuPrincipalTruco_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CrearSala;
        private System.Windows.Forms.Button btn_MostrarSalas;
        private System.Windows.Forms.Button btn_RegistrarJugador;
        private System.Windows.Forms.Button btn_MostrarEstaditicas;
    }
}