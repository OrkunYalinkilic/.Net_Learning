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
    public partial class popUpMesaj : Form
    {
        musteri musteriDatasi;

        public popUpMesaj(musteri data)
        {
            musteriDatasi = data;
            InitializeComponent();

            txtIsım.Text = musteriDatasi.isim;
            txtSoyisim.Text = musteriDatasi.soyisim;
            txtTamAd.Text = musteriDatasi.tamAdi;
            txtTelefon.Text = musteriDatasi.telefonNumara;
            txtEmail.Text = musteriDatasi.eMailAdres;
            txtIlIlce.Text = musteriDatasi.il + "-" + musteriDatasi.ilce;
            rchAdres.Text = musteriDatasi.adres;


        }

        private void popUpMesaj_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
