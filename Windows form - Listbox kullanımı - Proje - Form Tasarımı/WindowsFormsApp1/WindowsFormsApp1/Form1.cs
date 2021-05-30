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

        private void listUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int urunSecimAdet = listUrunler.SelectedItems.Count;

            if (urunSecimAdet == 1)
            {

                ListBox lbox = (ListBox)sender;
                Urun u1 = (Urun)lbox.SelectedItem;

                this.txtUrunAdi.Text = u1.urunAdi;
                this.txtYazar.Text = u1.yazar;
                this.txtUrunAciklama.Text = u1.aciklama;
                this.txtStokAdet.Text = u1.stokAdet.ToString();
                this.txtKategori.Text = u1.urunKategori;

                this.pctUrunResim.Image = Image.FromFile(u1.urunResim);
                this.pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            else if (urunSecimAdet > 1)
            {
                List<Urun> secilenUrunler = new List<Urun>();

                foreach (var item in listUrunler.SelectedItems)
                {
                    secilenUrunler.Add(item as Urun);
                }

                KullaniciUrunSecimleri secimlerForm = new KullaniciUrunSecimleri(secilenUrunler.ToArray());
                secimlerForm.ShowDialog();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxDoldurV1();
            //listBoxDoldurV2();
        }

        private void listBoxDoldurV1()
        {
            foreach (Urun item in Databese.UrunTablo)
            {
                listUrunler.Items.Add(item);

                listUrunler.DisplayMember = "urunAdi";
            }
        }

        private void listBoxDoldurV2()
        {
            listUrunler.DataSource = Databese.UrunTablo;
            listUrunler.DisplayMember = "urunAdi";
        }

    }
}
