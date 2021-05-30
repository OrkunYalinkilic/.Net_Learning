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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            Kullanici bulunanKullanici = SanalDatabese.kullaniciTablosu.Find(i => i.kullaniciAdi == kullaniciAdi && i.sifre == sifre);

            if (bulunanKullanici != null)
            {
                Selamla _selamla = new Selamla(bulunanKullanici);
                _selamla.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender; //yakaladım.
            t1.BackColor = Color.Yellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender; //yakaladım.
            t1.BackColor = Color.White;
        }
    }
}
