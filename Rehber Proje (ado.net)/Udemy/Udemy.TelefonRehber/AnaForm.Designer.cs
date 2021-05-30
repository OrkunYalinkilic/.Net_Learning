namespace Udemy.TelefonRehber
{
    partial class AnaForm
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
            this.lst_liste = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Y_Isim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Y_Soyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Y_Telefon1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Y_Telefon2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Y_Telefon3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Y_EMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Y_WebAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Y_Adres = new System.Windows.Forms.TextBox();
            this.Txt_Y_Aciklama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_G_Aciklama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_G_Telefon3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_G_Adres = new System.Windows.Forms.TextBox();
            this.txt_G_Telefon2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_G_WebAdres = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_G_Telefın1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_G_EMail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_G_Soyisim = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_G_Isim = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnKayitDuzenle = new System.Windows.Forms.Button();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_liste);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 641);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste";
            // 
            // lst_liste
            // 
            this.lst_liste.FormattingEnabled = true;
            this.lst_liste.ItemHeight = 16;
            this.lst_liste.Location = new System.Drawing.Point(6, 17);
            this.lst_liste.Name = "lst_liste";
            this.lst_liste.Size = new System.Drawing.Size(320, 612);
            this.lst_liste.TabIndex = 0;
            this.lst_liste.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lst_liste.DoubleClick += new System.EventHandler(this.lst_liste_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Y_Aciklama);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Txt_Y_Telefon3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Txt_Y_Adres);
            this.groupBox2.Controls.Add(this.Txt_Y_Telefon2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Txt_Y_WebAdres);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Txt_Y_Telefon1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Txt_Y_EMail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Txt_Y_Soyisim);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Txt_Y_Isim);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(350, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kayıt Ekleme İşlemi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_G_Aciklama);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_G_Telefon3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_G_Adres);
            this.groupBox3.Controls.Add(this.txt_G_Telefon2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_G_WebAdres);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_G_Telefın1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txt_G_EMail);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txt_G_Soyisim);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txt_G_Isim);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(350, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(897, 277);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seçili Olan Kayıdı Güncelle/Sil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // Txt_Y_Isim
            // 
            this.Txt_Y_Isim.Location = new System.Drawing.Point(125, 42);
            this.Txt_Y_Isim.Name = "Txt_Y_Isim";
            this.Txt_Y_Isim.Size = new System.Drawing.Size(165, 23);
            this.Txt_Y_Isim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // Txt_Y_Soyisim
            // 
            this.Txt_Y_Soyisim.Location = new System.Drawing.Point(125, 71);
            this.Txt_Y_Soyisim.Name = "Txt_Y_Soyisim";
            this.Txt_Y_Soyisim.Size = new System.Drawing.Size(165, 23);
            this.Txt_Y_Soyisim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon I";
            // 
            // Txt_Y_Telefon1
            // 
            this.Txt_Y_Telefon1.Location = new System.Drawing.Point(390, 42);
            this.Txt_Y_Telefon1.Name = "Txt_Y_Telefon1";
            this.Txt_Y_Telefon1.Size = new System.Drawing.Size(165, 23);
            this.Txt_Y_Telefon1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon II";
            // 
            // Txt_Y_Telefon2
            // 
            this.Txt_Y_Telefon2.Location = new System.Drawing.Point(390, 74);
            this.Txt_Y_Telefon2.Name = "Txt_Y_Telefon2";
            this.Txt_Y_Telefon2.Size = new System.Drawing.Size(165, 23);
            this.Txt_Y_Telefon2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon III";
            // 
            // Txt_Y_Telefon3
            // 
            this.Txt_Y_Telefon3.Location = new System.Drawing.Point(390, 103);
            this.Txt_Y_Telefon3.Name = "Txt_Y_Telefon3";
            this.Txt_Y_Telefon3.Size = new System.Drawing.Size(165, 23);
            this.Txt_Y_Telefon3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "E-Mail Adres";
            // 
            // Txt_Y_EMail
            // 
            this.Txt_Y_EMail.Location = new System.Drawing.Point(125, 103);
            this.Txt_Y_EMail.Name = "Txt_Y_EMail";
            this.Txt_Y_EMail.Size = new System.Drawing.Size(165, 23);
            this.Txt_Y_EMail.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Web Adres";
            // 
            // Txt_Y_WebAdres
            // 
            this.Txt_Y_WebAdres.Location = new System.Drawing.Point(654, 45);
            this.Txt_Y_WebAdres.Name = "Txt_Y_WebAdres";
            this.Txt_Y_WebAdres.Size = new System.Drawing.Size(216, 23);
            this.Txt_Y_WebAdres.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adres";
            // 
            // Txt_Y_Adres
            // 
            this.Txt_Y_Adres.Location = new System.Drawing.Point(654, 77);
            this.Txt_Y_Adres.Multiline = true;
            this.Txt_Y_Adres.Name = "Txt_Y_Adres";
            this.Txt_Y_Adres.Size = new System.Drawing.Size(216, 49);
            this.Txt_Y_Adres.TabIndex = 1;
            // 
            // Txt_Y_Aciklama
            // 
            this.Txt_Y_Aciklama.Location = new System.Drawing.Point(39, 154);
            this.Txt_Y_Aciklama.Multiline = true;
            this.Txt_Y_Aciklama.Name = "Txt_Y_Aciklama";
            this.Txt_Y_Aciklama.Size = new System.Drawing.Size(831, 106);
            this.Txt_Y_Aciklama.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Açıklama";
            // 
            // txt_G_Aciklama
            // 
            this.txt_G_Aciklama.Location = new System.Drawing.Point(34, 148);
            this.txt_G_Aciklama.Multiline = true;
            this.txt_G_Aciklama.Name = "txt_G_Aciklama";
            this.txt_G_Aciklama.Size = new System.Drawing.Size(831, 123);
            this.txt_G_Aciklama.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Açıklama";
            // 
            // txt_G_Telefon3
            // 
            this.txt_G_Telefon3.Location = new System.Drawing.Point(385, 97);
            this.txt_G_Telefon3.Name = "txt_G_Telefon3";
            this.txt_G_Telefon3.Size = new System.Drawing.Size(165, 23);
            this.txt_G_Telefon3.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Telefon III";
            // 
            // txt_G_Adres
            // 
            this.txt_G_Adres.Location = new System.Drawing.Point(649, 71);
            this.txt_G_Adres.Multiline = true;
            this.txt_G_Adres.Name = "txt_G_Adres";
            this.txt_G_Adres.Size = new System.Drawing.Size(216, 49);
            this.txt_G_Adres.TabIndex = 17;
            // 
            // txt_G_Telefon2
            // 
            this.txt_G_Telefon2.Location = new System.Drawing.Point(385, 68);
            this.txt_G_Telefon2.Name = "txt_G_Telefon2";
            this.txt_G_Telefon2.Size = new System.Drawing.Size(165, 23);
            this.txt_G_Telefon2.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(564, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Adres";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(300, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Telefon II";
            // 
            // txt_G_WebAdres
            // 
            this.txt_G_WebAdres.Location = new System.Drawing.Point(649, 39);
            this.txt_G_WebAdres.Name = "txt_G_WebAdres";
            this.txt_G_WebAdres.Size = new System.Drawing.Size(216, 23);
            this.txt_G_WebAdres.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(564, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Web Adres";
            // 
            // txt_G_Telefın1
            // 
            this.txt_G_Telefın1.Location = new System.Drawing.Point(385, 36);
            this.txt_G_Telefın1.Name = "txt_G_Telefın1";
            this.txt_G_Telefın1.Size = new System.Drawing.Size(165, 23);
            this.txt_G_Telefın1.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(300, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "Telefon I";
            // 
            // txt_G_EMail
            // 
            this.txt_G_EMail.Location = new System.Drawing.Point(120, 97);
            this.txt_G_EMail.Name = "txt_G_EMail";
            this.txt_G_EMail.Size = new System.Drawing.Size(165, 23);
            this.txt_G_EMail.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "E-Mail Adres";
            // 
            // txt_G_Soyisim
            // 
            this.txt_G_Soyisim.Location = new System.Drawing.Point(120, 65);
            this.txt_G_Soyisim.Name = "txt_G_Soyisim";
            this.txt_G_Soyisim.Size = new System.Drawing.Size(165, 23);
            this.txt_G_Soyisim.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "Soyisim";
            // 
            // txt_G_Isim
            // 
            this.txt_G_Isim.Location = new System.Drawing.Point(120, 36);
            this.txt_G_Isim.Name = "txt_G_Isim";
            this.txt_G_Isim.Size = new System.Drawing.Size(165, 23);
            this.txt_G_Isim.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "İsim";
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(350, 292);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(897, 36);
            this.btnYeniKayit.TabIndex = 3;
            this.btnYeniKayit.Text = "YENİ KAYIT OLUŞTUR";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnKayitDuzenle
            // 
            this.btnKayitDuzenle.Location = new System.Drawing.Point(350, 617);
            this.btnKayitDuzenle.Name = "btnKayitDuzenle";
            this.btnKayitDuzenle.Size = new System.Drawing.Size(440, 36);
            this.btnKayitDuzenle.TabIndex = 4;
            this.btnKayitDuzenle.Text = "KAYIT DÜZENLE";
            this.btnKayitDuzenle.UseVisualStyleBackColor = true;
            this.btnKayitDuzenle.Click += new System.EventHandler(this.btnKayitDuzenle_Click);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Location = new System.Drawing.Point(796, 617);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(451, 36);
            this.btnKayitSil.TabIndex = 5;
            this.btnKayitSil.Text = "KAYIT SİL";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 658);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.btnKayitDuzenle);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Rehberi Uygulaması";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_liste;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_Y_Aciklama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Y_Telefon3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Y_Adres;
        private System.Windows.Forms.TextBox Txt_Y_Telefon2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Y_WebAdres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Y_Telefon1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Y_EMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Y_Soyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Y_Isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_G_Aciklama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_G_Telefon3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_G_Adres;
        private System.Windows.Forms.TextBox txt_G_Telefon2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_G_WebAdres;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_G_Telefın1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_G_EMail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_G_Soyisim;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_G_Isim;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnKayitDuzenle;
        private System.Windows.Forms.Button btnKayitSil;
    }
}