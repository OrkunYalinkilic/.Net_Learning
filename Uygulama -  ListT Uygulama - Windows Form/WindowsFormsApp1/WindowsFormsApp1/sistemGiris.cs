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
    public partial class sistemGiris : Form
    {
        public sistemGiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Yellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if( !string.IsNullOrEmpty(txtKullaniciAdi.Text) || !string.IsNullOrEmpty(txtSifre.Text))
            {

            }

            else
            {
                MessageBox.Show("Lutfen giris bilgilerinizi eksiksik olarak giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
