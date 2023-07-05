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
            this.components = new System.ComponentModel.Container();
            this.btn_SeleccionarJugadorUno = new System.Windows.Forms.Button();
            this.btn_JugadorDos = new System.Windows.Forms.Button();
            this.btn_CrearSala = new System.Windows.Forms.Button();
            this.btn_MostrarSala = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dtg_Jugadores = new System.Windows.Forms.DataGridView();
            this.rtb_Sala = new System.Windows.Forms.RichTextBox();
            this.lbl_JugadorUno = new System.Windows.Forms.Label();
            this.lbl_JugadorDos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Jugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SeleccionarJugadorUno
            // 
            this.btn_SeleccionarJugadorUno.BackColor = System.Drawing.Color.White;
            this.btn_SeleccionarJugadorUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_SeleccionarJugadorUno.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SeleccionarJugadorUno.ForeColor = System.Drawing.Color.Black;
            this.btn_SeleccionarJugadorUno.Location = new System.Drawing.Point(13, 237);
            this.btn_SeleccionarJugadorUno.Name = "btn_SeleccionarJugadorUno";
            this.btn_SeleccionarJugadorUno.Size = new System.Drawing.Size(118, 23);
            this.btn_SeleccionarJugadorUno.TabIndex = 0;
            this.btn_SeleccionarJugadorUno.Text = "JUGADOR UNO";
            this.btn_SeleccionarJugadorUno.UseVisualStyleBackColor = false;
            this.btn_SeleccionarJugadorUno.Click += new System.EventHandler(this.btn_SeleccionarJugadorUno_Click);
            // 
            // btn_JugadorDos
            // 
            this.btn_JugadorDos.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_JugadorDos.ForeColor = System.Drawing.Color.Black;
            this.btn_JugadorDos.Location = new System.Drawing.Point(13, 266);
            this.btn_JugadorDos.Name = "btn_JugadorDos";
            this.btn_JugadorDos.Size = new System.Drawing.Size(118, 23);
            this.btn_JugadorDos.TabIndex = 1;
            this.btn_JugadorDos.Text = "JUGADOR DOS";
            this.btn_JugadorDos.UseVisualStyleBackColor = true;
            this.btn_JugadorDos.Click += new System.EventHandler(this.btn_JugadorDos_Click);
            // 
            // btn_CrearSala
            // 
            this.btn_CrearSala.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CrearSala.ForeColor = System.Drawing.Color.Black;
            this.btn_CrearSala.Location = new System.Drawing.Point(13, 387);
            this.btn_CrearSala.Name = "btn_CrearSala";
            this.btn_CrearSala.Size = new System.Drawing.Size(118, 23);
            this.btn_CrearSala.TabIndex = 2;
            this.btn_CrearSala.Text = "CREAR SALA";
            this.btn_CrearSala.UseVisualStyleBackColor = true;
            this.btn_CrearSala.Click += new System.EventHandler(this.btn_CrearSala_Click);
            // 
            // btn_MostrarSala
            // 
            this.btn_MostrarSala.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MostrarSala.ForeColor = System.Drawing.Color.Black;
            this.btn_MostrarSala.Location = new System.Drawing.Point(13, 358);
            this.btn_MostrarSala.Name = "btn_MostrarSala";
            this.btn_MostrarSala.Size = new System.Drawing.Size(118, 23);
            this.btn_MostrarSala.TabIndex = 3;
            this.btn_MostrarSala.Text = "MOSTRAR SALA";
            this.btn_MostrarSala.UseVisualStyleBackColor = true;
            this.btn_MostrarSala.Click += new System.EventHandler(this.btn_MostrarSala_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(669, 387);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dtg_Jugadores
            // 
            this.dtg_Jugadores.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Jugadores.Location = new System.Drawing.Point(13, 71);
            this.dtg_Jugadores.Name = "dtg_Jugadores";
            this.dtg_Jugadores.RowTemplate.Height = 25;
            this.dtg_Jugadores.Size = new System.Drawing.Size(731, 150);
            this.dtg_Jugadores.TabIndex = 5;
            // 
            // rtb_Sala
            // 
            this.rtb_Sala.BackColor = System.Drawing.Color.White;
            this.rtb_Sala.Location = new System.Drawing.Point(211, 238);
            this.rtb_Sala.Name = "rtb_Sala";
            this.rtb_Sala.Size = new System.Drawing.Size(371, 172);
            this.rtb_Sala.TabIndex = 6;
            this.rtb_Sala.Text = "";
            // 
            // lbl_JugadorUno
            // 
            this.lbl_JugadorUno.AutoSize = true;
            this.lbl_JugadorUno.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_JugadorUno.ForeColor = System.Drawing.Color.White;
            this.lbl_JugadorUno.Location = new System.Drawing.Point(588, 241);
            this.lbl_JugadorUno.Name = "lbl_JugadorUno";
            this.lbl_JugadorUno.Size = new System.Drawing.Size(10, 16);
            this.lbl_JugadorUno.TabIndex = 7;
            this.lbl_JugadorUno.Text = ".";
            // 
            // lbl_JugadorDos
            // 
            this.lbl_JugadorDos.AutoSize = true;
            this.lbl_JugadorDos.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_JugadorDos.ForeColor = System.Drawing.Color.White;
            this.lbl_JugadorDos.Location = new System.Drawing.Point(588, 286);
            this.lbl_JugadorDos.Name = "lbl_JugadorDos";
            this.lbl_JugadorDos.Size = new System.Drawing.Size(10, 16);
            this.lbl_JugadorDos.TabIndex = 8;
            this.lbl_JugadorDos.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = ".";
            // 
            // CrearSalasDeJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(756, 423);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}