namespace UI
{
    partial class MenuEstadisticas
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
            this.btn_HistorialDePartidas = new System.Windows.Forms.Button();
            this.btn_JugadoresConMasPartidas = new System.Windows.Forms.Button();
            this.btn_JugadoresConMasVictorias = new System.Windows.Forms.Button();
            this.btn_JugadoresSinPartidas = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dtg_Datos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_HistorialDePartidas
            // 
            this.btn_HistorialDePartidas.Location = new System.Drawing.Point(12, 271);
            this.btn_HistorialDePartidas.Name = "btn_HistorialDePartidas";
            this.btn_HistorialDePartidas.Size = new System.Drawing.Size(248, 23);
            this.btn_HistorialDePartidas.TabIndex = 0;
            this.btn_HistorialDePartidas.Text = "HISTORIAL DE PARTIDAS";
            this.btn_HistorialDePartidas.UseVisualStyleBackColor = true;
            this.btn_HistorialDePartidas.Click += new System.EventHandler(this.btn_HistorialDePartidas_Click);
            // 
            // btn_JugadoresConMasPartidas
            // 
            this.btn_JugadoresConMasPartidas.Location = new System.Drawing.Point(12, 184);
            this.btn_JugadoresConMasPartidas.Name = "btn_JugadoresConMasPartidas";
            this.btn_JugadoresConMasPartidas.Size = new System.Drawing.Size(248, 23);
            this.btn_JugadoresConMasPartidas.TabIndex = 1;
            this.btn_JugadoresConMasPartidas.Text = "JUGADORES CON MAS PARTIDAS";
            this.btn_JugadoresConMasPartidas.UseVisualStyleBackColor = true;
            this.btn_JugadoresConMasPartidas.Click += new System.EventHandler(this.btn_JugadoresConMasPartidas_Click);
            // 
            // btn_JugadoresConMasVictorias
            // 
            this.btn_JugadoresConMasVictorias.Location = new System.Drawing.Point(12, 213);
            this.btn_JugadoresConMasVictorias.Name = "btn_JugadoresConMasVictorias";
            this.btn_JugadoresConMasVictorias.Size = new System.Drawing.Size(248, 23);
            this.btn_JugadoresConMasVictorias.TabIndex = 2;
            this.btn_JugadoresConMasVictorias.Text = "JUGADORES CON MAS PARTIDAS GANADAS";
            this.btn_JugadoresConMasVictorias.UseVisualStyleBackColor = true;
            this.btn_JugadoresConMasVictorias.Click += new System.EventHandler(this.btn_JugadoresConMasVictorias_Click);
            // 
            // btn_JugadoresSinPartidas
            // 
            this.btn_JugadoresSinPartidas.Location = new System.Drawing.Point(12, 242);
            this.btn_JugadoresSinPartidas.Name = "btn_JugadoresSinPartidas";
            this.btn_JugadoresSinPartidas.Size = new System.Drawing.Size(248, 23);
            this.btn_JugadoresSinPartidas.TabIndex = 3;
            this.btn_JugadoresSinPartidas.Text = "JUGADORES SIN PARTIDAS";
            this.btn_JugadoresSinPartidas.UseVisualStyleBackColor = true;
            this.btn_JugadoresSinPartidas.Click += new System.EventHandler(this.btn_JugadoresSinPartidas_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(437, 271);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dtg_Datos
            // 
            this.dtg_Datos.AllowUserToOrderColumns = true;
            this.dtg_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Datos.Location = new System.Drawing.Point(12, 12);
            this.dtg_Datos.Name = "dtg_Datos";
            this.dtg_Datos.RowTemplate.Height = 25;
            this.dtg_Datos.Size = new System.Drawing.Size(500, 150);
            this.dtg_Datos.TabIndex = 5;
            // 
            // MenuEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 312);
            this.Controls.Add(this.dtg_Datos);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_JugadoresSinPartidas);
            this.Controls.Add(this.btn_JugadoresConMasVictorias);
            this.Controls.Add(this.btn_JugadoresConMasPartidas);
            this.Controls.Add(this.btn_HistorialDePartidas);
            this.Name = "MenuEstadisticas";
            this.Text = "MenuEstadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HistorialDePartidas;
        private System.Windows.Forms.Button btn_JugadoresConMasPartidas;
        private System.Windows.Forms.Button btn_JugadoresConMasVictorias;
        private System.Windows.Forms.Button btn_JugadoresSinPartidas;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dtg_Datos;
    }
}