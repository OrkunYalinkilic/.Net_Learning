using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniMusteriEkle_Click(object sender, EventArgs e)
        {
            int eklemeIslemSonuc = musteriEkle(new Musteri()
            {
                isim = txtIsım.Text,
                soyisim = txtSoyisim.Text,
                emailAdres = txtEmailAdresi.Text,
                telefonNumarasi = txtTelefonNumarasi.Text,
            });

            if (eklemeIslemSonuc > 0)
            {
                DialogResult res = MessageBox.Show("Müsteri Ekleme İslemi Basarili, Yeni Musteri Eklemek İster Misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ekranTemizle();
                musteriListele();

                if (res == DialogResult.Yes)
                {
                    //Zaten giriş sayfasına geçiyo. MusteriEkle fonksiyonuna gerek yok.

                    bildirimCubugu = new NotifyIcon();
                    bildirimCubugu.Visible = true;
                    bildirimCubugu.BalloonTipTitle = "Müşteri Adet Bilgisi";
                    bildirimCubugu.Icon = SystemIcons.Information;
                    //bildirimCubugu.BalloonTipIcon = ToolTipIcon.Info;
                    bildirimCubugu.BalloonTipText = "Toplam Müşteri Adedi: " + sanalDatabese.musteriListe.Count.ToString();
                    bildirimCubugu.ShowBalloonTip(2000);



                }
                else if (res == DialogResult.No)
                {

                }

                else
                {

                }



            }
            else
            {
                MessageBox.Show("Musteri Ekleme Islemi Gerceklestirilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private int musteriEkle(Musteri data)
        {


            sanalDatabese.musteriListe.Add(data);
            return 1;
        }

        private void ekranTemizle()
        {
            txtIsım.Text = string.Empty;
            txtSoyisim.Text = string.Empty;
            txtEmailAdresi.Text = string.Empty;
            txtTelefonNumarasi.Text = string.Empty;
        }

        private void musteriListele()
        {
            lstMusteriler.DataSource = sanalDatabese.musteriListe;
        }

    }
}
