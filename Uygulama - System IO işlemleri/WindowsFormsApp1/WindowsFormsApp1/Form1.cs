using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{ 
    public partial class Form1 : Form
    {

        DataIslemleri d;
        List<Personel> PersonelListe ;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPersonelGetir_Click(object sender, EventArgs e)
        {
             d = new DataIslemleri();
             PersonelListe = d.personelOlustur(150);
            lstPersonel.DataSource = PersonelListe;
        }

        private void lstPersonel_DoubleClick(object sender, EventArgs e)
        {
            Personel secilenPersonel = (Personel)lstPersonel.SelectedItem;
            txtPersonelID.Text = secilenPersonel.id.ToString();
            txtPersonelIsim.Text = secilenPersonel.isim;
            txtPersonelSoyisim.Text = secilenPersonel.soyisim;
            txtPersonelFirmaAd.Text = secilenPersonel.firmaAdi;
            txtPersonelUlkeAd.Text = secilenPersonel.ulke;
            txtPersonelEMail.Text = secilenPersonel.eMailAdres;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            

        }
    }
}
