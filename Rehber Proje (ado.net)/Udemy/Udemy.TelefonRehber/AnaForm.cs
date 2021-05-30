using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.Entities;

namespace Udemy.TelefonRehber
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            int returnValue = bll.KayitEkle(Txt_Y_Isim.Text, Txt_Y_Soyisim.Text, Txt_Y_Telefon1.Text,
                Txt_Y_Telefon2.Text, Txt_Y_Telefon3.Text, Txt_Y_EMail.Text, Txt_Y_WebAdres.Text,
                Txt_Y_Adres.Text, Txt_Y_Aciklama.Text);
            if (returnValue > 0)
            {
                MessageBox.Show("Yeni Kayit Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeDoldur();
            }

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            ListeDoldur();
        }

        private void ListeDoldur()
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            List<Rehber> RehberListesi = bll.KayitListe();
            if (RehberListesi != null && RehberListesi.Count > 0)
            {
                lst_liste.DataSource = RehberListesi; // override to string yapılmalı.
            }
        }

        private void lst_liste_DoubleClick(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;
            Rehber SecilenKayit = (Rehber)lst.SelectedItem; // boxing - unboxing

            if (SecilenKayit != null)
            {
                txt_G_Isim.Text = SecilenKayit.isim;
                txt_G_Soyisim.Text = SecilenKayit.soyisim;
                txt_G_Telefın1.Text = SecilenKayit.telefonNumarasiI;
                txt_G_Telefon3.Text = SecilenKayit.telefonNumarasiIII;
                txt_G_EMail.Text = SecilenKayit.EMailAdres;
                txt_G_Adres.Text = SecilenKayit.Adres;
                txt_G_Telefon2.Text = SecilenKayit.telefonNumarasiII;
                txt_G_WebAdres.Text = SecilenKayit.WebAdres;
                txt_G_Aciklama.Text = SecilenKayit.aciklama;
            }

        }

        private void btnKayitDuzenle_Click(object sender, EventArgs e)
        {
            Guid id = ((Rehber)lst_liste.SelectedItem).ID;
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            int returnValues = bll.KayitDuzenle(id, txt_G_Isim.Text, txt_G_Soyisim.Text, txt_G_Telefın1.Text, txt_G_Telefon2.Text,
                txt_G_Telefon3.Text, txt_G_EMail.Text, txt_G_WebAdres.Text, txt_G_Adres.Text, txt_G_Aciklama.Text);

            if (returnValues > 0)
            {
                ListeDoldur();
                MessageBox.Show("Kayidiniz Guncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            Guid id = ((Rehber)lst_liste.SelectedItem).ID;
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            int returnValue = bll.KayitSil(id);
            if (returnValue>0)
            {
                ListeDoldur();
                MessageBox.Show("Kayidiniz Silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
