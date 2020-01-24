namespace harjoitusTyoRistinolla
{
    partial class MenuIkkuna
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
            this.btnPelaa = new System.Windows.Forms.Button();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblSyntymaaika = new System.Windows.Forms.Label();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbSyntymaaika = new System.Windows.Forms.TextBox();
            this.lblKetaVastaan = new System.Windows.Forms.Label();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnAI = new System.Windows.Forms.Button();
            this.checkBoxLocal = new System.Windows.Forms.CheckBox();
            this.checkBoxAI = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPelaa
            // 
            this.btnPelaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPelaa.Location = new System.Drawing.Point(637, 68);
            this.btnPelaa.Name = "btnPelaa";
            this.btnPelaa.Size = new System.Drawing.Size(100, 36);
            this.btnPelaa.TabIndex = 0;
            this.btnPelaa.Text = "Pelaa";
            this.btnPelaa.UseVisualStyleBackColor = true;
            this.btnPelaa.Click += new System.EventHandler(this.btnPelaa_Click);
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Location = new System.Drawing.Point(55, 101);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(68, 13);
            this.lblEtunimi.TabIndex = 1;
            this.lblEtunimi.Text = "Anna etunimi";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(55, 149);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(76, 13);
            this.lblSukunimi.TabIndex = 2;
            this.lblSukunimi.Text = "Anna sukunimi";
            // 
            // lblSyntymaaika
            // 
            this.lblSyntymaaika.AutoSize = true;
            this.lblSyntymaaika.Location = new System.Drawing.Point(55, 193);
            this.lblSyntymaaika.Name = "lblSyntymaaika";
            this.lblSyntymaaika.Size = new System.Drawing.Size(93, 13);
            this.lblSyntymaaika.TabIndex = 3;
            this.lblSyntymaaika.Text = "Anna syntymäaika";
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(180, 101);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(154, 20);
            this.tbEtunimi.TabIndex = 4;
            this.tbEtunimi.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimi_Validating);
            this.tbEtunimi.Validated += new System.EventHandler(this.tbEtunimi_Validated);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(180, 149);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(154, 20);
            this.tbSukunimi.TabIndex = 5;
            this.tbSukunimi.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimi_Validating);
            this.tbSukunimi.Validated += new System.EventHandler(this.tbEtunimi_Validated);
            // 
            // tbSyntymaaika
            // 
            this.tbSyntymaaika.Location = new System.Drawing.Point(180, 193);
            this.tbSyntymaaika.Name = "tbSyntymaaika";
            this.tbSyntymaaika.Size = new System.Drawing.Size(154, 20);
            this.tbSyntymaaika.TabIndex = 6;
            this.tbSyntymaaika.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimi_Validating);
            this.tbSyntymaaika.Validated += new System.EventHandler(this.tbEtunimi_Validated);
            // 
            // lblKetaVastaan
            // 
            this.lblKetaVastaan.AutoSize = true;
            this.lblKetaVastaan.Location = new System.Drawing.Point(177, 254);
            this.lblKetaVastaan.Name = "lblKetaVastaan";
            this.lblKetaVastaan.Size = new System.Drawing.Size(76, 13);
            this.lblKetaVastaan.TabIndex = 7;
            this.lblKetaVastaan.Text = "Ketä vastaan?";
            // 
            // btnLocal
            // 
            this.btnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocal.Location = new System.Drawing.Point(71, 300);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(77, 76);
            this.btnLocal.TabIndex = 8;
            this.btnLocal.Text = "LOCAL";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnAI
            // 
            this.btnAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAI.Location = new System.Drawing.Point(268, 300);
            this.btnAI.Name = "btnAI";
            this.btnAI.Size = new System.Drawing.Size(77, 76);
            this.btnAI.TabIndex = 9;
            this.btnAI.Text = "AI";
            this.btnAI.UseVisualStyleBackColor = true;
            this.btnAI.Click += new System.EventHandler(this.btnAI_Click);
            // 
            // checkBoxLocal
            // 
            this.checkBoxLocal.AutoSize = true;
            this.checkBoxLocal.Location = new System.Drawing.Point(97, 277);
            this.checkBoxLocal.Name = "checkBoxLocal";
            this.checkBoxLocal.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLocal.TabIndex = 10;
            this.checkBoxLocal.UseVisualStyleBackColor = true;
            // 
            // checkBoxAI
            // 
            this.checkBoxAI.AutoSize = true;
            this.checkBoxAI.Location = new System.Drawing.Point(301, 277);
            this.checkBoxAI.Name = "checkBoxAI";
            this.checkBoxAI.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAI.TabIndex = 11;
            this.checkBoxAI.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MenuIkkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxAI);
            this.Controls.Add(this.checkBoxLocal);
            this.Controls.Add(this.btnAI);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.lblKetaVastaan);
            this.Controls.Add(this.tbSyntymaaika);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.lblSyntymaaika);
            this.Controls.Add(this.lblSukunimi);
            this.Controls.Add(this.lblEtunimi);
            this.Controls.Add(this.btnPelaa);
            this.MinimumSize = new System.Drawing.Size(808, 477);
            this.Name = "MenuIkkuna";
            this.Text = "MenuIkkuna";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPelaa;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblSyntymaaika;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbSyntymaaika;
        private System.Windows.Forms.Label lblKetaVastaan;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnAI;
        private System.Windows.Forms.CheckBox checkBoxLocal;
        private System.Windows.Forms.CheckBox checkBoxAI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}