namespace WindowsFormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPersonelGetir = new System.Windows.Forms.Button();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.lstPersonel = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelIsim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonelSoyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonelFirmaAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPersonelEMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonelUlkeAd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstPersonel);
            this.groupBox1.Location = new System.Drawing.Point(30, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Listesi";
            // 
            // btnPersonelGetir
            // 
            this.btnPersonelGetir.Location = new System.Drawing.Point(30, 363);
            this.btnPersonelGetir.Name = "btnPersonelGetir";
            this.btnPersonelGetir.Size = new System.Drawing.Size(798, 59);
            this.btnPersonelGetir.TabIndex = 1;
            this.btnPersonelGetir.Text = "PERSONEL GETİR";
            this.btnPersonelGetir.UseVisualStyleBackColor = true;
            this.btnPersonelGetir.Click += new System.EventHandler(this.btnPersonelGetir_Click);
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.Location = new System.Drawing.Point(30, 428);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(798, 59);
            this.btnPersonelKaydet.TabIndex = 1;
            this.btnPersonelKaydet.Text = "PERSONEL KAYDET";
            this.btnPersonelKaydet.UseVisualStyleBackColor = true;
            this.btnPersonelKaydet.Click += new System.EventHandler(this.btnPersonelKaydet_Click);
            // 
            // lstPersonel
            // 
            this.lstPersonel.FormattingEnabled = true;
            this.lstPersonel.ItemHeight = 16;
            this.lstPersonel.Location = new System.Drawing.Point(16, 33);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(340, 276);
            this.lstPersonel.TabIndex = 0;
            this.lstPersonel.DoubleClick += new System.EventHandler(this.lstPersonel_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPersonelEMail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPersonelUlkeAd);
            this.groupBox2.Controls.Add(this.txtPersonelFirmaAd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPersonelSoyisim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPersonelIsim);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPersonelID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(421, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 307);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Detay";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(126, 71);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(255, 22);
            this.txtPersonelID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "İsim: ";
            // 
            // txtPersonelIsim
            // 
            this.txtPersonelIsim.Location = new System.Drawing.Point(126, 99);
            this.txtPersonelIsim.Name = "txtPersonelIsim";
            this.txtPersonelIsim.Size = new System.Drawing.Size(255, 22);
            this.txtPersonelIsim.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyisim: ";
            // 
            // txtPersonelSoyisim
            // 
            this.txtPersonelSoyisim.Location = new System.Drawing.Point(126, 127);
            this.txtPersonelSoyisim.Name = "txtPersonelSoyisim";
            this.txtPersonelSoyisim.Size = new System.Drawing.Size(255, 22);
            this.txtPersonelSoyisim.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Firma Adı:";
            // 
            // txtPersonelFirmaAd
            // 
            this.txtPersonelFirmaAd.Location = new System.Drawing.Point(126, 183);
            this.txtPersonelFirmaAd.Name = "txtPersonelFirmaAd";
            this.txtPersonelFirmaAd.Size = new System.Drawing.Size(255, 22);
            this.txtPersonelFirmaAd.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "E Mail Adres:";
            // 
            // txtPersonelEMail
            // 
            this.txtPersonelEMail.Location = new System.Drawing.Point(126, 155);
            this.txtPersonelEMail.Name = "txtPersonelEMail";
            this.txtPersonelEMail.Size = new System.Drawing.Size(255, 22);
            this.txtPersonelEMail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ülke Adı:";
            // 
            // txtPersonelUlkeAd
            // 
            this.txtPersonelUlkeAd.Location = new System.Drawing.Point(126, 214);
            this.txtPersonelUlkeAd.Name = "txtPersonelUlkeAd";
            this.txtPersonelUlkeAd.Size = new System.Drawing.Size(255, 22);
            this.txtPersonelUlkeAd.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPersonelKaydet);
            this.Controls.Add(this.btnPersonelGetir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Personel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPersonel;
        private System.Windows.Forms.Button btnPersonelGetir;
        private System.Windows.Forms.Button btnPersonelKaydet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPersonelEMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPersonelFirmaAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonelSoyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonelIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelUlkeAd;
        private System.Windows.Forms.Label label6;
    }
}

