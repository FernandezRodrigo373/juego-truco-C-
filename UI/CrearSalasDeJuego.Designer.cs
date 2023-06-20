namespace UI
{
    partial class CrearSalasDeJuego
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
            this.btn_SeleccionarJugadorUno = new System.Windows.Forms.Button();
            this.btn_JugadorDos = new System.Windows.Forms.Button();
            this.btn_CrearSala = new System.Windows.Forms.Button();
            this.btn_MostrarSala = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dtg_Jugadores = new System.Windows.Forms.DataGridView();
            this.rtb_Sala = new System.Windows.Forms.RichTextBox();
            this.lbl_JugadorUno = new System.Windows.Forms.Label();
            this.lbl_JugadorDos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Jugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SeleccionarJugadorUno
            // 
            this.btn_SeleccionarJugadorUno.Location = new System.Drawing.Point(59, 227);
            this.btn_SeleccionarJugadorUno.Name = "btn_SeleccionarJugadorUno";
            this.btn_SeleccionarJugadorUno.Size = new System.Drawing.Size(118, 23);
            this.btn_SeleccionarJugadorUno.TabIndex = 0;
            this.btn_SeleccionarJugadorUno.Text = "JUGADOR UNO";
            this.btn_SeleccionarJugadorUno.UseVisualStyleBackColor = true;
            this.btn_SeleccionarJugadorUno.Click += new System.EventHandler(this.btn_SeleccionarJugadorUno_Click);
            // 
            // btn_JugadorDos
            // 
            this.btn_JugadorDos.Location = new System.Drawing.Point(59, 256);
            this.btn_JugadorDos.Name = "btn_JugadorDos";
            this.btn_JugadorDos.Size = new System.Drawing.Size(118, 23);
            this.btn_JugadorDos.TabIndex = 1;
            this.btn_JugadorDos.Text = "JUGADOR 2";
            this.btn_JugadorDos.UseVisualStyleBackColor = true;
            this.btn_JugadorDos.Click += new System.EventHandler(this.btn_JugadorDos_Click);
            // 
            // btn_CrearSala
            // 
            this.btn_CrearSala.Location = new System.Drawing.Point(59, 314);
            this.btn_CrearSala.Name = "btn_CrearSala";
            this.btn_CrearSala.Size = new System.Drawing.Size(118, 23);
            this.btn_CrearSala.TabIndex = 2;
            this.btn_CrearSala.Text = "CREAR SALA";
            this.btn_CrearSala.UseVisualStyleBackColor = true;
            this.btn_CrearSala.Click += new System.EventHandler(this.btn_CrearSala_Click);
            // 
            // btn_MostrarSala
            // 
            this.btn_MostrarSala.Location = new System.Drawing.Point(59, 285);
            this.btn_MostrarSala.Name = "btn_MostrarSala";
            this.btn_MostrarSala.Size = new System.Drawing.Size(118, 23);
            this.btn_MostrarSala.TabIndex = 3;
            this.btn_MostrarSala.Text = "MOSTRAR SALA";
            this.btn_MostrarSala.UseVisualStyleBackColor = true;
            this.btn_MostrarSala.Click += new System.EventHandler(this.btn_MostrarSala_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(668, 314);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dtg_Jugadores
            // 
            this.dtg_Jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Jugadores.Location = new System.Drawing.Point(12, 12);
            this.dtg_Jugadores.Name = "dtg_Jugadores";
            this.dtg_Jugadores.RowTemplate.Height = 25;
            this.dtg_Jugadores.Size = new System.Drawing.Size(731, 150);
            this.dtg_Jugadores.TabIndex = 5;
            // 
            // rtb_Sala
            // 
            this.rtb_Sala.Location = new System.Drawing.Point(214, 227);
            this.rtb_Sala.Name = "rtb_Sala";
            this.rtb_Sala.Size = new System.Drawing.Size(371, 110);
            this.rtb_Sala.TabIndex = 6;
            this.rtb_Sala.Text = "";
            // 
            // lbl_JugadorUno
            // 
            this.lbl_JugadorUno.AutoSize = true;
            this.lbl_JugadorUno.Location = new System.Drawing.Point(58, 369);
            this.lbl_JugadorUno.Name = "lbl_JugadorUno";
            this.lbl_JugadorUno.Size = new System.Drawing.Size(38, 15);
            this.lbl_JugadorUno.TabIndex = 7;
            this.lbl_JugadorUno.Text = "label1";
            // 
            // lbl_JugadorDos
            // 
            this.lbl_JugadorDos.AutoSize = true;
            this.lbl_JugadorDos.Location = new System.Drawing.Point(60, 406);
            this.lbl_JugadorDos.Name = "lbl_JugadorDos";
            this.lbl_JugadorDos.Size = new System.Drawing.Size(38, 15);
            this.lbl_JugadorDos.TabIndex = 8;
            this.lbl_JugadorDos.Text = "label2";
            // 
            // CrearSalasDeJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_JugadorDos);
            this.Controls.Add(this.lbl_JugadorUno);
            this.Controls.Add(this.rtb_Sala);
            this.Controls.Add(this.dtg_Jugadores);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_MostrarSala);
            this.Controls.Add(this.btn_CrearSala);
            this.Controls.Add(this.btn_JugadorDos);
            this.Controls.Add(this.btn_SeleccionarJugadorUno);
            this.Name = "CrearSalasDeJuego";
            this.Text = "CrearSalasDeJuego";
            this.Load += new System.EventHandler(this.CrearSalasDeJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Jugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SeleccionarJugadorUno;
        private System.Windows.Forms.Button btn_JugadorDos;
        private System.Windows.Forms.Button btn_CrearSala;
        private System.Windows.Forms.Button btn_MostrarSala;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dtg_Jugadores;
        private System.Windows.Forms.RichTextBox rtb_Sala;
        private System.Windows.Forms.Label lbl_JugadorUno;
        private System.Windows.Forms.Label lbl_JugadorDos;
    }
}