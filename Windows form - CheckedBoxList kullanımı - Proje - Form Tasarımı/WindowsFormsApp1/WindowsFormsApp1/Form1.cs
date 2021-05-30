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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedBoxDoldurV1();
        }

        private void checkedBoxDoldurV1()
        {
            foreach (Urun item in databese.UrunTablo)
            {
                chkListBox.Items.Add(item);
            }
        }

        private void chkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checklistbox = (CheckedListBox)sender;

            if (e.NewValue == CheckState.Checked)
            {
                Urun secilenUrun = checklistbox.Items[e.Index] as Urun;
                pctUrunResim.Image = Image.FromFile(secilenUrun.urunResim);
                txtKategori.Text = secilenUrun.urunKategori;
                txtUrunAciklama.Text = secilenUrun.aciklama;
                txtUrunAdi.Text = secilenUrun.urunAdi;
                txtYazar.Text = secilenUrun.yazar;
                txtStokAdet.Text = secilenUrun.stokAdet.ToString();
            }
        }
    }
}
