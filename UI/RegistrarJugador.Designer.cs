namespace UI
{
    partial class RegistrarJugador
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
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_NombreJugador = new System.Windows.Forms.TextBox();
            this.txb_Clave = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Clave = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.lbl_Jugador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(69, 258);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(206, 32);
            this.btn_Registrar.TabIndex = 0;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // txb_NombreJugador
            // 
            this.txb_NombreJugador.Location = new System.Drawing.Point(69, 129);
            this.txb_NombreJugador.Name = "txb_NombreJugador";
            this.txb_NombreJugador.Size = new System.Drawing.Size(206, 23);
            this.txb_NombreJugador.TabIndex = 4;
            // 
            // txb_Clave
            // 
            this.txb_Clave.Location = new System.Drawing.Point(69, 195);
            this.txb_Clave.Name = "txb_Clave";
            this.txb_Clave.Size = new System.Drawing.Size(206, 23);
            this.txb_Clave.TabIndex = 5;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(245, 339);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Clave
            // 
            this.lbl_Clave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Clave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Clave.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Clave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Clave.Location = new System.Drawing.Point(144, 170);
            this.lbl_Clave.Name = "lbl_Clave";
            this.lbl_Clave.Size = new System.Drawing.Size(46, 22);
            this.lbl_Clave.TabIndex = 16;
            this.lbl_Clave.Text = "CLAVE";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Usuario.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Usuario.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Usuario.Location = new System.Drawing.Point(133, 104);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(72, 22);
            this.lbl_Usuario.TabIndex = 15;
            this.lbl_Usuario.Text = "JUGADOR";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(55, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 64);
            this.label4.TabIndex = 17;
            this.label4.Text = "CeliTruco";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(12, 342);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(10, 15);
            this.lbl_Error.TabIndex = 18;
            this.lbl_Error.Text = ".";
            // 
            // lbl_Jugador
            // 
            this.lbl_Jugador.AutoSize = true;
            this.lbl_Jugador.Location = new System.Drawing.Point(75, 301);
            this.lbl_Jugador.Name = "lbl_Jugador";
            this.lbl_Jugador.Size = new System.Drawing.Size(10, 15);
            this.lbl_Jugador.TabIndex = 19;
            this.lbl_Jugador.Text = ".";
            // 
            // RegistrarJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 374);
            this.Controls.Add(this.lbl_Jugador);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Clave);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.txb_Clave);
            this.Controls.Add(this.txb_NombreJugador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Registrar);
            this.Name = "RegistrarJugador";
            this.Text = "RegistrarJugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_NombreJugador;
        private System.Windows.Forms.TextBox txb_Clave;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Clave;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Label lbl_Jugador;
    }
}