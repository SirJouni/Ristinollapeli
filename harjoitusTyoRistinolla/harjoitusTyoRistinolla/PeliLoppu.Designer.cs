namespace harjoitusTyoRistinolla
{
    partial class PeliLoppu
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
            this.lblIlmoitus = new System.Windows.Forms.Label();
            this.btnPalaaMenuun = new System.Windows.Forms.Button();
            this.btnPoistuPelista = new System.Windows.Forms.Button();
            this.btnPelaaUudestaan = new System.Windows.Forms.Button();
            this.lblVoitot = new System.Windows.Forms.Label();
            this.lblHaviot = new System.Windows.Forms.Label();
            this.lblTasapelit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIlmoitus
            // 
            this.lblIlmoitus.AutoSize = true;
            this.lblIlmoitus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIlmoitus.Location = new System.Drawing.Point(235, 54);
            this.lblIlmoitus.Name = "lblIlmoitus";
            this.lblIlmoitus.Size = new System.Drawing.Size(88, 26);
            this.lblIlmoitus.TabIndex = 0;
            this.lblIlmoitus.Text = "Ilmoitus";
            // 
            // btnPalaaMenuun
            // 
            this.btnPalaaMenuun.Location = new System.Drawing.Point(240, 233);
            this.btnPalaaMenuun.Name = "btnPalaaMenuun";
            this.btnPalaaMenuun.Size = new System.Drawing.Size(103, 62);
            this.btnPalaaMenuun.TabIndex = 1;
            this.btnPalaaMenuun.Text = "Palaa menuun";
            this.btnPalaaMenuun.UseVisualStyleBackColor = true;
            this.btnPalaaMenuun.Click += new System.EventHandler(this.btnPalaaMenuun_Click);
            // 
            // btnPoistuPelista
            // 
            this.btnPoistuPelista.Location = new System.Drawing.Point(75, 233);
            this.btnPoistuPelista.Name = "btnPoistuPelista";
            this.btnPoistuPelista.Size = new System.Drawing.Size(103, 62);
            this.btnPoistuPelista.TabIndex = 2;
            this.btnPoistuPelista.Text = "Poistu pelistä";
            this.btnPoistuPelista.UseVisualStyleBackColor = true;
            this.btnPoistuPelista.Click += new System.EventHandler(this.btnPoistuPelista_Click);
            // 
            // btnPelaaUudestaan
            // 
            this.btnPelaaUudestaan.Location = new System.Drawing.Point(404, 233);
            this.btnPelaaUudestaan.Name = "btnPelaaUudestaan";
            this.btnPelaaUudestaan.Size = new System.Drawing.Size(103, 62);
            this.btnPelaaUudestaan.TabIndex = 3;
            this.btnPelaaUudestaan.Text = "Pelaa uudestaan";
            this.btnPelaaUudestaan.UseVisualStyleBackColor = true;
            this.btnPelaaUudestaan.Click += new System.EventHandler(this.btnPelaaUudestaan_Click);
            // 
            // lblVoitot
            // 
            this.lblVoitot.AutoSize = true;
            this.lblVoitot.Location = new System.Drawing.Point(93, 150);
            this.lblVoitot.Name = "lblVoitot";
            this.lblVoitot.Size = new System.Drawing.Size(34, 13);
            this.lblVoitot.TabIndex = 4;
            this.lblVoitot.Text = "Voitot";
            // 
            // lblHaviot
            // 
            this.lblHaviot.AutoSize = true;
            this.lblHaviot.Location = new System.Drawing.Point(267, 150);
            this.lblHaviot.Name = "lblHaviot";
            this.lblHaviot.Size = new System.Drawing.Size(38, 13);
            this.lblHaviot.TabIndex = 5;
            this.lblHaviot.Text = "Häviöt";
            // 
            // lblTasapelit
            // 
            this.lblTasapelit.AutoSize = true;
            this.lblTasapelit.Location = new System.Drawing.Point(419, 150);
            this.lblTasapelit.Name = "lblTasapelit";
            this.lblTasapelit.Size = new System.Drawing.Size(50, 13);
            this.lblTasapelit.TabIndex = 6;
            this.lblTasapelit.Text = "Tasapelit";
            // 
            // PeliLoppu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 356);
            this.Controls.Add(this.lblTasapelit);
            this.Controls.Add(this.lblHaviot);
            this.Controls.Add(this.lblVoitot);
            this.Controls.Add(this.btnPelaaUudestaan);
            this.Controls.Add(this.btnPoistuPelista);
            this.Controls.Add(this.btnPalaaMenuun);
            this.Controls.Add(this.lblIlmoitus);
            this.MinimumSize = new System.Drawing.Size(603, 383);
            this.Name = "PeliLoppu";
            this.Text = "PeliLoppu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIlmoitus;
        private System.Windows.Forms.Button btnPalaaMenuun;
        private System.Windows.Forms.Button btnPoistuPelista;
        private System.Windows.Forms.Button btnPelaaUudestaan;
        private System.Windows.Forms.Label lblVoitot;
        private System.Windows.Forms.Label lblHaviot;
        private System.Windows.Forms.Label lblTasapelit;
    }
}