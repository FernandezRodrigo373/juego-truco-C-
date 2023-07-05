namespace UI
{
    partial class SalasDeJuego
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_MostrarSalas = new System.Windows.Forms.Button();
            this.dtg_Salas = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Salas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.White;
            this.btn_Salir.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Black;
            this.btn_Salir.Location = new System.Drawing.Point(530, 196);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 44);
            this.btn_Salir.TabIndex = 0;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_MostrarSalas
            // 
            this.btn_MostrarSalas.BackColor = System.Drawing.Color.White;
            this.btn_MostrarSalas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MostrarSalas.ForeColor = System.Drawing.Color.Black;
            this.btn_MostrarSalas.Location = new System.Drawing.Point(12, 196);
            this.btn_MostrarSalas.Name = "btn_MostrarSalas";
            this.btn_MostrarSalas.Size = new System.Drawing.Size(75, 44);
            this.btn_MostrarSalas.TabIndex = 1;
            this.btn_MostrarSalas.Text = "MOSTRAR SALAS";
            this.btn_MostrarSalas.UseVisualStyleBackColor = false;
            this.btn_MostrarSalas.Click += new System.EventHandler(this.btn_MostrarSalas_Click);
            // 
            // dtg_Salas
            // 
            this.dtg_Salas.AllowUserToOrderColumns = true;
            this.dtg_Salas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_Salas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Salas.BackgroundColor = System.Drawing.Color.Brown;
            this.dtg_Salas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Salas.Location = new System.Drawing.Point(12, 40);
            this.dtg_Salas.Name = "dtg_Salas";
            this.dtg_Salas.RowTemplate.Height = 25;
            this.dtg_Salas.Size = new System.Drawing.Size(593, 150);
            this.dtg_Salas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = ".";
            // 
            // SalasDeJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_Salas);
            this.Controls.Add(this.btn_MostrarSalas);
            this.Controls.Add(this.btn_Salir);
            this.Name = "SalasDeJuego";
            this.Text = "SalasDeJuego";
            this.Load += new System.EventHandler(this.SalasDeJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Salas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_MostrarSalas;
        private System.Windows.Forms.DataGridView dtg_Salas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}