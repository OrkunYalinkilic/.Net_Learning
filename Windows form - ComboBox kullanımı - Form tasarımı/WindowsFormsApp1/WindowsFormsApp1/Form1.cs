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

        private void cmbUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            object o1 = cmbUrunListe.SelectedItem;
            Urun u1 = (Urun)o1;

            txtUrunAdi.Text = u1.urunAdi;
            txtKategori.Text = u1.urunKategori;
            txtStokAdet.Text = u1.stokAdet.ToString();
            txtUrunAciklama.Text = u1.aciklama;
            txtYazar.Text = u1.yazar;

            pctUrunResim.Image = Image.FromFile(u1.urunResim);
            pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

            //ComboBox secilenComboBox = sender as ComboBox;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ComboBoxDoldurV1(); // items.add ile basıldı.

            ComboBoxDoldurV2();  //data source ile basıldı.
        }


        private void ComboBoxDoldurV1()
        {
            foreach (Urun item in Databese.UrunTablo)
            {
                cmbUrunListe.Items.Add(item);
            }
        }

        private void ComboBoxDoldurV2()
        {
            cmbUrunListe.DataSource = Databese.UrunTablo;
        }

    }
}
