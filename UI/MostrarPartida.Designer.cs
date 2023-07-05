namespace UI
{
    partial class MostrarPartida
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
            this.btn_TerminarPartida = new System.Windows.Forms.Button();
            this.btn_FinalizarProceso = new System.Windows.Forms.Button();
            this.btn_MostrarMarcador = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.rtb_Partida = new System.Windows.Forms.RichTextBox();
            this.lbl_JugadorUno = new System.Windows.Forms.Label();
            this.lbl_JugadorDos = new System.Windows.Forms.Label();
            this.lbl_PuntajeJugadorUno = new System.Windows.Forms.Label();
            this.lbl_PuntajeJugadorDos = new System.Windows.Forms.Label();
            this.TIEMPO = new System.Windows.Forms.Label();
            this.lbl_Tiempo = new System.Windows.Forms.Label();
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TerminarPartida
            // 
            this.btn_TerminarPartida.BackColor = System.Drawing.Color.White;
            this.btn_TerminarPartida.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_TerminarPartida.Location = new System.Drawing.Point(576, 173);
            this.btn_TerminarPartida.Name = "btn_TerminarPartida";
            this.btn_TerminarPartida.Size = new System.Drawing.Size(146, 45);
            this.btn_TerminarPartida.TabIndex = 0;
            this.btn_TerminarPartida.Text = "CANCELAR PARTIDA";
            this.btn_TerminarPartida.UseVisualStyleBackColor = false;
            this.btn_TerminarPartida.Click += new System.EventHandler(this.btn_TerminarPartida_Click);
            // 
            // btn_FinalizarProceso
            // 
            this.btn_FinalizarProceso.BackColor = System.Drawing.Color.White;
            this.btn_FinalizarProceso.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_FinalizarProceso.Location = new System.Drawing.Point(576, 70);
            this.btn_FinalizarProceso.Name = "btn_FinalizarProceso";
            this.btn_FinalizarProceso.Size = new System.Drawing.Size(146, 37);
            this.btn_FinalizarProceso.TabIndex = 2;
            this.btn_FinalizarProceso.Text = "FINALIZAR";
            this.btn_FinalizarProceso.UseVisualStyleBackColor = false;
            this.btn_FinalizarProceso.Click += new System.EventHandler(this.btn_FinalizarProceso_Click);
            // 
            // btn_MostrarMarcador
            // 
            this.btn_MostrarMarcador.BackColor = System.Drawing.Color.White;
            this.btn_MostrarMarcador.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MostrarMarcador.Location = new System.Drawing.Point(576, 113);
            this.btn_MostrarMarcador.Name = "btn_MostrarMarcador";
            this.btn_MostrarMarcador.Size = new System.Drawing.Size(146, 54);
            this.btn_MostrarMarcador.TabIndex = 3;
            this.btn_MostrarMarcador.Text = "MOSTRAR MARCADOR";
            this.btn_MostrarMarcador.UseVisualStyleBackColor = false;
            this.btn_MostrarMarcador.Click += new System.EventHandler(this.btn_MostrarMarcador_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.White;
            this.btn_Salir.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(647, 410);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 31);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // rtb_Partida
            // 
            this.rtb_Partida.BackColor = System.Drawing.Color.White;
            this.rtb_Partida.Location = new System.Drawing.Point(12, 70);
            this.rtb_Partida.Name = "rtb_Partida";
            this.rtb_Partida.Size = new System.Drawing.Size(558, 277);
            this.rtb_Partida.TabIndex = 5;
            this.rtb_Partida.Text = "";
            // 
            // lbl_JugadorUno
            // 
            this.lbl_JugadorUno.AutoSize = true;
            this.lbl_JugadorUno.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_JugadorUno.Location = new System.Drawing.Point(7, 31);
            this.lbl_JugadorUno.Name = "lbl_JugadorUno";
            this.lbl_JugadorUno.Size = new System.Drawing.Size(10, 16);
            this.lbl_JugadorUno.TabIndex = 6;
            this.lbl_JugadorUno.Text = ".";
            // 
            // lbl_JugadorDos
            // 
            this.lbl_JugadorDos.AutoSize = true;
            this.lbl_JugadorDos.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_JugadorDos.Location = new System.Drawing.Point(444, 31);
            this.lbl_JugadorDos.Name = "lbl_JugadorDos";
            this.lbl_JugadorDos.Size = new System.Drawing.Size(10, 16);
            this.lbl_JugadorDos.TabIndex = 7;
            this.lbl_JugadorDos.Text = ".";
            // 
            // lbl_PuntajeJugadorUno
            // 
            this.lbl_PuntajeJugadorUno.AutoSize = true;
            this.lbl_PuntajeJugadorUno.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PuntajeJugadorUno.Location = new System.Drawing.Point(7, 57);
            this.lbl_PuntajeJugadorUno.Name = "lbl_PuntajeJugadorUno";
            this.lbl_PuntajeJugadorUno.Size = new System.Drawing.Size(10, 16);
            this.lbl_PuntajeJugadorUno.TabIndex = 8;
            this.lbl_PuntajeJugadorUno.Text = ".";
            // 
            // lbl_PuntajeJugadorDos
            // 
            this.lbl_PuntajeJugadorDos.AutoSize = true;
            this.lbl_PuntajeJugadorDos.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PuntajeJugadorDos.Location = new System.Drawing.Point(444, 56);
            this.lbl_PuntajeJugadorDos.Name = "lbl_PuntajeJugadorDos";
            this.lbl_PuntajeJugadorDos.Size = new System.Drawing.Size(10, 16);
            this.lbl_PuntajeJugadorDos.TabIndex = 9;
            this.lbl_PuntajeJugadorDos.Text = ".";
            // 
            // TIEMPO
            // 
            this.TIEMPO.AutoSize = true;
            this.TIEMPO.Location = new System.Drawing.Point(205, 33);
            this.TIEMPO.Name = "TIEMPO";
            this.TIEMPO.Size = new System.Drawing.Size(49, 15);
            this.TIEMPO.TabIndex = 10;
            this.TIEMPO.Text = "TIEMPO";
            // 
            // lbl_Tiempo
            // 
            this.lbl_Tiempo.AutoSize = true;
            this.lbl_Tiempo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tiempo.Location = new System.Drawing.Point(208, 56);
            this.lbl_Tiempo.Name = "lbl_Tiempo";
            this.lbl_Tiempo.Size = new System.Drawing.Size(10, 16);
            this.lbl_Tiempo.TabIndex = 11;
            this.lbl_Tiempo.Text = ".";
            // 
            // gb_Datos
            // 
            this.gb_Datos.BackColor = System.Drawing.Color.Plum;
            this.gb_Datos.Controls.Add(this.lbl_JugadorDos);
            this.gb_Datos.Controls.Add(this.lbl_Tiempo);
            this.gb_Datos.Controls.Add(this.lbl_JugadorUno);
            this.gb_Datos.Controls.Add(this.TIEMPO);
            this.gb_Datos.Controls.Add(this.lbl_PuntajeJugadorUno);
            this.gb_Datos.Controls.Add(this.lbl_PuntajeJugadorDos);
            this.gb_Datos.Location = new System.Drawing.Point(12, 353);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Size = new System.Drawing.Size(558, 89);
            this.gb_Datos.TabIndex = 12;
            this.gb_Datos.TabStop = false;
            this.gb_Datos.Text = "DATOS PARTIDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = ".";
            // 
            // MostrarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(734, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_Datos);
            this.Controls.Add(this.rtb_Partida);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_MostrarMarcador);
            this.Controls.Add(this.btn_FinalizarProceso);
            this.Controls.Add(this.btn_TerminarPartida);
            this.Name = "MostrarPartida";
            this.Text = "MostrarPartida";
            this.Load += new System.EventHandler(this.MostrarPartida_Load);
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TerminarPartida;
        private System.Windows.Forms.Button btn_FinalizarProceso;
        private System.Windows.Forms.Button btn_MostrarMarcador;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.RichTextBox rtb_Partida;
        private System.Windows.Forms.Label lbl_JugadorUno;
        private System.Windows.Forms.Label lbl_JugadorDos;
        private System.Windows.Forms.Label lbl_PuntajeJugadorUno;
        private System.Windows.Forms.Label lbl_PuntajeJugadorDos;
        private System.Windows.Forms.Label TIEMPO;
        private System.Windows.Forms.Label lbl_Tiempo;
        private System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}