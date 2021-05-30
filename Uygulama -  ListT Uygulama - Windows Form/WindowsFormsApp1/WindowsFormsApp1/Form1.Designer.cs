namespace WindowsFormsApp1
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxIslemListe = new System.Windows.Forms.GroupBox();
            this.btnUygulamaKapat = new System.Windows.Forms.Button();
            this.btnKayitListele = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblZaman = new System.Windows.Forms.Label();
            this.tm_zamanla = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxIslemListe.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.grpBoxIslemListe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 772);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grpBoxIslemListe
            // 
            this.grpBoxIslemListe.Controls.Add(this.btnUygulamaKapat);
            this.grpBoxIslemListe.Controls.Add(this.btnKayitListele);
            this.grpBoxIslemListe.Controls.Add(this.btnYeniKayit);
            this.grpBoxIslemListe.Location = new System.Drawing.Point(12, 285);
            this.grpBoxIslemListe.Name = "grpBoxIslemListe";
            this.grpBoxIslemListe.Size = new System.Drawing.Size(237, 179);
            this.grpBoxIslemListe.TabIndex = 3;
            this.grpBoxIslemListe.TabStop = false;
            this.grpBoxIslemListe.Text = "İşlem Listesi";
            // 
            // btnUygulamaKapat
            // 
            this.btnUygulamaKapat.Location = new System.Drawing.Point(6, 122);
            this.btnUygulamaKapat.Name = "btnUygulamaKapat";
            this.btnUygulamaKapat.Size = new System.Drawing.Size(225, 39);
            this.btnUygulamaKapat.TabIndex = 5;
            this.btnUygulamaKapat.Text = "Uygulama Kapat";
            this.btnUygulamaKapat.UseVisualStyleBackColor = true;
            // 
            // btnKayitListele
            // 
            this.btnKayitListele.Location = new System.Drawing.Point(6, 77);
            this.btnKayitListele.Name = "btnKayitListele";
            this.btnKayitListele.Size = new System.Drawing.Size(225, 39);
            this.btnKayitListele.TabIndex = 5;
            this.btnKayitListele.Text = "Kayit Listele";
            this.btnKayitListele.UseVisualStyleBackColor = true;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(6, 32);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(225, 39);
            this.btnYeniKayit.TabIndex = 4;
            this.btnYeniKayit.Text = "Yeni Kayit";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblZaman);
            this.panel2.Location = new System.Drawing.Point(1224, 694);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 66);
            this.panel2.TabIndex = 6;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(23, 19);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(209, 29);
            this.lblZaman.TabIndex = 0;
            this.lblZaman.Text = "06.10.2019 15:30";
            this.lblZaman.Click += new System.EventHandler(this.label1_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 772);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "form";
            this.Text = "To Do List Uygulaması";
            this.Load += new System.EventHandler(this.form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxIslemListe.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBoxIslemListe;
        private System.Windows.Forms.Button btnUygulamaKapat;
        private System.Windows.Forms.Button btnKayitListele;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer tm_zamanla;
    }
}

