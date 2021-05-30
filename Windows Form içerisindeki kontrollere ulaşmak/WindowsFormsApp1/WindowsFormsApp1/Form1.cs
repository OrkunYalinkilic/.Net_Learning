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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox T = (TextBox)item;
                    T.Text = string.Empty;
                }
            }
        }

        private void formTemizle2Index()
        {
            ((TextBox)this.Controls["txtIsım"]).Text = string.Empty;
            ((TextBox)this.Controls["txtSoyisim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtEmailAdres"]).Text = string.Empty;
            ((TextBox)this.Controls["txtTelefonNo"]).Text = string.Empty;

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Temizlemek istediginize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                formTemizle();
                //formTemizle2Index();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmKayitOnIzlemeEkrani kayitOnIzleme = new frmKayitOnIzlemeEkrani();

            ((TextBox)kayitOnIzleme.Controls["txtIsım"]).Text = txtIsım.Text;
            ((TextBox)kayitOnIzleme.Controls["txtSoyisim"]).Text = txtSoyisim.Text;
            ((TextBox)kayitOnIzleme.Controls["txtEmailAdres"]).Text = txtEmailAdres.Text;
            ((TextBox)kayitOnIzleme.Controls["txtTelefonNo"]).Text = txtTelefonNo.Text;

            kayitOnIzleme.ShowDialog();
        }
    }
}
