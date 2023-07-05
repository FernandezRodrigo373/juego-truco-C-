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
            this.components = new System.ComponentModel.Container();
            this.btn_HistorialDePartidas = new System.Windows.Forms.Button();
            this.btn_JugadoresConMasPartidas = new System.Windows.Forms.Button();
            this.btn_JugadoresConMasVictorias = new System.Windows.Forms.Button();
            this.btn_JugadoresSinPartidas = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dtg_Datos = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_HistorialDePartidas
            // 
            this.btn_HistorialDePartidas.BackColor = System.Drawing.Color.White;
            this.btn_HistorialDePartidas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_HistorialDePartidas.Location = new System.Drawing.Point(266, 257);
            this.btn_HistorialDePartidas.Name = "btn_HistorialDePartidas";
            this.btn_HistorialDePartidas.Size = new System.Drawing.Size(248, 42);
            this.btn_HistorialDePartidas.TabIndex = 0;
            this.btn_HistorialDePartidas.Text = "HISTORIAL DE PARTIDAS";
            this.btn_HistorialDePartidas.UseVisualStyleBackColor = false;
            this.btn_HistorialDePartidas.Click += new System.EventHandler(this.btn_HistorialDePartidas_Click);
            // 
            // btn_JugadoresConMasPartidas
            // 
            this.btn_JugadoresConMasPartidas.BackColor = System.Drawing.Color.White;
            this.btn_JugadoresConMasPartidas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_JugadoresConMasPartidas.Location = new System.Drawing.Point(12, 209);
            this.btn_JugadoresConMasPartidas.Name = "btn_JugadoresConMasPartidas";
            this.btn_JugadoresConMasPartidas.Size = new System.Drawing.Size(248, 42);
            this.btn_JugadoresConMasPartidas.TabIndex = 1;
            this.btn_JugadoresConMasPartidas.Text = "JUGADORES CON MAS PARTIDAS";
            this.btn_JugadoresConMasPartidas.UseVisualStyleBackColor = false;
            this.btn_JugadoresConMasPartidas.Click += new System.EventHandler(this.btn_JugadoresConMasPartidas_Click);
            // 
            // btn_JugadoresConMasVictorias
            // 
            this.btn_JugadoresConMasVictorias.BackColor = System.Drawing.Color.White;
            this.btn_JugadoresConMasVictorias.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_JugadoresConMasVictorias.Location = new System.Drawing.Point(11, 257);
            this.btn_JugadoresConMasVictorias.Name = "btn_JugadoresConMasVictorias";
            this.btn_JugadoresConMasVictorias.Size = new System.Drawing.Size(248, 42);
            this.btn_JugadoresConMasVictorias.TabIndex = 2;
            this.btn_JugadoresConMasVictorias.Text = "JUGADORES CON MAS PARTIDAS GANADAS";
            this.btn_JugadoresConMasVictorias.UseVisualStyleBackColor = false;
            this.btn_JugadoresConMasVictorias.Click += new System.EventHandler(this.btn_JugadoresConMasVictorias_Click);
            // 
            // btn_JugadoresSinPartidas
            // 
            this.btn_JugadoresSinPartidas.BackColor = System.Drawing.Color.White;
            this.btn_JugadoresSinPartidas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_JugadoresSinPartidas.Location = new System.Drawing.Point(266, 209);
            this.btn_JugadoresSinPartidas.Name = "btn_JugadoresSinPartidas";
            this.btn_JugadoresSinPartidas.Size = new System.Drawing.Size(248, 42);
            this.btn_JugadoresSinPartidas.TabIndex = 3;
            this.btn_JugadoresSinPartidas.Text = "JUGADORES SIN PARTIDAS";
            this.btn_JugadoresSinPartidas.UseVisualStyleBackColor = false;
            this.btn_JugadoresSinPartidas.Click += new System.EventHandler(this.btn_JugadoresSinPartidas_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.White;
            this.btn_Salir.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(439, 328);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dtg_Datos
            // 
            this.dtg_Datos.AllowUserToOrderColumns = true;
            this.dtg_Datos.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Datos.Location = new System.Drawing.Point(11, 53);
            this.dtg_Datos.Name = "dtg_Datos";
            this.dtg_Datos.RowTemplate.Height = 25;
            this.dtg_Datos.Size = new System.Drawing.Size(500, 150);
            this.dtg_Datos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = ".";
            // 
            // MenuEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(523, 364);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_Datos);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_JugadoresSinPartidas);
            this.Controls.Add(this.btn_JugadoresConMasVictorias);
            this.Controls.Add(this.btn_JugadoresConMasPartidas);
            this.Controls.Add(this.btn_HistorialDePartidas);
            this.Name = "MenuEstadisticas";
            this.Text = "MenuEstadisticas";
            this.Load += new System.EventHandler(this.MenuEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HistorialDePartidas;
        private System.Windows.Forms.Button btn_JugadoresConMasPartidas;
        private System.Windows.Forms.Button btn_JugadoresConMasVictorias;
        private System.Windows.Forms.Button btn_JugadoresSinPartidas;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dtg_Datos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}