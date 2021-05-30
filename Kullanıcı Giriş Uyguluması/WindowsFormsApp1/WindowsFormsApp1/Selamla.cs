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
    public partial class Selamla : Form
    {
        public Selamla(Kullanici bulunanKullanici)
        {
            InitializeComponent();
            txtIsım.Text = bulunanKullanici.isim;
            txtSoyisim.Text = bulunanKullanici.soyisim;
            txtKullaniciAdi.Text = bulunanKullanici.kullaniciAdi;
            txtKullaniciAdi.Enabled = false;
            txtSifre.Text = bulunanKullanici.sifre;
            txtAciklama.Text = bulunanKullanici.aciklama;
            btnGuncelle.Tag = bulunanKullanici.id;
        }

        private void Selamla_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Button btnGuncelleYakala = (Button)sender;
            int id = (int) btnGuncelle.Tag;
            int index = SanalDatabese.kullaniciTablosu.FindIndex(i => i.id == id);
            SanalDatabese.kullaniciTablosu[index].isim = txtIsım.Text;
            SanalDatabese.kullaniciTablosu[index].soyisim = txtSoyisim.Text;
            SanalDatabese.kullaniciTablosu[index].sifre = txtSifre.Text;
            SanalDatabese.kullaniciTablosu[index].aciklama = txtAciklama.Text;

        }
    }
}
